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
    public partial class DoctorHome : Form
    {
        public DoctorHome()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=CLEMENT\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True");
        private void DoctorHome_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from appointment ", conn);
            DataTable DB = new DataTable();
            sda.Fill(DB);
            dataGridView1.DataSource = DB;

        }

        private void RespondButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("UPDATE  appointment SET  status='" + respondcomboBox.Text + "' WHERE email='" + emailBox.Text + "'", conn);

            conn.Open();
            // Save to the database 
            cmd.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Submited");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                fullNameBox.Text = row.Cells["fullname"].Value.ToString();
                doctortextBox1.Text = row.Cells["doctor"].Value.ToString();
               emailBox.Text = row.Cells["email"].Value.ToString();           
                respondcomboBox.Text = row.Cells["Status"].Value.ToString();

                object cellValue = row.Cells["date"].Value;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    // Convert the cell value to a DateTime and assign it to the DateTimePicker
                    dateTimePicker1.Value = Convert.ToDateTime(cellValue);
                }
                else
                {
                  
                    dateTimePicker1.Value = DateTime.Now; // Set a default date, such as the current date
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
