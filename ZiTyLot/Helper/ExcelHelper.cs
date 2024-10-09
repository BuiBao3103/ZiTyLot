using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ZiTyLot.Helper
{
    public static class ExcelHelper
    {
        public static void ExportToExcel<T>(List<T> items, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                using (var excelPackage = new ExcelPackage())
                {
                    var worksheet = excelPackage.Workbook.Worksheets.Add(typeof(T).Name);
                    var properties = GetProperties<T>();

                    WriteHeader(worksheet, properties);
                    WriteData(worksheet, items, properties);

                    AutoFitColumns(worksheet, properties);
                    SaveFile(excelPackage, filePath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<T> ImportFromExcel<T>(string filePath) where T : new()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var items = new List<T>();

            try
            {
                using (var excelPackage = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = excelPackage.Workbook.Worksheets.First();
                    var columnNames = GetColumnNames(worksheet);
                    var properties = GetProperties<T>();
                    int lastRow = GetLastRow(worksheet);

                    for (int row = 2; row <= lastRow; row++)
                    {
                        T item = new T();
                        MapRowToItem(worksheet, row, columnNames, properties, item);
                        items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return items;
        }

        private static PropertyInfo[] GetProperties<T>()
        {
            return typeof(T).GetProperties()
                .Where(p => p.Name != "Deleted_at" &&
                            (!typeof(System.Collections.IEnumerable).IsAssignableFrom(p.PropertyType) || p.PropertyType == typeof(string)) &&
                            (!p.PropertyType.IsClass || p.PropertyType == typeof(string)))
                .ToArray();
        }

        private static void WriteHeader(ExcelWorksheet worksheet, PropertyInfo[] properties)
        {
            for (int columnIndex = 1; columnIndex <= properties.Length; columnIndex++)
            {
                var property = properties[columnIndex - 1];
                var cell = worksheet.Cells[1, columnIndex];
                cell.Value = property.Name;
                SetHeaderStyle(cell);
            }
        }

        private static void SetHeaderStyle(ExcelRange cell)
        {
            cell.Style.Font.Bold = true;
            cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            cell.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
            SetBorders(cell);
        }

        private static void WriteData<T>(ExcelWorksheet worksheet, List<T> items, PropertyInfo[] properties)
        {
            for (int i = 0; i < items.Count; i++)
            {
                var item = items[i];
                for (int columnIndex = 1; columnIndex <= properties.Length; columnIndex++)
                {
                    var property = properties[columnIndex - 1];
                    var cell = worksheet.Cells[i + 2, columnIndex];
                    var value = property.GetValue(item);
                    SetCellValue(cell, value);
                }
            }
        }

        private static void SetCellValue(ExcelRange cell, object value)
        {
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

            SetBorders(cell);
            cell.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
            cell.Style.WrapText = true;
        }

        private static void SetBorders(ExcelRange cell)
        {
            cell.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            cell.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            cell.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            cell.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
        }

        private static void AutoFitColumns(ExcelWorksheet worksheet, PropertyInfo[] properties)
        {
            for (int columnIndex = 1; columnIndex <= properties.Length; columnIndex++)
            {
                var column = worksheet.Column(columnIndex);
                column.AutoFit();

                if (properties[columnIndex - 1].PropertyType == typeof(DateTime) && column.Width < 20)
                {
                    column.Width = 20;
                }
            }
        }

        private static void SaveFile(ExcelPackage excelPackage, string filePath)
        {
            FileInfo excelFile = new FileInfo(filePath);
            excelPackage.SaveAs(excelFile);
        }

        private static List<string> GetColumnNames(ExcelWorksheet worksheet)
        {
            return Enumerable.Range(1, worksheet.Dimension.Columns)
                             .Select(col => worksheet.Cells[1, col].Text.Trim())
                             .ToList();
        }

        private static int GetLastRow(ExcelWorksheet worksheet)
        {
            int lastRow = 0;
            for (int row = 2; row <= worksheet.Dimension.Rows; row++)
            {
                if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Text))
                {
                    lastRow = row;
                }
            }
            return lastRow;
        }

        private static void MapRowToItem<T>(ExcelWorksheet worksheet, int row, List<string> columnNames, PropertyInfo[] properties, T item)
        {
            foreach (var property in properties)
            {
                int colIndex = columnNames.IndexOf(property.Name);
                if (colIndex >= 0)
                {
                    var cellValue = worksheet.Cells[row, colIndex + 1].Text;
                    if (!string.IsNullOrEmpty(cellValue))
                    {
                        SetPropertyValue(property, item, cellValue);
                    }
                }
            }
        }

        private static void SetPropertyValue(PropertyInfo property, object item, string cellValue)
        {
            // Kiểm tra nếu thuộc tính là Nullable
            bool isNullable = Nullable.GetUnderlyingType(property.PropertyType) != null;

            if (string.IsNullOrWhiteSpace(cellValue))
            {
                if (isNullable)
                {
                    property.SetValue(item, null); // Đặt giá trị null
                }
                return; // Kết thúc hàm nếu ô rỗng
            }

            try
            {
                // Xử lý theo kiểu dữ liệu
                if (property.PropertyType == typeof(DateTime))
                {
                    if (DateTime.TryParse(cellValue, out DateTime dateTime))
                    {
                        property.SetValue(item, dateTime);
                    }
                }
                else if (property.PropertyType == typeof(int) || property.PropertyType == typeof(int?))
                {
                    if (int.TryParse(cellValue, out int intValue))
                    {
                        property.SetValue(item, (int?)intValue); // Đặt giá trị nullable
                    }
                }
                else if (property.PropertyType == typeof(long) || property.PropertyType == typeof(long?))
                {
                    if (long.TryParse(cellValue, out long longValue))
                    {
                        property.SetValue(item, (long?)longValue);
                    }
                }
                else if (property.PropertyType == typeof(decimal) || property.PropertyType == typeof(decimal?))
                {
                    if (decimal.TryParse(cellValue, out decimal decimalValue))
                    {
                        property.SetValue(item, (decimal?)decimalValue);
                    }
                }
                else if (property.PropertyType == typeof(double) || property.PropertyType == typeof(double?))
                {
                    if (double.TryParse(cellValue, out double doubleValue))
                    {
                        property.SetValue(item, (double?)doubleValue);
                    }
                }
                else if (property.PropertyType.IsEnum)
                {
                    try
                    {
                        var enumValue = Enum.Parse(property.PropertyType, cellValue.Trim(), true);
                        property.SetValue(item, enumValue);
                    }
                    catch (ArgumentException)
                    {
                        throw new ArgumentException($"Invalid value '{cellValue}' for enum '{property.PropertyType.Name}'");
                    }
                }
                else
                {
                    property.SetValue(item, cellValue);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error setting property '{property.Name}': {ex.Message}");
            }
        }

    }
}
