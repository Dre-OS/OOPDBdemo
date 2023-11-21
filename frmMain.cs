using System.Data;

namespace OOPDBdemo
{
    public partial class frmMain : Form
    {
        DBConnect connect = new DBConnect();
        public frmMain()
        {
            InitializeComponent();
        }
        

        private void frmMain_Load(object sender, EventArgs e)
        {
            connect.OpenDB();
            string sql = "SELECT * FROM tblstudent";
            DataTable dt= new DataTable();
            dt = connect.ReadStudentRecord(sql);
            dgvDB.DataSource = dt;
        }


    }
}