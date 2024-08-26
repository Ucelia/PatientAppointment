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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CLEMENT\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True");
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

            String user_email, user_pass;
            user_email = emailtextBox.Text;
            user_pass = passwordtextBox.Text;
            try
            {
                string query = ("select * from patients where email = '" + emailtextBox.Text + "' and Password = '" + passwordtextBox.Text + "'");
                string queryy = ("select * from doctor where email = '" + emailtextBox.Text + "' and Password = '" + passwordtextBox.Text + "'");
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlDataAdapter sdaa = new SqlDataAdapter(queryy, conn);
                conn.Open();
                DataTable dtable = new DataTable();
               DataTable atable = new DataTable();
                sda.Fill(dtable);
               sdaa.Fill(atable);

                if ((dtable.Rows.Count > 0))
                {
                    user_email = emailtextBox.Text;
                    user_pass = passwordtextBox.Text;


                    MessageBox.Show("Welcome To Patient Account");
                    new Home().Show();
                    this.Hide();
                }
                else if (atable.Rows.Count > 0)
                {
                    user_email = emailtextBox.Text;
                    user_pass = passwordtextBox.Text;

                    MessageBox.Show("Welcome To Doctor Account");
                    new DoctorHome().Show();
                    this.Hide();



                }
                else
                {
                    MessageBox.Show("Invalid id or Password");
                    emailtextBox.Clear();
                    passwordtextBox.Clear();
                }


            }
            catch
            {
                MessageBox.Show("Error");
            }

            finally
            {
                conn.Close();
            }
        }

    }
}

