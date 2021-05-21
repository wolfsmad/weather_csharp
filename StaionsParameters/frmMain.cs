using StaionsParameters.BaseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaionsParameters
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmStation_Click(object sender, EventArgs e)
        {
            var myForm = new AddEditStation();
            myForm.Show();
        }

        private void picStation_Click(object sender, EventArgs e)
        {
            var myForm = new AddEditStation();
            myForm.Show();
        }
    }
}
