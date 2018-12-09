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
    public partial class patreg : Form
    {
        public patreg()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP User\Documents\PMEDrecords.mdf;Integrated Security=True;Connect Timeout=30";

        private void back1_Click(object sender, EventArgs e)
        {

        }

        private void pathisBtn_Click(object sender, EventArgs e)
        {
            PatientRegPanel.Controls.Clear();
            PatientHistory temp = new PatientHistory();
            temp.TopLevel = false;
            PatientRegPanel.Controls.Add(temp);
            temp.Show();
        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bunifuTextbox3_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox5_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            PatientRegPanel.Controls.Clear();
            Record temp = new Record();
            temp.TopLevel = false;
            PatientRegPanel.Controls.Add(temp);
            temp.Show();
        }
        string Sex;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox3.Text == "" || bunifuTextbox3.Text == "" || maskedTextBox6.Text == "" || maskedTextBox5.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || maskedTextBox1.Text == "" || bunifuTextbox2.Text == "" || maskedTextBox9.Text == "" || maskedTextBox10.Text == "" || bunifuTextbox6.Text == "" || bunifuTextbox5.Text == "" || bunifuTextbox1.Text == "" || maskedTextBox4.Text == "" || bunifuTextbox4.Text == "" || maskedTextBox11.Text == "" || maskedTextBox8.Text == "")
            {
                MessageBox.Show("Please fill all the textboxes");
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("insert into [Doctor] values('" + maskedTextBox3.Text + "','" + bunifuTextbox3.Text + "','" + maskedTextBox6.Text + "','" + maskedTextBox5.Text + "','" + Sex + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "','" + bunifuTextbox2.Text + "','" + maskedTextBox9.Text + "','" + maskedTextBox10.Text + "','" + bunifuTextbox6.Text + "','" + bunifuTextbox5.Text + "','" + bunifuTextbox1.Text + "','" + maskedTextBox4.Text + "','" + bunifuTextbox4.Text + "','" + maskedTextBox11.Text + "','" + maskedTextBox8.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("New Account Created");
            }

        }

        private void mRbtn_CheckedChanged(object sender, EventArgs e)
        {
            Sex = "Male";
        }

        private void fRbtn_CheckedChanged(object sender, EventArgs e)
        {
            Sex = "Female";
        }
    }
}
