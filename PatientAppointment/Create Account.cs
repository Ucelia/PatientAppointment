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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CLEMENT\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Boolean active = true;
            if (active)
            {
                //inseerting data
                String query = "INSERT into patients (fullname,email,password) values('" +fullnameBox.Text + "','" + emailBox.Text + "','" +passwordBox.Text+ "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                conn.Open();
                sda.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(" Registered Successfully");
            }
            else
            {
                MessageBox.Show(" not Registered");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
    }

