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
    public partial class stafflog : Form
    {
        public stafflog()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP User\Documents\PMEDrecords.mdf;Integrated Security=True;Connect Timeout=30";
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            stfloginPnl.Controls.Clear();
            staffloginmain temp = new staffloginmain();
            temp.TopLevel = false;
            stfloginPnl.Controls.Add(temp);
            temp.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            stfloginPnl.Controls.Clear();
            patreg temp = new patreg();
            temp.TopLevel = false;
            stfloginPnl.Controls.Add(temp);
            temp.Show();

            /*if (bunifuTextbox1.Text == "" || bunifuTextbox2.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
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
                    stfloginPnl.Controls.Clear();
                    patreg temp = new patreg();
                    temp.TopLevel = false;
                    stfloginPnl.Controls.Add(temp);
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
    }
}
