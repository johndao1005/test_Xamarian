using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class StaffModel
    {
        private int _staffID;
        private int? _managerID;
        private int _staffType;
        private int _title;
        private int _status;
        private string _firstName;
        private string _lastName;
        private string _middleInitial;
        private string _homePhone;
        private string _cellPhone;
        private string _officeExtension;
        private string _irdNumber;

        // Need to add Required and length check
        public int StaffID
        {
            get { return _staffID; }
            set { _staffID = value; }
        }
        public int? ManagerID
        {
            get { return _managerID; }
            set { _managerID = value; }
        }
        public int StaffType
        {
            get { return _staffType; }
            set { _staffType = value; }
        }
        public int Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string MiddleInitial
        {
            get { return _middleInitial; }
            set { _middleInitial = value; }
        }
        public string HomePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }
        public string CellPhone
        {
            get { return _cellPhone; }
            set { _cellPhone = value; }
        }
        public string OfficeExtension
        {
            get { return _officeExtension; }
            set { _officeExtension = value; }
        }
        public string IRDNumber
        {
            get { return _irdNumber; }

            set { _irdNumber = value; }
        }
       }
}
