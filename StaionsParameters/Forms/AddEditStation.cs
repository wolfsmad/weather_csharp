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
    public partial class AddEditStation : Form
    {
        public AddEditStation()
        {
            InitializeComponent();
        }
        private int id = 0;
        public AddEditStation(int id,string name ="")
        {
            this.id = id;
        }
        private void AddEditStation_Load(object sender, EventArgs e)
        {
            if (id==0)
            {
                //insert 

            }
            else
            {
                //select to db , find recored . 
                textBox1.Text = "id.text";
            }
        }
    }
}
