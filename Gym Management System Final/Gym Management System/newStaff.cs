using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class newStaff : System.Windows.Forms.Form
    {
        public newStaff()
        {
            InitializeComponent();
        }

        private void newStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
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
            string state = txtState.Text;
            string city = txtcity.Text;

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
                errorProvider1.SetError(txtEmail, "Name connot be blank");
                return;
            }
            else
            {
                errorProvider1.Clear();

            }

            if (string.IsNullOrWhiteSpace(txtState.Text))
            {
                errorProvider1.SetError(txtState, "Name connot be blank");
                return;
            }
            else
            {
                errorProvider1.Clear();

            }

            if (string.IsNullOrWhiteSpace(txtcity.Text))
            {
                errorProvider1.SetError(txtcity, "Name connot be blank");
                return;
            }
            else
            {
                errorProvider1.Clear();

            }



            string ConnectionString = "Data Source = THARINDU\\SQLEXPRESS01; Initial Catalog = gymStaff; Integrated Security = True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();


            string Query = "Insert into NewStaff(Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,States,city) values ('" + fname + "','" + lname + "','" + gender + "','" + dateOfBirth + "','" + Mobile + "','" + email + "','" + joindate + "','" + state + "', '" + city + "')";

            SqlCommand cmd = new SqlCommand(Query, con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data saved.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

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

            txtState.ResetText();

            txtcity.ResetText();

           

            dateTimePicker1.Value = DateTime.Now;



            dateTimePicker2.Value = DateTime.Now;
        }
    }
}
