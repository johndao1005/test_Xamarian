using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public interface IStaffRepository
    {
        void Add(StaffModel staff);
        void Update(StaffModel staff);
        void Delete(StaffModel staff);
        IEnumerable<StaffModel> GetAll();
        IEnumerable<StaffModel> GetByID(string staffID);

    }
}
