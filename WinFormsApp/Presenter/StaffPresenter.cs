using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Models;
using WinFormsApp.Views;

namespace WinFormsApp.Presenter
{
    public class StaffPresenter
    {
        private IStaffRepository _staffRepository;
        private IStaffView _staffView;
        private BindingSource _bindingSource;
        private IEnumerable<StaffModel> staffList;

        public StaffPresenter(IStaffRepository staffRepository, IStaffView staffView)
        {
            this._staffRepository = staffRepository;
            this._staffView = staffView;
            this._bindingSource = new BindingSource();
            this.staffList = staffList;
            //Event handler set
            this._staffView.AddNewEvent += AddStaff;
            this._staffView.SearchEvent += SearchStaff;
            this._staffView.DeleteEvent += DeleteStaff;
            this._staffView.SaveEvent += SaveStaff;
            this._staffView.CancelEvent += CancelAction;
            this._staffView.EditEvent += EditStaff;
            //Set Binding Source
            this._staffView.SetStaffListPendingSource(_bindingSource);
            LoadAllStaff();
            this._staffView.Show();
        }

        // Methdos
        private void LoadAllStaff()
        {
            staffList = _staffRepository.GetAll();
            _bindingSource.DataSource = staffList; // set staff data
        }

        private void DeleteStaff(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveStaff(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditStaff(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddStaff(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchStaff(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this._staffView.SearchValue);
            if(emptyValue == false)
            {
                staffList = _staffRepository.GetByID("");
            }
            else
            {
                staffList = _staffRepository.GetAll();
            }
            _bindingSource.DataSource = staffList;
        }
    }
}
