using MySql.Data.MySqlClient;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiTyLot.Config;
using ZiTyLot.Constants;
using ZiTyLot.DTOS;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    internal class IssueDAO : IDAO<Issue>
    {
        private readonly FactoryDAO<Issue> factoryDAO;

        public IssueDAO()
        {
            factoryDAO = new FactoryDAO<Issue>(DatabaseName.Issue);
        }

        public void Add(Issue item)
        {
            factoryDAO.Add(item);
        }

        public void Delete(object id)
        {
            factoryDAO.Delete(id);
        }

        public List<Issue> GetAll(List<FilterCondition> filters = null)
        {
            if (filters == null) filters = new List<FilterCondition>();
            filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
            return factoryDAO.GetAll(filters);
        }

        public Page<Issue> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            if (filters == null) filters = new List<FilterCondition>();
            filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
            return factoryDAO.GetAllPagination(pageable, filters);
        }

        public Issue GetById(object id)
        {
            return factoryDAO.GetById(id);
        }

        public void Update(Issue item)
        {
            factoryDAO.Update(item);
        }

        public List<Issue> GetAllValidIssues(int card_id)
        {
            List<Issue> result = new List<Issue>();
            string querySlot = @"
                SELECT i.*
                    FROM cards c
                        JOIN residents r ON c.resident_id = r.id
                        JOIN bills b ON b.resident_id = r.id
                        JOIN issues i ON i.bill_id = b.id
                    WHERE c.id = @card_id AND i.end_date >= CURRENT_TIMESTAMP;";

            try
            {
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(querySlot, connection))
                    {
                        command.Parameters.AddWithValue("@card_id", card_id);
                        using (var issues = command.ExecuteReader())
                        {
                            while (issues.Read())
                            {
                                Issue issue = new Issue()
                                {
                                    Id = issues.GetInt32("id"),
                                    Start_date = issues.GetDateTime("start_date"),
                                    End_date = issues.GetDateTime("end_date"),
                                    License_plate = issues.GetString("license_plate"),
                                    Fee = issues.GetDouble("fee"),
                                    Created_at = issues.GetDateTime("created_at"),
                                    Updated_at = issues.IsDBNull("updated_at") ? (DateTime?)null : issues.GetDateTime("updated_at"),
                                    Deleted_at = issues.IsDBNull("deleted_at") ? (DateTime?)null : issues.GetDateTime("deleted_at"),
                                    Bill_id = issues.IsDBNull("bill_id") ? (int?)null : issues.GetInt32("bill_id"),
                                    Vehicle_type_id = issues.IsDBNull("vehicle_type_id") ? (int?)null : issues.GetInt32("vehicle_type_id"),
                                    Parking_lot_id = issues.IsDBNull("parking_lot_id") ? null : issues.GetString("parking_lot_id"),
                                    Slot_id = issues.IsDBNull("slot_id") ? null : issues.GetString("slot_id")
                                };
                                result.Add(issue);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return result;
        }
    }
}
