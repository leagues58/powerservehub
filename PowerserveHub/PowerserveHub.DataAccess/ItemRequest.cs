using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PowerserveHub.DataAccess
{
    public class ItemRequest
    {
        public ItemRequest(string name)
        {
            Name = name;
        }

        public int Id { get; private set; }

        public string Name { get; set; }

        public DateTime Created { get; private set; } = DateTime.UtcNow;

        public DateTime? Updated { get; private set; }

        public DateTime? Deleted { get; private set; }

        public static ItemRequest GetById(int id)
        {
            using (var connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                var parameters = new { id };

                return connection.QueryFirstOrDefault<ItemRequest>("ItemRequest_GetById", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Save()
        {
            if (Id == 0)
            {
                Insert();
            }
            else
            {
                Update();
            }
        }

        private void Insert()
        {
            using (var connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                var parameters = new { Name, Created };
                Id = connection.ExecuteScalar<int>("ItemRequest_Insert", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        private void Update()
        {
            Updated = DateTime.UtcNow;

            using (var connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                var parameters = new { Id, Name, Updated };
                Id = connection.ExecuteScalar<int>("ItemRequest_Update", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete()
        {
            Deleted = DateTime.UtcNow;

            using (var connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                var parameters = new { Id, Deleted };
                Id = connection.ExecuteScalar<int>("ItemRequest_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}