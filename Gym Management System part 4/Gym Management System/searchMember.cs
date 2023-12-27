using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Gym_Management_System
{
    public partial class searchMember : Form
    {
        public searchMember()
        {
            InitializeComponent();
        }

        private void searchMember_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = THARINDU\\SQLEXPRESS01; Initial Catalog = gym; Integrated Security = True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "select * from NewMember";

            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();

            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                string ConnectionString = "Data Source = THARINDU\\SQLEXPRESS01; Initial Catalog = gym; Integrated Security = True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                string Query = "select * from NewMember where MID = " + txtSearch.Text + "";

                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();

                table.Load(reader);

                dataGridView1.DataSource = table;

                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter some id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
