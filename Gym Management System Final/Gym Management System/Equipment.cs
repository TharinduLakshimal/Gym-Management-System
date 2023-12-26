using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Equipment : System.Windows.Forms.Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Ename = txtEname.Text;
            string Description = txtDescription.Text;
            string Musle = textmuscle.Text;

           
            string deliveryDate = dateTimePicker1.Text;
            Int64 cost = Int64.Parse(txtCost.Text);
        


            string ConnectionString = "Data Source = THARINDU\\SQLEXPRESS01; Initial Catalog = gymEquipment; Integrated Security = True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();


            string Query = "Insert into NewEquipment(Ename,Descriptions,MuscelsUsed,DeliveryDate,cost) values ('" + Ename + "','" + Description + "','" + Musle + "','" + deliveryDate + "','" + cost + "')";

            SqlCommand cmd = new SqlCommand(Query, con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data saved.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtEname.Clear();

            txtDescription.Clear();
      
            textmuscle.Clear();

            txtCost.Clear();

            



            dateTimePicker1.Value = DateTime.Now;

        
        }
    }
}
