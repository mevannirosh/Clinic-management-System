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
    public partial class Dlogin : Form
    {
        public Dlogin()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP User\Documents\PMEDrecords.mdf;Integrated Security=True;Connect Timeout=30";

        private void backBtn_Click(object sender, EventArgs e)
        {
            doclogin.Controls.Clear();
            doctorlogin temp = new doctorlogin();
            temp.TopLevel = false;
            doclogin.Controls.Add(temp);
            temp.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            doclogin.Controls.Clear();
            prescriptionMain temp = new prescriptionMain();
            temp.TopLevel = false;
            doclogin.Controls.Add(temp);
            temp.Show();
            /*if (bunifuTextbox1.Text == "" || bunifuTextbox2.Text == "")
            {
                MessageBox.Show ("Please provide user name and password", "Error", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select UserName,Password from [Doctor] where UserName=@UserName and Password=@Password", conn);
                cmd.Parameters.AddWithValue("@UserName", bunifuTextbox1.Text);
                cmd.Parameters.AddWithValue("@Password", bunifuTextbox2.Text);
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    doclogin.Controls.Clear();
                    prescriptionMain temp = new prescriptionMain();
                    temp.TopLevel = false;
                    doclogin.Controls.Add(temp);
                    temp.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            doclogin.Controls.Clear();
            doctorlogin temp = new doctorlogin();
            temp.TopLevel = false;
            doclogin.Controls.Add(temp);
            temp.Show();
        }
    }
}
