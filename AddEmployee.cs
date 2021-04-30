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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public string type, name;

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text != "" && txtmobile.Text != ""  && cmbgender.SelectedItem.ToString() != "" && txtmail.Text != "" && txtUid.Text != "" && txtpass.Text != "" && cmbtype.Text != "")
                {
                    
                        string query;
                        query = "insert into [Hotel_Management].[dbo].[Employee](name,mobile,gender,email,userID) values('" + txtname.Text + "','" + txtmobile.Text + "','" + cmbgender.SelectedItem + "','" + txtmail.Text + "','" + txtUid.Text + "')";


                        int row = DataAccess.ExecuteQuery(query);


                        //login access
                        string query1;
                        query1 = "insert into [Hotel_Management].[dbo].[UserLogin](userID,password,type) values('" + txtUid.Text + "','" + txtpass.Text + "','" + cmbtype.SelectedItem + "')";


                        int row1 = DataAccess.ExecuteQuery1(query1);

                        if ((row > 0) && (row1 > 0))
                        {
                            MessageBox.Show("Operation Completed");

                            EmployeeDetails A = new EmployeeDetails();
                            A.name = this.name;
                            A.Show();
                            this.Hide();
                        }
                  
                }
                else
                    MessageBox.Show("You left something blank");
            }
            catch (Exception)
            {

                MessageBox.Show("You left something blank");
            }
        }
    }
}
