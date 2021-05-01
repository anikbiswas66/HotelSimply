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
    public partial class CustomerLists : Form
    {
        public CustomerLists()
        {
            InitializeComponent();
        }

        private void CustomerLists_Load(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT [Hotel_Management].[dbo].[CustomerReg].* FROM [Hotel_Management].[dbo].[CustomerReg]");



            dataview.DataSource = dt;
            dataview.Refresh();
            dataview.ClearSelection();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminHome home = new AdminHome();
            home.Show();
            this.Hide();
        }
    }
}
