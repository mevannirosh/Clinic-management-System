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
    public partial class stfReg : Form
    {
        public stfReg()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP User\Documents\PMEDrecords.mdf;Integrated Security=True;Connect Timeout=30";
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            stfregPnl.Controls.Clear();
            staffloginmain temp = new staffloginmain();
            temp.TopLevel = false;
            stfregPnl.Controls.Add(temp);
            temp.Show();
        }
        string Sex;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into MedicalStaff values('" + maskedTextBox3.Text + "','" + bunifuTextbox3.Text + "','" + bunifuTextbox4.Text + "','" + bunifuTextbox5.Text + "','" + maskedTextBox5.Text + "','" + Sex + "','" + maskedTextBox1.Text + "','" + bunifuTextbox1.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox2.Text + "','" + bunifuTextbox2.Text + "')", con);


            if (maskedTextBox3.Text == "" || maskedTextBox4.Text == "" || bunifuTextbox3.Text == "" || bunifuTextbox4.Text == "" || maskedTextBox4.Text == "" || maskedTextBox5.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || bunifuTextbox1.Text == "" || bunifuTextbox2.Text == "")
            {
                MessageBox.Show("Please fill all the textboxes");
                return;
            }
            else
            {
                MessageBox.Show("New Account Created");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        private void stfregPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

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
