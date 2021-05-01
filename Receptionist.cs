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
            CheckOut c = new CheckOut();
            c.Show();
            this.Hide();
        }

        private void customer_Details1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            CustomerRegistration cr= new CustomerRegistration();
            cr.Show();
            this.Hide();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            CustomerLists list = new CustomerLists();
            list.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            RoomDetails rd = new RoomDetails("Receptionist");
            rd.Show();
            this.Hide();
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
