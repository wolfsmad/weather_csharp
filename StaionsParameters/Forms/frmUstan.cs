using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaionsParameters.BaseInfo
{
    public partial class frmUstan : Form
    {
        public frmUstan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("حذف اطلاعات", "آیا از حذف اطلاعات اطمینان دارید ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //delete
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("حذف اطلاعات", "آیا از حذف اطلاعات اطمینان دارید ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Edit 
                // Go to form EDitAnd Add 
                //انتخاب شده گرید ست شود درون یک متغیر و به فرم ویرایش پاس داده شود
            }
        }
    }
}
