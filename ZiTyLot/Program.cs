using System;
using System.Windows.Forms;
using ZiTyLot.Config;
using ZiTyLot.BUS;
using System.Collections.Generic;
using ZiTyLot.Helper;

namespace ZiTyLot
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Attempt to connect to the database and fetch data using MyDao
            try
            {
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open(); // Open connection here
                    Console.WriteLine("Database connection successful.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Terminate the application
            }

            // Start the main form of the application
            //Application.Run(new Login());

            // Example usage of MyBUS
            //Example.GetAllRecords();
            //Example.GetPaginatedRecords();
            //Example.AddRecord();
            //Example.UpdateRecord();
            //Example.DeleteRecord();

        }
    }
    public class Example
    {
        private static MyBUS myBus = new MyBUS();


        public static void AddRecord()
        {
            try
            {
                MyDTO newItem = new MyDTO { Name = "New Item" };
                myBus.Add(newItem);
                Console.WriteLine(newItem);
                Console.WriteLine("Record added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateRecord()
        {
            try
            {
                int idForUpdate = 3;
                MyDTO existMy = myBus.GetById(idForUpdate);
                existMy.Name = "Updated Item";
                myBus.Update(existMy);
                Console.WriteLine("Record updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void DeleteRecord()
        {
            try
            {
                int idToDelete = 1;
                myBus.Delete(idToDelete);
                Console.WriteLine("Record deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void GetAllRecords()
        {
            try
            {
                // Get all records
                Console.WriteLine("Get All");
                List<MyDTO> allItems = myBus.GetAll();
                Console.WriteLine("All Records:");
                foreach (var item in allItems)
                {
                    Console.WriteLine(item);
                }
                // Get all records with filter
                Console.WriteLine("Get All with filter");
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition { Column = "name", Operator = ComparisonOperator.Like, Value = "Item" },
                    new FilterCondition { Column = "id", Operator = ComparisonOperator.GreaterThan, Value = "1" }
                };
                List<MyDTO> filteredItems = myBus.GetAll(filters);
                Console.WriteLine("Filtered Records:");
                foreach (var item in filteredItems)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void GetPaginatedRecords()
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition { Column = "Name", Operator = ComparisonOperator.Like, Value = "" }
                };
                Pageable pageable = new Pageable { PageNumber = 2, PageSize = 2, SortBy = "id", SortOrder = "DESC" };
                Page<MyDTO> page = myBus.GetAllPagination(pageable, filters);
                Console.WriteLine("Paginated Records:");
                foreach (var item in page.Content)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Current Page: {page.Pageable.PageNumber}");
                Console.WriteLine($"Total Records: {page.TotalElements}");
                Console.WriteLine($"Total Pages: {page.TotalPages}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
