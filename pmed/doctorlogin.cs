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
    public partial class doctorlogin : Form
    {
        public doctorlogin()
        {
            InitializeComponent();
        }

        private void dctrloginBtn_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Controls.Clear();
            Dlogin temp = new Dlogin();
            temp.TopLevel = false;
            bunifuGradientPanel1.Controls.Add(temp);
            temp.Show();
        }

        private void dctrRegBtn_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Controls.Clear();
            docReg temp = new docReg();
            temp.TopLevel = false;
            bunifuGradientPanel1.Controls.Add(temp);
            temp.Show();
        } 
    }
}
