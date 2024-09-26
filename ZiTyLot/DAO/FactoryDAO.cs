using System;
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
            // Initialize a list to hold the results
            var list = new List<T>();

            try
            {
                // Establish a connection to the database
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open(); // Open the connection

                    // Start building the SQL query
                    var query = new StringBuilder($"SELECT * FROM {tableName} WHERE 1=1");

                    // Append filter conditions to the query if any filters are provided
                    if (filters != null)
                    {
                        foreach (var filter in filters)
                        {
                            query.Append(GetFilterConditionSql(filter));
                        }
                    }

                    // Create a MySqlCommand with the constructed query
                    using (var command = new MySqlCommand(query.ToString(), connection))
                    {
                        // Add parameters for the filter conditions to the command
                        if (filters != null)
                        {
                            foreach (var filter in filters)
                            {
                                AddFilterConditionParameters(command, filter);
                            }
                        }

                        // Execute the query and read the results
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create a new instance of T for each record
                                var item = new T();

                                // Set the properties of the instance based on the data from the reader
                                foreach (var prop in typeof(T).GetProperties())
                                {
                                    if (ShouldSkipProperty(prop)) continue;

                                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        SetPropertyValue(item, prop, reader[prop.Name]);
                                    }
                                }
                                // Add the populated instance to the list
                                list.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Throw a new exception with a custom message if an error occurs
                throw new Exception(ex.Message);
            }

            // Return the list of results
            return list;
        }

        public Page<T> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            int totalElements; // Variable to store the total number of elements

            try
            {
                // Establish a connection to the database
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open(); // Open the connection

                    // Get the total number of elements that match the filters
                    totalElements = GetTotalElements(connection, filters);

                    // Start building the SQL query for fetching data
                    var dataQuery = new StringBuilder($"SELECT * FROM {tableName} WHERE 1=1");

                    // Append filter conditions to the query if any filters are provided
                    if (filters != null)
                    {
                        foreach (var filter in filters)
                        {
                            dataQuery.Append(GetFilterConditionSql(filter));
                        }
                    }

                    // Append sorting information to the query if provided
                    if (!string.IsNullOrEmpty(pageable.SortBy))
                    {
                        dataQuery.Append($" ORDER BY {pageable.SortBy} {pageable.SortOrder}");
                    }

                    // Append pagination information to the query
                    dataQuery.Append($" LIMIT @PageSize OFFSET @Offset");

                    // Create a MySqlCommand with the constructed query
                    using (var command = new MySqlCommand(dataQuery.ToString(), connection))
                    {
                        // Add parameters for the filter conditions to the command
                        if (filters != null)
                        {
                            foreach (var filter in filters)
                            {
                                AddFilterConditionParameters(command, filter);
                            }
                        }

                        // Add pagination parameters to the command
                        command.Parameters.AddWithValue("@Offset", pageable.Offset());
                        command.Parameters.AddWithValue("@PageSize", pageable.PageSize);

                        var list = new List<T>(); // Initialize a list to hold the results

                        // Execute the query and read the results
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create a new instance of T for each record
                                var item = new T();

                                // Set the properties of the instance based on the data from the reader
                                foreach (var prop in typeof(T).GetProperties())
                                {
                                    if (ShouldSkipProperty(prop)) continue;

                                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        SetPropertyValue(item, prop, reader[prop.Name]);
                                    }
                                }
                                // Add the populated instance to the list
                                list.Add(item);
                            }
                        }

                        // Return a new Page object containing the results, total elements, and pagination information
                        return new Page<T>(list, totalElements, pageable);
                    }
                }
            }
            catch (Exception ex)
            {
                // Throw a new exception with a custom message if an error occurs
                throw new Exception(ex.Message);
            }
        }


        public T GetById(int id)
        {
            try
            {
                // Establish a connection to the database
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open(); // Open the connection

                    // Define the SQL query to fetch the record by ID
                    var query = $"SELECT * FROM {tableName} WHERE Id = @Id";

                    // Create a MySqlCommand with the query
                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Add the ID parameter to the command
                        command.Parameters.AddWithValue("@Id", id);

                        // Execute the query and read the results
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // If a record is found
                            {
                                var item = new T(); // Create a new instance of T

                                // Set the properties of the instance based on the data from the reader
                                foreach (var prop in typeof(T).GetProperties())
                                {
                                    if (ShouldSkipProperty(prop)) continue; // Skip properties that should be ignored

                                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name))) // Check if the column value is not null
                                    {
                                        SetPropertyValue(item, prop, reader[prop.Name]); // Set the property value
                                    }
                                }
                                return item; // Return the populated instance
                            }
                        }
                    }
                }
                return default; // Return the default value if no record is found
            }
            catch (Exception ex)
            {
                // Throw a new exception with a custom message if an error occurs
                throw new Exception(ex.Message);
            }
        }


        public void Add(T item)
        {
            try
            {
                // Establish a connection to the database
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open(); // Open the connection

                    // Start building the SQL query for inserting data
                    var query = new StringBuilder($"INSERT INTO {tableName} (");

                    // Get the properties of the type T
                    var properties = typeof(T).GetProperties();
                    var validProperties = new List<string>(); // List to hold valid property names

                    // Append property names to the query
                    foreach (var prop in properties)
                    {
                        if (ShouldSkipProperty(prop)) continue; // Skip properties that should be ignored

                        query.Append($"{prop.Name},");
                        validProperties.Add(prop.Name); // Add valid property names to the list
                    }
                    query.Length--; // Remove the last comma
                    query.Append(") VALUES (");

                    // Append parameter placeholders to the query
                    foreach (var propName in validProperties)
                    {
                        query.Append($"@{propName},");
                    }
                    query.Length--; // Remove the last comma
                    query.Append(")");

                    // Create a MySqlCommand with the constructed query
                    using (var command = new MySqlCommand(query.ToString(), connection))
                    {
                        // Add parameters for each property to the command
                        foreach (var prop in properties)
                        {
                            if (ShouldSkipProperty(prop)) continue; // Skip properties that should be ignored

                            var value = prop.GetValue(item) ?? DBNull.Value; // Get the property value or set to DBNull if null

                            if (prop.PropertyType.IsEnum && value != DBNull.Value)
                            {
                                value = value.ToString(); // Convert enum to string
                            }

                            command.Parameters.AddWithValue($"@{prop.Name}", value); // Add the parameter to the command
                        }

                        command.ExecuteNonQuery(); // Execute the query
                    }
                }
            }
            catch (Exception ex)
            {
                // Throw a new exception with a custom message if an error occurs
                throw new Exception(ex.Message);
            }
        }

        public void Update(T item)
        {
            try
            {
                // Establish a connection to the database
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open(); // Open the connection

                    // Start building the SQL query for updating data
                    var query = new StringBuilder($"UPDATE {tableName} SET ");

                    // Get the properties of the type T
                    var properties = typeof(T).GetProperties();

                    // Append property names and their parameter placeholders to the query
                    foreach (var prop in properties)
                    {
                        if (prop.Name != "Id" && !ShouldSkipProperty(prop)) // Skip the Id property and properties that should be ignored
                        {
                            query.Append($"{prop.Name} = @{prop.Name},");
                        }
                    }
                    query.Length--; // Remove the last comma
                    query.Append(" WHERE Id = @Id"); // Append the WHERE clause to update the record by Id

                    // Create a MySqlCommand with the constructed query
                    using (var command = new MySqlCommand(query.ToString(), connection))
                    {
                        // Add parameters for each property to the command
                        foreach (var prop in properties)
                        {
                            if (prop.Name != "Id" && !ShouldSkipProperty(prop)) // Skip the Id property and properties that should be ignored
                            {
                                var value = prop.GetValue(item) ?? DBNull.Value; // Get the property value or set to DBNull if null

                                if (prop.PropertyType.IsEnum && value != DBNull.Value)
                                {
                                    value = value.ToString(); // Convert enum to string
                                }

                                command.Parameters.AddWithValue($"@{prop.Name}", value); // Add the parameter to the command
                            }
                        }

                        // Add the Id parameter to the command
                        var idProperty = typeof(T).GetProperty("Id");
                        if (idProperty != null)
                        {
                            command.Parameters.AddWithValue("@Id", idProperty.GetValue(item));
                        }
                        else
                        {
                            throw new Exception("The entity does not have an Id property."); // Throw an exception if the Id property is not found
                        }

                        command.ExecuteNonQuery(); // Execute the query
                    }
                }
            }
            catch (Exception ex)
            {
                // Throw a new exception with a custom message if an error occurs
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                // Establish a connection to the database
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open(); // Open the connection

                    // Define the SQL query to delete the record by ID
                    var query = $"DELETE FROM {tableName} WHERE Id = @Id";

                    // Create a MySqlCommand with the query
                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Add the ID parameter to the command
                        command.Parameters.AddWithValue("@Id", id);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string GetFilterConditionSql(FilterCondition filter)
        {
            // Generate the SQL condition based on the filter's operator
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
                    return $" AND {filter.Column} IN ({filter.Value})";
                default:
                    throw new NotSupportedException($"Operator {filter.Operator} is not supported.");
            }
        }

        private void AddFilterConditionParameters(MySqlCommand command, FilterCondition filter)
        {
            // Add the filter condition parameter to the command
            var parameterValue = filter.Operator == ComparisonOperator.Like ? $"%{filter.Value}%" : filter.Value;
            command.Parameters.AddWithValue($"@{filter.Column}", parameterValue);
        }

        private bool ShouldSkipProperty(System.Reflection.PropertyInfo prop)
        {
            // Determine if the property should be skipped based on its type
            return (typeof(System.Collections.IEnumerable).IsAssignableFrom(prop.PropertyType) && prop.PropertyType != typeof(string)) ||
                   prop.PropertyType.Namespace == "ZiTyLot.ENTITY";
        }

        private void SetPropertyValue(T item, System.Reflection.PropertyInfo prop, object value)
        {
            // Set the property value, converting enums if necessary
            if (prop.PropertyType.IsEnum)
            {
                prop.SetValue(item, Enum.Parse(prop.PropertyType, value.ToString()));
            }
            else
            {
                prop.SetValue(item, value);
            }
        }

        private int GetTotalElements(MySqlConnection connection, List<FilterCondition> filters)
        {
            // Start building the SQL query to count the total elements
            var countQuery = new StringBuilder($"SELECT COUNT(*) FROM {tableName} WHERE 1=1");

            // Append filter conditions to the query if any filters are provided
            if (filters != null)
            {
                foreach (var filter in filters)
                {
                    countQuery.Append(GetFilterConditionSql(filter));
                }
            }

            // Create a MySqlCommand with the constructed query
            using (var countCommand = new MySqlCommand(countQuery.ToString(), connection))
            {
                // Add parameters for the filter conditions to the command
                if (filters != null)
                {
                    foreach (var filter in filters)
                    {
                        AddFilterConditionParameters(countCommand, filter);
                    }
                }

                // Execute the query and return the total count
                return Convert.ToInt32(countCommand.ExecuteScalar());
            }
        }
    }
}
