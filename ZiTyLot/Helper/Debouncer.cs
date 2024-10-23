using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZiTyLot.Helper
{
    internal class Debouncer
    {
        private CancellationTokenSource _cancellationTokenSource;
        public async Task DebounceAsync(Func<Task> action, int delayMilliseconds)
        {
            // Cancel the previous token if it exists
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
                _cancellationTokenSource.Dispose();
            }

            // Create a new cancellation token
            _cancellationTokenSource = new CancellationTokenSource();

            try
            {
                // Wait for the delay or cancellation
                await Task.Delay(delayMilliseconds, _cancellationTokenSource.Token);

                // If no cancellation occurred, invoke the action
                await action();
            }
            catch (TaskCanceledException)
            {
                // Swallow the exception because it means the task was canceled
            }
        }

    }
}
