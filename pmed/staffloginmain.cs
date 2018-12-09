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
    public partial class staffloginmain : Form
    {
        public staffloginmain()
        {
            InitializeComponent();
        }

        private void stflogBtn_Click(object sender, EventArgs e)
        {
            stfmainPnl.Controls.Clear();
            stafflog temp = new stafflog();
            temp.TopLevel = false;
            stfmainPnl.Controls.Add(temp);
            temp.Show();
        }

        private void dctrRegBtn_Click(object sender, EventArgs e)
        {
            stfmainPnl.Controls.Clear();
            stfReg temp = new stfReg();
            temp.TopLevel = false;
            stfmainPnl.Controls.Add(temp);
            temp.Show();
        }
    }
}
