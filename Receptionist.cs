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
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public string type, name;
        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void customer_Details1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            RoomDetails rd = new RoomDetails();
            rd.name = this.name;
            rd.type = this.type;
            rd.Show();
            this.Hide();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {

        }
    }
}
