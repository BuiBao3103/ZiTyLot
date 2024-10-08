﻿using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ZiTyLot.BUS;

namespace ZiTyLot.GUI
{
    public partial class ExcelExample : Form
    {
        private readonly CardBUS cardBus;
        public ExcelExample()
        {
            cardBus = new CardBUS();
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
                        DialogResult result = MessageBox.Show("Download successful: " + selectedFileName + "\nDo you want to open the file?",
                                                               "Download Complete",
                                                               MessageBoxButtons.YesNo,
                                                               MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Mở file
                            System.Diagnostics.Process.Start(selectedFileName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error during download: " + ex.Message);
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Save an Excel File";

                    // Mặc định đặt tên file
                    saveFileDialog.FileName = "CardsData";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        cardBus.ExportCardsToExcel(filePath);

                        // Hiển thị MessageBox với hai lựa chọn
                        DialogResult result = MessageBox.Show("Export successful: " + filePath + "\nDo you want to open the file?",
                                                               "Export Success",
                                                               MessageBoxButtons.YesNo,
                                                               MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            // Mở tệp Excel
                            System.Diagnostics.Process.Start(filePath);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during export: " + ex.Message);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel Files (*.xls)|*.xls";
                    openFileDialog.Title = "Select an Excel File";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        cardBus.ImportCardsFromExcel(filePath);
                        MessageBox.Show("Import successful");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show("Error during import: " + ex.Message);
            }
        }
    }
}
