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
    public partial class AppointmentStatus : Form
    {
        public AppointmentStatus()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CLEMENT\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True");
        private void AppointmentStatus_Load(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the database connection
                conn.Open();

                // Define your SQL query to retrieve the value from the database
                string query = "SELECT Status FROM appointment WHERE email='" + emailtextBox.Text + "'";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Execute the query and retrieve the single value
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    // Set the retrieved value as the Text property of the TextBox
                    statusBox.Text = result.ToString();
                }
                else
                {
                    statusBox.Text = "No data found"; // Handle the case where no data is found


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                conn.Close();
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            new Home().Show();
            //this.Hide();
        }
    }
    }

