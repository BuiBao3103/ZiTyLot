
namespace ZiTyLot.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Text;
    using MySql.Data.MySqlClient;
    using ZiTyLot.Config;
    public class DaoFactory<T> where T : new()
    {
        private readonly string _tableName;
        private readonly MySqlConnection _connection;

        public DaoFactory(string tableName)
        {
            _tableName = tableName;
            _connection = DBConfig.GetConnection();
        }

        public int GetTotalRecordCount(Dictionary<string, object> filters = null)
        {
            try
            {
                _connection.Open();
                var query = new StringBuilder($"SELECT COUNT(*) FROM {_tableName} WHERE 1=1");

                if (filters != null)
                {
                    foreach (var filter in filters)
                    {
                        query.Append($" AND {filter.Key} = @{filter.Key}");
                    }
                }

                using (var command = new MySqlCommand(query.ToString(), _connection))
                {
                    if (filters != null)
                    {
                        foreach (var filter in filters)
                        {
                            command.Parameters.AddWithValue($"@{filter.Key}", filter.Value);
                        }
                    }

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the total record count.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<T> GetPaginatedData(int pageNumber, int pageSize, string sortBy = null, string sortOrder = null, Dictionary<string, object> filters = null)
        {
            try
            {
                _connection.Open();
                var query = new StringBuilder($"SELECT * FROM {_tableName} WHERE 1=1");

                if (filters != null)
                {
                    foreach (var filter in filters)
                    {
                        query.Append($" AND {filter.Key} = @{filter.Key}");
                    }
                }

                if (!string.IsNullOrEmpty(sortBy) && !string.IsNullOrEmpty(sortOrder))
                {
                    query.Append($" ORDER BY {sortBy} {sortOrder}");
                }

                query.Append($" LIMIT @PageSize OFFSET @Offset");

                using (var command = new MySqlCommand(query.ToString(), _connection))
                {
                    if (filters != null)
                    {
                        foreach (var filter in filters)
                        {
                            command.Parameters.AddWithValue($"@{filter.Key}", filter.Value);
                        }
                    }

                    command.Parameters.AddWithValue("@Offset", (pageNumber - 1) * pageSize);
                    command.Parameters.AddWithValue("@PageSize", pageSize);

                    var list = new List<T>();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new T();
                            foreach (var prop in typeof(T).GetProperties())
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                {
                                    prop.SetValue(item, reader[prop.Name]);
                                }
                            }
                            list.Add(item);
                        }
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching paginated data.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        public T GetById(int id)
        {
            try
            {
                _connection.Open();
                var query = $"SELECT * FROM {_tableName} WHERE Id = @Id";

                using (var command = new MySqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var item = new T();
                            foreach (var prop in typeof(T).GetProperties())
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                {
                                    prop.SetValue(item, reader[prop.Name]);
                                }
                            }
                            return item;
                        }
                    }
                }
                return default;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the record by ID.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        public void Add(T item)
        {
            try
            {
                _connection.Open();
                var query = new StringBuilder($"INSERT INTO {_tableName} (");

                var properties = typeof(T).GetProperties();
                foreach (var prop in properties)
                {
                    query.Append($"{prop.Name},");
                }
                query.Length--; // Remove the last comma
                query.Append(") VALUES (");

                foreach (var prop in properties)
                {
                    query.Append($"@{prop.Name},");
                }
                query.Length--; // Remove the last comma
                query.Append(")");

                using (var command = new MySqlCommand(query.ToString(), _connection))
                {
                    foreach (var prop in properties)
                    {
                        command.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(item));
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the record.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        public void Update(T item)
        {
            try
            {
                _connection.Open();
                var query = new StringBuilder($"UPDATE {_tableName} SET ");

                var properties = typeof(T).GetProperties();
                foreach (var prop in properties)
                {
                    if (prop.Name != "Id")
                    {
                        query.Append($"{prop.Name} = @{prop.Name},");
                    }
                }
                query.Length--; // Remove the last comma
                query.Append(" WHERE Id = @Id");

                using (var command = new MySqlCommand(query.ToString(), _connection))
                {
                    foreach (var prop in properties)
                    {
                        command.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(item));
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the record.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        public void Delete(int id)
        {
            try
            {
                _connection.Open();
                var query = $"DELETE FROM {_tableName} WHERE Id = @Id";

                using (var command = new MySqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the record.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int CalculateTotalPages(int totalRecords, int pageSize)
        {
            return (int)Math.Ceiling((double)totalRecords / pageSize);
        }
    }

}
