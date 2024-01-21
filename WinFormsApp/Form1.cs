using WinFormsApp.Views;

namespace WinFormsApp
{
    public partial class Form1 : Form , IStaffView
    {
        private string message;
        private bool _isSuccess;
        private bool _isEdit;

        public Form1()
        {
            InitializeComponent();
        }

        //Properties Match it with the text input of the field
        public int StaffID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ManagerID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int StaffType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MiddleInitial { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HomePhone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CellPhone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OfficeExtension { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IRDNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        public string SearchValue
        {
            get { return SearchInput.Text; }
            set { SearchInput.Text = value; }
        }

        public bool IsEdit
        {
            get { return _isEdit; }
            set { _isEdit = value; }
        }
        
        public bool IsSuccess
        {
            get { return _isSuccess; }
            set { _isSuccess = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        //Event Handler
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetStaffListPendingSource(BindingSource perList)
        {
            dataGridView1.DataSource = perList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
