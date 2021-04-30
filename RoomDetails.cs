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
    public partial class RoomDetails : Form
    {
        public RoomDetails()
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

        private void RoomDetails_Load(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT [Hotel_Management].[dbo].[Room].* FROM [Hotel_Management].[dbo].[Room]");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }
    }
}
