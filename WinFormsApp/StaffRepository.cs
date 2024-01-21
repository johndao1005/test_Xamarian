using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WinFormsApp.Models;

namespace WinFormsApp
{
    public class StaffRepository : BaseRepository, IStaffRepository
    {
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
            throw new NotImplementedException();
        }

        public IEnumerable<StaffModel> GetByID(int staffID)
        {
            throw new NotImplementedException();
        }

        public void Update(StaffModel staff)
        {
            throw new NotImplementedException();
        }
    }
}
