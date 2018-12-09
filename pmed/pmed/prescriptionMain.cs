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

namespace pmed
{
    public partial class prescriptionMain : Form
    {
        public prescriptionMain()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP User\Documents\PMEDrecords.mdf;Integrated Security=True;Connect Timeout=30";
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Controls.Clear();
            prisHistory temp = new prisHistory();
            temp.TopLevel = false;
            bunifuGradientPanel1.Controls.Add(temp);
            temp.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Controls.Clear();
            PatientHistory temp = new PatientHistory();
            temp.TopLevel = false;
            bunifuGradientPanel1.Controls.Add(temp);
            temp.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into [Records] (Prescription) values('" + textBox1.Text + "') where ClinicalNo ('" + maskedTextBox1.Text + "')", con);

            MessageBox.Show("Data inserted");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("update [Patient] (NextClinicalDay) values('" + maskedTextBox4.Text + "')where ClinicalNo=('" + maskedTextBox1.Text + "')", con);

            MessageBox.Show("Date updated");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
