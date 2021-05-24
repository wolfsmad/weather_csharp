using StaionsParameters.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather;
namespace StaionsParameters
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStationNew_Click(object sender, EventArgs e)
        {
            frmStations frm = new frmStations();
            frm.ShowDialog();
            
        }

        private void btnPropertyNew_Click(object sender, EventArgs e)
        {
            frmParameters frm = new frmParameters();
            frm.ShowDialog();
        }

        private void btnInfoStation_Click(object sender, EventArgs e)
        {
            frmInfoStation frm = new frmInfoStation();
            frm.ShowDialog();
        }

        private void btnInfoProperty_Click(object sender, EventArgs e)
        {
            frmInfoParameter frm = new frmInfoParameter();
            frm.ShowDialog();
        }
    }
}
