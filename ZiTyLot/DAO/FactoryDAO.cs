﻿using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using ZiTyLot.Config;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    public class FactoryDAO<T> where T : new()
    {
        private readonly string tableName;

        public FactoryDAO(string tableName)
        {
            this.tableName = tableName;
        }

        public List<T> GetAll(List<FilterCondition> filters = null)
        {
            var list = new List<T>();

            try
            {
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open();
                    var query = new StringBuilder($"SELECT * FROM {tableName} WHERE 1=1");

                    if (filters != null)
                    {
                        foreach (var filter in filters)
                        {
                            query.Append(GetFilterConditionSql(filter));
                        }
                    }

                    using (var command = new MySqlCommand(query.ToString(), connection))
                    {
                        if (filters != null)
                        {
                            foreach (var filter in filters)
                            {
                                AddFilterConditionParameters(command, filter);
                            }
                        }

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var item = new T();
                                foreach (var prop in typeof(T).GetProperties())
                                {
                                    // Skip properties that are collections or entity classes
                                    if ((typeof(System.Collections.IEnumerable).IsAssignableFrom(prop.PropertyType) && prop.PropertyType != typeof(string)) ||
                                        prop.PropertyType.Namespace == "ZiTyLot.ENTITY")
                                    {
                                        continue;
                                    }
                                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        if (prop.PropertyType.IsEnum)
                                        {
                                            prop.SetValue(item, Enum.Parse(prop.PropertyType, reader[prop.Name].ToString()));
                                        }
                                        else
                                        {
                                            prop.SetValue(item, reader[prop.Name]);
                                        }
                                    }
                                }
                                list.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("An error occurred while fetching all records.", ex);
            }

            return list;
        }

        public Page<T> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            int totalElements;

            try
            {
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open();

                    // Query to get total elements
                    var countQuery = new StringBuilder($"SELECT COUNT(*) FROM {tableName} WHERE 1=1");
                    if (filters != null)
                    {
                        foreach (var filter in filters)
                        {
                            countQuery.Append(GetFilterConditionSql(filter));
                        }
                    }

                    using (var countCommand = new MySqlCommand(countQuery.ToString(), connection))
                    {
                        if (filters != null)
                        {
                            foreach (var filter in filters)
                            {
                                AddFilterConditionParameters(countCommand, filter);
                            }
                        }

                        totalElements = Convert.ToInt32(countCommand.ExecuteScalar());
                    }

                    // Query to get paginated data
                    var dataQuery = new StringBuilder($"SELECT * FROM {tableName} WHERE 1=1");

                    if (filters != null)
                    {
                        foreach (var filter in filters)
                        {
                            dataQuery.Append(GetFilterConditionSql(filter));
                        }
                    }

                    if (!string.IsNullOrEmpty(pageable.SortBy))
                    {
                        dataQuery.Append($" ORDER BY {pageable.SortBy} {pageable.SortOrder}");
                    }

                    dataQuery.Append($" LIMIT @PageSize OFFSET @Offset");

                    using (var command = new MySqlCommand(dataQuery.ToString(), connection))
                    {
                        if (filters != null)
                        {
                            foreach (var filter in filters)
                            {
                                AddFilterConditionParameters(command, filter);
                            }
                        }

                        command.Parameters.AddWithValue("@Offset", pageable.Offset());
                        command.Parameters.AddWithValue("@PageSize", pageable.PageSize);

                        var list = new List<T>();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var item = new T();
                                foreach (var prop in typeof(T).GetProperties())
                                {
                                    // Skip properties that are collections or entity classes
                                    if ((typeof(System.Collections.IEnumerable).IsAssignableFrom(prop.PropertyType) && prop.PropertyType != typeof(string)) ||
                                        prop.PropertyType.Namespace == "ZiTyLot.ENTITY")
                                    {
                                        continue;
                                    }

                                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        if (prop.PropertyType.IsEnum)
                                        {
                                            prop.SetValue(item, Enum.Parse(prop.PropertyType, reader[prop.Name].ToString()));
                                        }
                                        else
                                        {
                                            prop.SetValue(item, reader[prop.Name]);
                                        }
                                    }
                                }
                                list.Add(item);
                            }
                        }

                        return new Page<T>(list, totalElements, pageable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("An error occurred while fetching paginated data.", ex);
            }
        }

        private string GetFilterConditionSql(FilterCondition filter)
        {
            switch (filter.Operator)
            {
                case ComparisonOperator.Equals:
                    return $" AND {filter.Column} = @{filter.Column}";
                case ComparisonOperator.GreaterThan:
                    return $" AND {filter.Column} > @{filter.Column}";
                case ComparisonOperator.LessThan:
                    return $" AND {filter.Column} < @{filter.Column}";
                case ComparisonOperator.LessThanOrEqual:
                    return $" AND {filter.Column} <= @{filter.Column}";
                case ComparisonOperator.GreaterThanOrEqual:
                    return $" AND {filter.Column} >= @{filter.Column}";
                case ComparisonOperator.Like:
                    return $" AND {filter.Column} LIKE @{filter.Column}";
                case ComparisonOperator.In:
                    return $" AND {filter.Column} IN ({filter.Value})"; // Value should be a comma-separated list of values for IN operator
                default:
                    throw new NotSupportedException($"Operator {filter.Operator} is not supported.");
            }
        }

        private void AddFilterConditionParameters(MySqlCommand command, FilterCondition filter)
        {
            switch (filter.Operator)
            {
                case ComparisonOperator.Like:
                    command.Parameters.AddWithValue($"@{filter.Column}", $"%{filter.Value}%");
                    break;
                default:
                    command.Parameters.AddWithValue($"@{filter.Column}", filter.Value);
                    break;
            }
        }
        public T GetById(int id)
        {
            try
            {
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open();
                    var query = $"SELECT * FROM {tableName} WHERE Id = @Id";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var item = new T();
                                foreach (var prop in typeof(T).GetProperties())
                                {
                                    // Skip properties that are collections or entity classes
                                    if ((typeof(System.Collections.IEnumerable).IsAssignableFrom(prop.PropertyType) && prop.PropertyType != typeof(string)) ||
                                        prop.PropertyType.Namespace == "ZiTyLot.ENTITY")
                                    {
                                        continue;
                                    }
                                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        if (prop.PropertyType.IsEnum)
                                        {
                                            prop.SetValue(item, Enum.Parse(prop.PropertyType, reader[prop.Name].ToString()));
                                        }
                                        else
                                        {
                                            prop.SetValue(item, reader[prop.Name]);
                                        }
                                    }
                                }
                                return item;
                            }
                        }
                    }
                }
                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("An error occurred while fetching the record by ID.", ex);
            }
        }

        public void Add(T item)
        {
            try
            {
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open();
                    var query = new StringBuilder($"INSERT INTO {tableName} (");

                    var properties = typeof(T).GetProperties();
                    var validProperties = new List<string>();

                    foreach (var prop in properties)
                    {
                        if ((typeof(System.Collections.IEnumerable).IsAssignableFrom(prop.PropertyType) && prop.PropertyType != typeof(string)) ||
                                    prop.PropertyType.Namespace == "ZiTyLot.ENTITY")
                        {
                            continue;
                        }
                        query.Append($"{prop.Name},");
                        validProperties.Add(prop.Name);
                    }
                    query.Length--; // Remove the last comma
                    query.Append(") VALUES (");

                    foreach (var propName in validProperties)
                    {
                        query.Append($"@{propName},");
                    }
                    query.Length--; // Remove the last comma
                    query.Append(")");

                    using (var command = new MySqlCommand(query.ToString(), connection))
                    {
                        foreach (var prop in properties)
                        {
                            if ((typeof(System.Collections.IEnumerable).IsAssignableFrom(prop.PropertyType) && prop.PropertyType != typeof(string)) ||
                                        prop.PropertyType.Namespace == "ZiTyLot.ENTITY")
                            {
                                continue;
                            }

                            var value = prop.GetValue(item) ?? DBNull.Value;

                            if (prop.PropertyType.IsEnum && value != DBNull.Value)
                            {
                                value = value.ToString(); // Convert enum to string
                            }

                            // Log the property name and value
                            Console.WriteLine($"Property: {prop.Name}, Value: {value}");

                            command.Parameters.AddWithValue($"@{prop.Name}", value);
                        }

                        // Log the final SQL command
                        Console.WriteLine($"SQL Command: {command.CommandText}");
                        foreach (MySqlParameter param in command.Parameters)
                        {
                            Console.WriteLine($"Parameter: {param.ParameterName}, Value: {param.Value}");
                        }

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("An error occurred while adding the record.", ex);
            }
        }




        public void Update(T item)
        {
            try
            {
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open();
                    var query = new StringBuilder($"UPDATE {tableName} SET ");

                    var properties = typeof(T).GetProperties();
                    foreach (var prop in properties)
                    {
                        if (prop.Name != "Id")
                        {
                            if ((typeof(System.Collections.IEnumerable).IsAssignableFrom(prop.PropertyType) && prop.PropertyType != typeof(string)) ||
                                        prop.PropertyType.Namespace == "ZiTyLot.ENTITY")
                            {
                                continue;
                            }
                            query.Append($"{prop.Name} = @{prop.Name},");
                        }
                    }
                    query.Length--; // Remove the last comma
                    query.Append(" WHERE Id = @Id");

                    using (var command = new MySqlCommand(query.ToString(), connection))
                    {
                        foreach (var prop in properties)
                        {
                            if (prop.Name != "Id")
                            {
                                if ((typeof(System.Collections.IEnumerable).IsAssignableFrom(prop.PropertyType) && prop.PropertyType != typeof(string)) ||
                                            prop.PropertyType.Namespace == "ZiTyLot.ENTITY")
                                {
                                    continue;
                                }

                                var value = prop.GetValue(item) ?? DBNull.Value;

                                if (prop.PropertyType.IsEnum && value != DBNull.Value)
                                {
                                    value = value.ToString(); // Convert enum to string
                                }

                                command.Parameters.AddWithValue($"@{prop.Name}", value);
                            }
                        }

                        // Ensure the Id parameter is added only once
                        var idProperty = typeof(T).GetProperty("Id");
                        if (idProperty != null)
                        {
                            command.Parameters.AddWithValue("@Id", idProperty.GetValue(item));
                        }
                        else
                        {
                            throw new Exception("The entity does not have an Id property.");
                        }
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("An error occurred while updating the record.", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open();
                    var query = $"DELETE FROM {tableName} WHERE Id = @Id";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("An error occurred while deleting the record.", ex);
            }
        }
    }
}
