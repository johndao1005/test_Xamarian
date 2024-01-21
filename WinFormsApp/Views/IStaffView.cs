using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Views
{
    public interface IStaffView
    {
         int StaffID {  get; set; }
         int ManagerID { get; set; }
        int StaffType { get; set; }
        int Title { get; set; }
        int Status { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleInitial { get; set; }
        string HomePhone { get; set; }
        string CellPhone { get; set; }
        string OfficeExtension { get; set; }
        string IRDNumber { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetStaffListPendingSource(BindingSource perList);
        void Show();
    }
}
