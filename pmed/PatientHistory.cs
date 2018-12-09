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
    public partial class PatientHistory : Form
    {
        public PatientHistory()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP User\Documents\PMEDrecords.mdf;Integrated Security=True;Connect Timeout=30";
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            patHistoryPnl.Controls.Clear();
            prescriptionMain temp = new prescriptionMain();
            temp.TopLevel = false;
            patHistoryPnl.Controls.Add(temp);
            temp.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter adt = new SqlDataAdapter("select *  from Patient where [ClinicalNo]='" + maskedTextBox1.Text + "'", con);
            DataTable dt = new DataTable();
            con.Open();
            adt.Fill(dt);

            con.Close();
            bunifuCustomDataGrid1.DataSource = dt;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter adt = new SqlDataAdapter("select *  from Records where [ClinicalNo]='" + maskedTextBox1.Text + "'", con);
            DataTable dt = new DataTable();
            con.Open();
            adt.Fill(dt);

            con.Close();
            bunifuCustomDataGrid1.DataSource = dt;
        }
    }
}
