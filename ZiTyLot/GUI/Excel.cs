using System;
using System.IO;
using System.Windows.Forms;

namespace ZiTyLot.GUI
{
    public partial class Excel : Form
    {
        public Excel()
        {
            InitializeComponent();
        }

        private void Excel_Load(object sender, EventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles(@"../../Resource/Excel-templates/", "*.xlsx");
            foreach (string file in files)
            {
                string fileName = System.IO.Path.GetFileName(file);
                cbTemplate.Items.Add(fileName);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (cbTemplate.SelectedItem == null)
            {
                MessageBox.Show("Please select a template to download.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = cbTemplate.SelectedItem.ToString();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = saveFileDialog.FileName;
                    string sourceFilePath = Path.Combine("../../Resource/Excel-templates/", cbTemplate.SelectedItem.ToString());

                    try
                    {
                        File.Copy(sourceFilePath, selectedFileName, true);
                        MessageBox.Show("Download successful: " + selectedFileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error during download: " + ex.Message);
                    }
                }
            }
        }
    }
}
