using WinFormsApp.Models;
using WinFormsApp.Views;
using WinFormsApp.Presenter;
using WinFormsApp.Repository;
using StaffDatabase_SQLite;
using System.Configuration;

namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string sqlConnectionString = "Data Source=TOASTER2\\FINANCIALDB;Initial Catalog=StaffContacts;Integrated Security=True;TrustServerCertificate=True";
            IStaffView view = new Form1();
            IStaffRepository repository = new StaffRepository(sqlConnectionString);
            new StaffPresenter(repository,view);
            Application.Run((Form)view);
        }
    }
}