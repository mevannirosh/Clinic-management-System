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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP User\Documents\PMEDrecords.mdf;Integrated Security=True;Connect Timeout=30";
        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextbox4_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox5_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            RecordPanel.Controls.Clear();
            patreg temp = new patreg();
            temp.TopLevel = false;
            RecordPanel.Controls.Add(temp);
            temp.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into Records values('" + maskedTextBox3.Text + "','" + maskedTextBox4.Text + "','" + bunifuTextbox1.Text + "','" + bunifuTextbox3.Text + "','" + bunifuTextbox2.Text + "','" + bunifuTextbox4.Text + "','" + bunifuTextbox5.Text + "')", con);

            MessageBox.Show("Data inserted");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
