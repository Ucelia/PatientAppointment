using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PatientAppointment
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CLEMENT\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True");
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            Boolean active = true;
            if (active)
            {
                //inseerting data
                String query = "INSERT into appointment (fullname,doctor,date,email) values('" + fullNameBox.Text + "','"+doctortextBox.Text+"','"  +dateTimePicker1.Value+ "','" + emailBox.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                conn.Open();
                sda.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Claim Submited");
            }
            else
            {
                MessageBox.Show("Claim not Submited");
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusbutton_Click(object sender, EventArgs e)
        {
            new AppointmentStatus().Show();
            this.Hide();
        }
    }
    }

