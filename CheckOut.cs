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
    public partial class CheckOut : Form
    {
        public string isBooked="No";
        public CheckOut()
        {
            InitializeComponent();
        }

        private void chckoutBtn_Click(object sender, EventArgs e)
        {
            checkOut();
            
        }

        public void checkOut()
        {
            try
            {
                string query;
                query = "UPDATE  [Hotel_Management].[dbo].[CustomerReg] SET Checkout='" + date.Value.ToString() + "'  where Room ='" + room.Text + "' ";
                int row = DataAccess.ExecuteQuery(query);
                CheckoutRoom();
                MessageBox.Show("Check out Successfully!");
            }
            catch(Exception)
            {
                MessageBox.Show("Error!");
            }
            
        }

        public void CheckoutRoom()
        {
            try
            {
                string query;
                query = "UPDATE  [Hotel_Management].[dbo].[Room] SET booked='" + isBooked + "'  where roomNo ='" + room.Text + "' ";

                int row = DataAccess.ExecuteQuery(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            
           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Receptionist receptionist = new Receptionist();
            receptionist.Show();
            this.Hide();
        }
    }
}
