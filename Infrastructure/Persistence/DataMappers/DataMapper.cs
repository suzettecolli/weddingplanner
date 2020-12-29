using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Domain.Entities;

namespace Infrastructure.Persistence.DataMappers
{
     public abstract class DataMapper<TEntity> where TEntity:Entity
    {
        private string tableName;
        private string columns;

        // https://scottlilly.com/c-design-patterns-data-mapper-and-active-record/

        public DataMapper(string tableName, string columns)
        {
            this.tableName = tableName;
            this.columns = columns;
        }

        public abstract TEntity Map(SqlDataReader sqlDataReader);
        public abstract void AddParameters(TEntity entity,  SqlParameterCollection parameterCollection);

        public void Delete(TEntity entity)
        {
            string sql = $"DELETE FROM {tableName} WHERE ID = @ID;";
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@ID", entity.Id);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void Insert(TEntity entity)
        {
            string sql = $"INSERT INTO {tableName} VALUES ({columns})";
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = sql;
                    AddParameters(entity, command.Parameters);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

        }

        public IList<TEntity> GetAll()
        {
            List<TEntity> data = new List<TEntity>();
            string sql = $"SELECT * FROM {tableName};";
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(Map(reader));
                        }

                        // Call Close when done reading.
                        reader.Close();
                    }
                }
            }
            return data;
        }

        public TEntity Get(long ID)
        {
            TEntity selected=null;
            string sql = $"SELECT * FROM {tableName} WHERE ID = @ID;";
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            selected=Map(reader);
                        }
                        reader.Close();
                    }
                }
            }
            return selected;
        }

        public void Update(TEntity entity)
        {
            string sql = $"UPDATE {tableName} SET {columns} WHERE ID = @ID;";
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@ID", entity.Id);
                    AddParameters(entity, command.Parameters);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
