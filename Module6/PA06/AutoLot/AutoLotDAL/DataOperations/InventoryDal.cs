/*
 * Name: Aidan Linerud
 * Date: 11/1/2023
 * Assignment: PA06-3
 */

namespace AutoLotDAL.DataOperations
{
    public class InventoryDal : IDisposable
    {
        private readonly string? _connectionString;
        private SqlConnection? _sqlConnection = null;

        public InventoryDal()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var providerName = config["ProviderName"];
            _connectionString = config[providerName + ":ConnectionString"];
        }

        private void OpenConnection()
        {
            _sqlConnection = new SqlConnection()
            {
                ConnectionString = _connectionString
            };
            _sqlConnection.Open();
        }

        private void CloseConnection()
        {
            if (_sqlConnection?.State != ConnectionState.Closed)
            {
                _sqlConnection?.Close();
            }
        }

        #region IDisposable implements

        bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing) _sqlConnection?.Dispose();
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region SQL Methods

        // All of these methods share the same format:
        // 1 - open the connection
        // 2 - create a command with a sql query
        // 3 - read/write
        // 4 - close connection
        // 5 - return value read (or nothing if written)

        public List<CarViewModel> GetAllInventory()
        {
            OpenConnection();
            var inventory = new List<CarViewModel>();

            var sql = @"SELECT i.Id, i.Color, i.PetName, m.Name as Make
                FROM Inventory i
                INNER JOIN Makes m on m.Id = i.MakeId";

            using var command = new SqlCommand(sql, _sqlConnection)
            {
                CommandType = CommandType.Text
            };

            command.CommandType = CommandType.Text;

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                inventory.Add(new CarViewModel
                {
                    Id = (int)reader["Id"],
                    Color = (string)reader["Color"],
                    Make = (string)reader["Make"],
                    PetName = (string)reader["PetName"]
                });
            }

            reader.Close();
            return inventory;
        }

        public CarViewModel? GetCar(int id)
        {
            OpenConnection();

            CarViewModel? car = null;

            var sql = @"SELECT i.Id, i.Color, i.PetName,m.Name as Make
                FROM Inventory i
                INNER JOIN Makes m on m.Id = i.MakeId
                WHERE i.Id = @CarId";

            using var command = new SqlCommand(sql, _sqlConnection)
            {
                CommandType = CommandType.Text
            };

            // Wrap method parameters to improve security
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@carId",
                Value = id,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            });

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                car = new CarViewModel
                {
                    Id = (int)reader["Id"],
                    Color = (string)reader["Color"],
                    Make = (string)reader["Make"],
                    PetName = (string)reader["PetName"]
                };
            }
            reader.Close();
            return car;
        }

        public void InsertAuto(string color, int makeId, string petName)
        {
            OpenConnection();

            var sql = @"Insert Into Inventory (MakeId, Color, PetName)
                Values(@makeId, @color, @petName)";

            using var command = new SqlCommand(sql, _sqlConnection);

            // Wrap method parameters to improve security
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@makeId",
                Value = makeId,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            });
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@color",
                Value = color,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
            });
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@petName",
                Value = petName,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
            });

            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void InsertAuto(Car car)
        {
            OpenConnection();

            var sql = @"Insert Into Inventory (MakeId, Color, PetName)
                Values (@makeId, @color, @petName)";

            using var command = new SqlCommand(sql, _sqlConnection);

            // Wrap method parameters to improve security
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@makeId",
                Value = car.MakeId,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            });
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@color",
                Value = car.Color,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
            });
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@petName",
                Value = car.PetName,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
            });

            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void DeleteCar(int id)
        {
            OpenConnection();

            var sql = "Delete from Inventory where Id = @carId";

            using var command = new SqlCommand(sql, _sqlConnection);

            // Wrap method parameters to improve security
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@carId",
                Value = id,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            });

            try
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Sorry! That car is on order!", ex);
            }

            CloseConnection();
        }

        public void UpdateCarPetName(int id, string newPetName)
        {
            OpenConnection();

            var sql = @"Update Inventory Set PetName = @petName
                Where Id = @carId";

            using var command = new SqlCommand(sql, _sqlConnection);

            // Wrap method parameters to improve security
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@carId",
                Value = id,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            });
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@petName",
                Value = newPetName,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
            });

            command.ExecuteNonQuery();

            CloseConnection();
        }

        #endregion

        #region SQL Stored Procs

        public string LookUpPetName(int carId)
        {
            OpenConnection();
            string carPetName;

            using var command = new SqlCommand("GetPetName", _sqlConnection);
            
            command.CommandType = CommandType.StoredProcedure;
            
            // Wrap method parameters to improve security
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@carId",
                SqlDbType = SqlDbType.Int,
                Value = carId,
                Direction = ParameterDirection.Input
            });
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@petName",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Output
            });
            
            command.ExecuteNonQuery();
            
            carPetName = (string)command.Parameters["@petName"].Value;
            CloseConnection();
            
            return carPetName;
        }

        #endregion
    }
}
