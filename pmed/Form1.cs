using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pmed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            if(slidingpnl.Width==50)
            {
                slidingpnl.Visible = false;
                slidingpnl.Width = 234;
                pnlanimator.ShowSync(slidingpnl);
                mainpnl.Width = 790;
                mainpnlanimator.ShowSync(mainpnl);
                 
            }

            else
            {
                slidingpnl.Visible = false;
                slidingpnl.Width = 50;
                pnlanimator.ShowSync(slidingpnl);
                mainpnl.Width = 600;
                mainpnlanimator.ShowSync(mainpnl);
            }
        }

        private void doctorbtn_Click(object sender, EventArgs e)
        {
            mainpnl.Controls.Clear();
            doctorlogin temp = new doctorlogin();
            temp.TopLevel = false;
            mainpnl.Controls.Add(temp);
            temp.Show();
        }

        private void staffbtn_Click(object sender, EventArgs e)
        {
            mainpnl.Controls.Clear();
            staffloginmain temp = new staffloginmain();
            temp.TopLevel = false;
            mainpnl.Controls.Add(temp);
            temp.Show();
        }

        private void resbtn_Click(object sender, EventArgs e)
        {
            mainpnl.Controls.Clear();
            research temp = new research();
            temp.TopLevel = false;
            mainpnl.Controls.Add(temp);
            temp.Show();
        }
    }
}
