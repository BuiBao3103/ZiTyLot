using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZiTyLot.Helper
{
    public static class ExcelHelper
    {
        public static void ExportToExcel<T>(List<T> items, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    var worksheet = excelPackage.Workbook.Worksheets.Add(typeof(T).Name);

                    var properties = typeof(T).GetProperties()
                        .Where(p => p.Name != "Deleted_at")
                        .Where(p => !typeof(System.Collections.IEnumerable).IsAssignableFrom(p.PropertyType) || p.PropertyType == typeof(string))
                        .Where(p => !p.PropertyType.IsClass || p.PropertyType == typeof(string))
                        .ToArray();

                    // Định dạng tiêu đề
                    for (int columnIndex = 1; columnIndex <= properties.Length; columnIndex++)
                    {
                        var property = properties[columnIndex - 1];
                        var cell = worksheet.Cells[1, columnIndex];
                        cell.Value = property.Name;

                        cell.Style.Font.Bold = true;
                        cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        cell.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                        cell.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        cell.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        cell.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        cell.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    }

                    // Định dạng dữ liệu
                    for (int i = 0; i < items.Count; i++)
                    {
                        var item = items[i];

                        for (int columnIndex = 1; columnIndex <= properties.Length; columnIndex++)
                        {
                            var property = properties[columnIndex - 1];
                            var cell = worksheet.Cells[i + 2, columnIndex];
                            var value = property.GetValue(item);

                            if (value is DateTime dateTime)
                            {
                                cell.Style.Numberformat.Format = "yyyy-mm-dd hh:mm:ss";
                                cell.Value = dateTime;
                            }
                            else if (value is int || value is long || value is decimal || value is double)
                            {
                                cell.Value = Convert.ToDouble(value);
                            }
                            else
                            {
                                cell.Value = value?.ToString() ?? string.Empty;
                            }

                            cell.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                            cell.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                            cell.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                            cell.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                            cell.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                            cell.Style.WrapText = true;
                        }
                    }

                    // Tự động điều chỉnh độ rộng của từng cột
                    for (int columnIndex = 1; columnIndex <= properties.Length; columnIndex++)
                    {
                        var column = worksheet.Column(columnIndex);
                        column.AutoFit();

                        // Đảm bảo độ rộng tối thiểu cho cột thời gian
                        if (properties[columnIndex - 1].PropertyType == typeof(DateTime))
                        {
                            if (column.Width < 20)
                            {
                                column.Width = 20;
                            }
                        }
                    }

                    // Lưu tệp
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}