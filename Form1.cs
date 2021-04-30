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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public string type;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            DataTable table1 = DataAccess.LoadData("select * from [Hotel_Management].[dbo].[UserLogin] where userID = '" + loginusername.Text + "' AND password = '" + loginpassword.Text + "'");


            if (table1.Rows.Count != 1)
            {

                MessageBox.Show("wrong user Id or Password");

                loginusername.Clear();
                loginpassword.Clear();
                return;


            }


            type = table1.Rows[0]["type"].ToString();


            if (type == "Admin")
            {
                AdminHome A = new AdminHome();
                A.name = loginusername.Text;
                A.type = this.type;
                A.Show();
                this.Hide();

            }

            else if (type == "Receptionist")
            {
                Receptionist c = new Receptionist();
                c.name = loginusername.Text;
                c.type = this.type;
                c.Show();
                this.Hide();
            }
        }
    }
}
