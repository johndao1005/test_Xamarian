using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WinFormsApp.Models;

namespace WinFormsApp.Repository
{
    public class StaffRepository :  BaseRepository, IStaffRepository
    {
        //Constructor
        public StaffRepository(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        //Methods
        public void Add(StaffModel staff)
        {
            throw new NotImplementedException();
        }

        public void Delete(StaffModel staff)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StaffModel> GetAll()
        {
            var staffList =  new List<StaffModel>();
            using(var connection = new SqlConnection(ConnectionString))
            using(var command = connection.CreateCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from StaffContacts order by StaffID desc";
                using(var reader = command.ExecuteReader())
                {
                    /*while (reader.Read())
                    {
                        var _staffMode = new StaffModel
                        {
                            StaffID = (int)reader[0],
                            StaffType = (int)reader[1],
                            Title = (int)reader[2],
                            FirstName = reader[3].ToString(),
                            LastName = reader[4].ToString(),
                            MiddleInitial = reader[5].ToString(),
                            HomePhone = reader[6].ToString(),
                            CellPhone = reader[7].ToString(),
                            OfficeExtension = reader[8].ToString(),
                            IRDNumber = reader[9].ToString(),
                            Status = (int)reader[10],
                            ManagerID = (int)reader[11]
                        };
                        staffList.Add(_staffMode);
                    }*/
                }
            }
            return staffList;
        }

        public IEnumerable<StaffModel> GetByID(string staffID)
        {
            int searchID = int.TryParse(staffID, out _) ? Convert.ToInt32(staffID):0;
            var staffList = new List<StaffModel>();
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from StaffContacts where StaffID=@id order by StaffID desc";
                command.Parameters.Add("@id",SqlDbType.Int).Value = searchID;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var _staffMode = new StaffModel
                        {
                            StaffID = (int)reader[0],
                            StaffType = (int)reader[1],
                            Title = (int)reader[2],
                            FirstName = reader[3].ToString(),
                            LastName = reader[4].ToString(),
                            MiddleInitial = reader[5].ToString(),
                            HomePhone = reader[6].ToString(),
                            CellPhone = reader[7].ToString(),
                            OfficeExtension = reader[8].ToString(),
                            IRDNumber = reader[9].ToString(),
                            Status = (int)reader[10],
                            ManagerID = (int)reader[11]
                        };
                        staffList.Add(_staffMode);
                    }
                }
            }
            return staffList;
        }

        public void Update(StaffModel staff)
        {
            throw new NotImplementedException();
        }
    }
}
