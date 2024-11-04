using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Collections.Generic;
using ZiTyLot.ENTITY;
using Font = iTextSharp.text.Font;
using System.Diagnostics;
using System.Windows.Forms;

public static class PdfHelper
{
    public static void ExportBillToPdf(Bill bill, string outputPath, string logoPath)
    {
        // Create new document
        using (Document document = new Document(PageSize.A4, 25, 25, 30, 30))
        {
            // Create PdfWriter
            using (PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create)))
            {
                document.Open();

                // Add Unicode font support
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                Font normalFont = new Font(baseFont, 12);
                Font boldFont = new Font(baseFont, 12, Font.BOLD);
                Font titleFont = new Font(baseFont, 18, Font.BOLD);

                // Add company logo
                if (File.Exists(logoPath))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                    // Scale logo to fit width (leaving 50 units margin on each side)
                    float maxWidth = PageSize.A4.Width - 100;
                    float maxHeight = 80; // Maximum height for logo
                    if (logo.Width > maxWidth || logo.Height > maxHeight)
                    {
                        float scale = Math.Min(maxWidth / logo.Width, maxHeight / logo.Height);
                        logo.ScalePercent(scale * 100);
                    }
                    logo.Alignment = Element.ALIGN_CENTER;
                    document.Add(logo);
                    document.Add(new Paragraph("\n")); // Add space after logo
                }

                // Add title
                Paragraph title = new Paragraph("SERVICE INVOICE", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f;
                document.Add(title);

                // Resident Information
                document.Add(new Paragraph("RESIDENT INFORMATION:", boldFont));
                document.Add(new Paragraph($"Full Name: {bill.Resident.Full_name}", normalFont));
                document.Add(new Paragraph($"Phone Number: {bill.Resident.Phone}", normalFont));
                document.Add(new Paragraph($"Email: {bill.Resident.Email}", normalFont));
                document.Add(new Paragraph($"Apartment ID: {bill.Resident.Apartment_id}", normalFont));
                document.Add(new Paragraph("\n"));

                // Bill Information
                document.Add(new Paragraph("BILL INFORMATION:", boldFont));
                document.Add(new Paragraph($"Bill ID: {bill.Id}", normalFont));
                document.Add(new Paragraph($"Number of Services: {bill.Issue_quantity}", normalFont));
                document.Add(new Paragraph($"Total Fee: {bill.Total_fee:N0} VND", normalFont));
                document.Add(new Paragraph("\n"));

                // Service Details
                document.Add(new Paragraph("SERVICE DETAILS:", boldFont));

                // Create detail table
                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 0.5f, 2f, 2f, 2f, 1.5f });

                // Table headers
                string[] headers = { "No.", "License Plate", "Start Date", "End Date", "Fee" };
                foreach (string header in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, boldFont));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell.Padding = 5;
                    table.AddCell(cell);
                }

                // Add data to table
                int stt = 1;
                foreach (Issue issue in bill.Issues)
                {
                    // Number
                    PdfPCell cell = new PdfPCell(new Phrase(stt++.ToString(), normalFont));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);

                    // License plate
                    cell = new PdfPCell(new Phrase(issue.License_plate, normalFont));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);

                    // Start date
                    cell = new PdfPCell(new Phrase(issue.Start_date.ToString("dd/MM/yyyy"), normalFont));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);

                    // End date
                    cell = new PdfPCell(new Phrase(issue.End_date.ToString("dd/MM/yyyy"), normalFont));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);

                    // Fee
                    cell = new PdfPCell(new Phrase(issue.Fee.ToString("N0") + " VND", normalFont));
                    cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    table.AddCell(cell);
                }

                document.Add(table);

                // Add footer
                Paragraph footer = new Paragraph($"\nInvoice Date: {DateTime.Now:dd/MM/yyyy HH:mm}", normalFont);
                footer.Alignment = Element.ALIGN_RIGHT;
                document.Add(footer);

                document.Close();
            }
        }
    }
    public static void PrintBill(Bill bill)
    {
        // First generate the PDF in temp location
        string tempPdfPath = Path.Combine(Path.GetTempPath(), $"bill_{bill.Id}_{DateTime.Now.Ticks}.pdf");
        try
        {
            // Generate PDF
            string logoPath = @"../../GUI/assets/Zity-logo-256x256px.png";
            ExportBillToPdf(bill, tempPdfPath, logoPath);
            // Print the PDF
            PrintPdf(tempPdfPath);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error printing bill: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            // Cleanup temp file
            if (File.Exists(tempPdfPath))
            {
                try
                {
                    File.Delete(tempPdfPath);
                }
                catch { /* Ignore cleanup errors */ }
            }
        }
    }

    private static void PrintPdf(string pdfPath)
    {
        try
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                {
                    Verb = "print",
                    FileName = pdfPath,
                    UseShellExecute = true,
                    CreateNoWindow = true
                };

                using (Process printProcess = new Process())
                {
                    printProcess.StartInfo = printProcessInfo;
                    printProcess.Start();
                    printProcess.WaitForInputIdle();
                }

                MessageBox.Show("Document sent to printer successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error sending document to printer", ex);
        }
    }
}