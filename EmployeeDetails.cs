using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSimply
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public string type, name;

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHome A = new AdminHome();
            A.name = this.name;
            A.type = this.type;
            A.Show();
            this.Hide();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT [Hotel_Management].[dbo].[Employee].*,[Hotel_Management].[dbo].[UserLogin].type FROM [Hotel_Management].[dbo].[Employee], [Hotel_Management].[dbo].[UserLogin] where [Hotel_Management].[dbo].[UserLogin].userID =  [Hotel_Management].[dbo].[Employee].userID");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT [Hotel_Management].[dbo].[Employee].*,[Hotel_Management].[dbo].[UserLogin].type FROM [Hotel_Management].[dbo].[Employee],[Hotel_Management].[dbo].[UserLogin] where [Hotel_Management].[dbo].[UserLogin].userID =  [Hotel_Management].[dbo].[Employee].userID";

            if (!string.IsNullOrEmpty(searchtxt.Text))
            {
                query += " and Employee.Name like '%" + searchtxt.Text + "%'";
            }
            DataTable dt = DataAccess.LoadData(query);

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void dlbtn_Click(object sender, EventArgs e)
        {
            if (txtUid.Text == "")
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }

            int row = DataAccess.ExecuteQuery("delete from [Hotel_Management].[dbo].[UserLogin] where [Hotel_Management].[dbo].[UserLogin].userID='" + txtUid.Text + "'");
            if (row > 0)
            {
                MessageBox.Show("Deleted");

                AdminHome A = new AdminHome();
                A.name = this.name;
                A.type = this.type;
                A.Show();
                this.Hide();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            txtUid.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            AddEmployee A = new AddEmployee();
            A.name = this.name;
            A.type = this.type;
            A.Show();
            this.Hide();
        }
    }
}
