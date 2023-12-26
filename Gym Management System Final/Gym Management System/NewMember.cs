using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Gym_Management_System
{
    public partial class NewMember : System.Windows.Forms.Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }

       

        private void btnSavec(object sender, EventArgs e)
        {
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string gender = "";

            bool isChecked = radioMale.Checked;
            if (isChecked)
            {
                gender = radioMale.Text;
            }
            else
            {
                gender = radioFemale.Text;
            }

            string dateOfBirth = dateTimePicker1.Text;
            Int64 Mobile = Int64.Parse(txtMobile.Text);
            string email = txtEmail.Text;
            string joindate = dateTimePicker2.Text;
            string gymTime = comboGtime.Text;
            string address = txtAddress.Text;
            string membership = comboMtime.Text;

            if (string.IsNullOrWhiteSpace(txtFname.Text))
            {
                errorProvider1.SetError(txtFname, "Name connot be blank");
                return;
            }
            else
            {
                errorProvider1.Clear();

            }


            if (string.IsNullOrWhiteSpace(txtLname.Text))
            {
                errorProvider1.SetError(txtLname, "Name connot be blank");
                return;
            }
            else
            {
                errorProvider1.Clear();

            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email connot be blank");
                return;
            }
            else
            {
                errorProvider1.Clear();

            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Address connot be blank");
                return;
            }
            else
            {
                errorProvider1.Clear();

            }

            string ConnectionString = "Data Source = THARINDU\\SQLEXPRESS01; Initial Catalog = gym; Integrated Security = True";

            SqlConnection con = new SqlConnection(ConnectionString);
            
            con.Open();


            string Query = "Insert into newMember(Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,Maddress,MembershipTime) values ('" + fname + "','" + lname + "','" + gender + "','" + dateOfBirth + "','" + Mobile + "','" + email + "','" + joindate + "','" + gymTime + "', '" + address + "', '" + membership + "')";

            SqlCommand cmd = new SqlCommand(Query,con);

            cmd.ExecuteNonQuery();

            con.Close();



            //SqlCommand cmd = new SqlCommand(ConnectionString);
            //cmd.Connection = con;

            //cmd.CommandText = "Insert into newMember(MID,Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,Maddress,MembershipTime) values ('" + fname + "','" + lname + "','" + gender + "','" + dateOfBirth + "','" + Mobile + "','" + email + "','" + joindate + "','" + gymTime + "', '" + address + "', '" + membership + "')";

            //SqlDataAdapter DA = new SqlDataAdapter(cmd);
            // DataSet DS = new DataSet();
            //DA.Fill(DS);


            MessageBox.Show("Data saved.");



        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();

            radioMale.Checked = false;

            radioFemale.Checked = false;

            txtMobile.Clear();

            txtEmail.Clear();

            comboGtime.ResetText();

            comboMtime.ResetText();

            txtAddress.Clear();

            dateTimePicker1.Value = DateTime.Now;

        

        dateTimePicker2.Value = DateTime.Now;
        }
    }
}
