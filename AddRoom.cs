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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public string type, name;
        public string isbooked="No";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoomNo.Text != "" && cmbRoomType.SelectedItem.ToString() != "" && cmbBed.SelectedItem.ToString() != "" && txtPrice.Text != "")
                {

                    string query;
                    query = "insert into [Hotel_Management].[dbo].[Room](roomNo,type,bed,price,booked) values('" + txtRoomNo.Text + "','" + cmbRoomType.SelectedItem + "','" + cmbBed.SelectedItem + "','" + txtPrice.Text + "','"+isbooked+"')";


                    int row = DataAccess.ExecuteQuery(query);


                    if (row > 0)
                    {
                        MessageBox.Show("Operation Completed");

                        RoomDetails rd = new RoomDetails("Admin");
                        rd.name = this.name;
                        rd.type = this.type;
                        rd.Show();
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

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHome A = new AdminHome();
            A.name = this.name;
            A.type = this.type;
            A.Show();
            this.Hide();
        }
    }
}
