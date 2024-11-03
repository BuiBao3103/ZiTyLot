using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Config;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;
using ZiTyLot.GUI;
namespace ZiTyLot
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
            // Start the main form of the application
            //Application.Run(new Login2());
            //Application.Run(new Login());


            // Example usage of BUS
            //Example.GetAllRecords();
            //Example.GetPaginatedRecords();
            //Example.getById();
            //Example.AddRecord();
            //Example.UpdateRecord();
            //Example.DeleteRecord();
            //Example.Populate();


        }
    }
    public class Example
    {
        private static ABUS aBus = new ABUS();
        private static BBUS bBus = new BBUS();

        public static void Populate()
        {
            try
            {
                Console.WriteLine("Class A:");
                A a = aBus.GetById(1);
                Console.WriteLine("Before populate:");
                Console.WriteLine(a);
                Console.WriteLine("After populate:");
                a = aBus.PopulateBs(a);
                Console.WriteLine(a);

                Console.WriteLine("Class B:");
                B b = bBus.GetById(1);
                Console.WriteLine("Before populate:");
                Console.WriteLine(b);
                Console.WriteLine("After populate:");
                b = bBus.PopulationA(b);
                Console.WriteLine(b);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void AddRecord()
        {
            try
            {
                A newItem = new A { Name = "", Type = AType.EMPTY };
                aBus.Add(newItem);
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
                int idForUpdate = 4;
                A existMy = aBus.GetById(idForUpdate);
                existMy.Name = "Updated Item";
                existMy.Type = AType.IN_USE;
                aBus.Update(existMy);
                Console.WriteLine("Record updated successfully.");
                A updatedItem = aBus.GetById(idForUpdate);
                Console.WriteLine(updatedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while update record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void DeleteRecord()
        {
            //Code in UI
            try
            {
                int idToDelete = 1;
                aBus.Delete(idToDelete);
                Console.WriteLine("Record deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void GetAllRecords()
        {
            try
            {
                // Get all records
                Console.WriteLine("Get All");
                List<A> allItems = aBus.GetAll();
                Console.WriteLine("All Records before populate:");
                foreach (var item in allItems)
                {
                    Console.WriteLine(item);
                }
                // Get all records with filter
                Console.WriteLine("Get All with filter");
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("name", CompOp.Like, "Item"),
                    new FilterCondition("id", CompOp.GreaterThan, "1")
                };
                List<A> filteredItems = aBus.GetAll(filters);
                Console.WriteLine("Filtered Records:");
                foreach (var item in filteredItems)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void GetPaginatedRecords()
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                   new FilterCondition("Name", CompOp.Like, "")
                };
                Pageable pageable = new Pageable { PageNumber = 1, PageSize = 2, SortBy = "", SortOrder = "DESC" };
                //Page<A> page = aBus.GetAllPagination(pageable);
                Page<A> page = aBus.GetAllPagination(pageable, filters);
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
                MessageBox.Show($"An error occurred while fetching record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void getById()
        {
            try
            {
                //int id = 4;
                //A item = aBus.GetById(id);
                //Console.WriteLine("Record by ID:");
                //Console.WriteLine(item);
                int id = 1;
                B item = bBus.GetById(id);
                Console.WriteLine("Record by ID:");
                Console.WriteLine(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
