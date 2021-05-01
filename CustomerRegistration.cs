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
    public partial class CustomerRegistration : Form
    {
       
        public CustomerRegistration()
        {
            InitializeComponent();
            setItem();
        }
 

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
            setItem();
        }
        public string isbooked = "No";
        public string checkout = "No";
        public string yesbooked = "Yes";
        public string RoomNumber;

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text !="" && mobileno.Text != "" && nationality.Text !="" && nidno.Text !=""&&address.Text!=""&&gender.SelectedItem.ToString()!=""&&dob.Value.ToString()!=""&&checkin.Value.ToString()!=""&&bed.SelectedItem.ToString()!=""&&roomType.SelectedItem.ToString()!=""&&room.SelectedItem.ToString()!=""&&price.Text!="")
                {
                    RoomNumber = room.SelectedItem.ToString();
                    string query;
                    query = "INSERT INTO [Hotel_Management].[dbo].[CustomerReg](Name,MobileNo,Nationality,NID,Address,Gender,DOB,CheckIn,Checkout,Bed,RoomType,Room,Price) VALUES('" + name.Text + "','"+mobileno.Text+"','"+nationality.Text+"','"+nidno.Text+"','"+address.Text+"','"+gender.SelectedItem.ToString()+"','"+dob.Value.ToString()+"','"+checkin.Value.ToString()+"','"+checkout+"','"+bed.SelectedItem.ToString()+"','"+roomType.SelectedItem.ToString()+ "','" + room.SelectedItem.ToString() + "','" + price.Text+"')";
                    Booked();
                    int row = DataAccess.ExecuteQuery(query);

                    if (row > 0)
                    {
                        MessageBox.Show("Registerd");

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

        
        public void setItem()
        {
            room.Items.Clear();
            string query;
            query="select roomNo from [Hotel_Management].[dbo].[Room] where booked='"+isbooked+"' ";
            DataTable dt = DataAccess.ExecuteQuery2(query);
            foreach (DataRow dr in dt.Rows)
            {
                room.Items.Add(dr["roomNo"].ToString());
            }
        }

        public void Booked()
        {
            string query;
            query ="UPDATE  [Hotel_Management].[dbo].[Room] SET booked='"+yesbooked+"'  where roomNo ='" +RoomNumber+"' ";

            int row = DataAccess.ExecuteQuery(query);

            
        }



        private void backBtn_Click(object sender, EventArgs e)
        {
            Receptionist R = new Receptionist();

            R.Show();
            this.Hide();
        }

        private void TextClear()
        {
            name.Clear();
            mobileno.Clear();
            nationality.Clear();
            nidno.Clear();
            address.Clear();
            gender.ResetText();
        }
    }
}
/*'"+bed.SelectedItem.ToString()+"','"+roomType.SelectedItem.ToString()+"','"+roomNo.SelectedItem.ToString()+"',*/