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
    public partial class docReg : Form
    {
        public docReg()
        {
            InitializeComponent();
            
        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP User\Documents\PMEDrecords.mdf;Integrated Security=True;Connect Timeout=30";
        private void backBtn2_Click(object sender, EventArgs e)
        {
            docRegPnl.Controls.Clear();
            doctorlogin temp = new doctorlogin();
            temp.TopLevel = false;
            docRegPnl.Controls.Add(temp);
            temp.Show();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            docRegPnl.Controls.Clear();
            Dlogin temp = new Dlogin();
            temp.TopLevel = false;
            docRegPnl.Controls.Add(temp);
            temp.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            docRegPnl.Controls.Clear();
            doctorlogin temp = new doctorlogin();
            temp.TopLevel = false;
            docRegPnl.Controls.Add(temp);
            temp.Show();
        }

        string Sex;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox3.Text == "" || maskedTextBox4.Text == "" || bunifuTextbox3.Text == "" || bunifuTextbox4.Text == "" || maskedTextBox4.Text == "" || maskedTextBox5.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || bunifuTextbox1.Text == "" || bunifuTextbox2.Text == "")
            {
                MessageBox.Show("Please fill all the textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("insert into [Doctor] values('" + maskedTextBox3.Text + "','" + maskedTextBox4.Text + "','" + bunifuTextbox3.Text + "','" + bunifuTextbox4.Text + "','" + bunifuTextbox5.Text + "','" + maskedTextBox5.Text + "','" + Sex + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "','" + bunifuTextbox1.Text + "','" + bunifuTextbox2.Text + "')", conn);
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
