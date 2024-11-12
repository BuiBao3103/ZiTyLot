using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

public class CameraHelper : IDisposable
{
    private readonly Dictionary<string, int> _cameraUsageCount;
    private readonly Dictionary<string, VideoCaptureDevice> _sharedDevices;
    private readonly FilterInfoCollection _cameras;
    private readonly Dictionary<VideoCaptureDevice, NewFrameEventHandler> _frameHandlers;
    private bool _isDisposing;

    public CameraHelper()
    {
        _cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        _cameraUsageCount = new Dictionary<string, int>();
        _sharedDevices = new Dictionary<string, VideoCaptureDevice>();
        _frameHandlers = new Dictionary<VideoCaptureDevice, NewFrameEventHandler>();
        _isDisposing = false;
    }

    public FilterInfoCollection GetAvailableCameras()
    {
        return _cameras;
    }

    public void StartCamera(string cameraId, PictureBox pictureBox, out VideoCaptureDevice cameraDevice)
    {
        if (_isDisposing)
        {
            cameraDevice = null;
            return;
        }

        if (string.IsNullOrEmpty(cameraId))
        {
            throw new ArgumentNullException(nameof(cameraId));
        }

        if (pictureBox == null)
        {
            throw new ArgumentNullException(nameof(pictureBox));
        }

        cameraDevice = GetOrCreateDevice(cameraId);

        NewFrameEventHandler frameHandler = (sender, args) => ProcessNewFrame(pictureBox, args);
        _frameHandlers[cameraDevice] = frameHandler;

        if (!cameraDevice.IsRunning)
        {
            cameraDevice.NewFrame += frameHandler;
            cameraDevice.Start();
        }
        else
        {
            cameraDevice.NewFrame += frameHandler;
        }
    }

    public async Task StopCameraAsync(string cameraId, VideoCaptureDevice cameraDevice, PictureBox pictureBox)
    {
        if (cameraDevice != null)
        {
            try
            {
                if (_frameHandlers.TryGetValue(cameraDevice, out NewFrameEventHandler frameHandler))
                {
                    cameraDevice.NewFrame -= frameHandler;
                    _frameHandlers.Remove(cameraDevice);
                }

                await Task.Run(() => ReleaseDevice(cameraId));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error stopping camera: {ex.Message}");
            }
        }

        try
        {
            if (pictureBox != null && !pictureBox.IsDisposed)
            {
                if (pictureBox.InvokeRequired)
                {
                    pictureBox.Invoke(new Action(() => ClearPictureBox(pictureBox)));
                }
                else
                {
                    ClearPictureBox(pictureBox);
                }
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error cleaning up PictureBox: {ex.Message}");
        }
    }

    private void ClearPictureBox(PictureBox pictureBox)
    {
        if (pictureBox.Image != null)
        {
            var imageToDispose = pictureBox.Image;
            pictureBox.Image = null;
            imageToDispose.Dispose();
        }
    }

    private VideoCaptureDevice GetOrCreateDevice(string cameraId)
    {
        if (!_sharedDevices.ContainsKey(cameraId))
        {
            var device = new VideoCaptureDevice(cameraId);
            _sharedDevices[cameraId] = device;
            _cameraUsageCount[cameraId] = 0;
        }
        _cameraUsageCount[cameraId]++;
        return _sharedDevices[cameraId];
    }

    private void ReleaseDevice(string cameraId)
    {
        if (string.IsNullOrEmpty(cameraId)) return;

        if (_cameraUsageCount.ContainsKey(cameraId))
        {
            _cameraUsageCount[cameraId]--;
            if (_cameraUsageCount[cameraId] <= 0)
            {
                if (_sharedDevices.ContainsKey(cameraId))
                {
                    var device = _sharedDevices[cameraId];
                    try
                    {
                        if (device.IsRunning)
                        {
                            device.SignalToStop();
                            device.WaitForStop();
                        }
                    }
                    finally
                    {
                        _sharedDevices.Remove(cameraId);
                        _cameraUsageCount.Remove(cameraId);
                    }
                }
            }
        }
    }

    private void ProcessNewFrame(PictureBox pictureBox, NewFrameEventArgs args)
    {
        if (pictureBox.IsDisposed || _isDisposing) return;

        try
        {
            var frame = (Bitmap)args.Frame.Clone();
            if (pictureBox.InvokeRequired)
            {
                pictureBox.Invoke(new Action(() => UpdatePictureBox(pictureBox, frame)));
            }
            else
            {
                UpdatePictureBox(pictureBox, frame);
            }
        }
        catch (ObjectDisposedException)
        {
            // Handle cleanup if needed
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error processing frame: {ex.Message}");
        }
    }

    private void UpdatePictureBox(PictureBox pictureBox, Bitmap newImage)
    {
        if (_isDisposing) return;
        var oldImage = pictureBox.Image;
        pictureBox.Image = newImage;
        if (oldImage != null)
        {
            oldImage.Dispose();
        }
    }

    public async Task DisposeAsync()
    {
        _isDisposing = true;
        try
        {
            var tasks = new List<Task>();
            foreach (var deviceId in new List<string>(_sharedDevices.Keys))
            {
                tasks.Add(Task.Run(() => ReleaseDevice(deviceId)));
            }
            await Task.WhenAll(tasks);
            _frameHandlers.Clear();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error disposing CameraHelper: {ex.Message}");
        }
    }

    public void Dispose()
    {
        DisposeAsync().Wait();
    }
    public Image GetImageFromPictureBox(PictureBox pictureBox)
    {
        if (pictureBox.Image != null)
        {
            return (Image)pictureBox.Image.Clone();
        }
        return null;
    }
}