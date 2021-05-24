using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaionsParameters.Forms
{
    
    public partial class frmAddEditParameter : Form
    {

        int id;
        string name;
        int actionType;
        public frmAddEditParameter(int id,int actionType, string name ="")
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.actionType = actionType;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditParameter_Load(object sender, EventArgs e)
        {
            if (actionType == (int)ActionType.Edit)
            {
                txtParameterName.Text = name;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtParameterName.Text.Trim().Length < 2 )
            {
                MessageBox.Show("Test");
                return;
            }
            if (actionType == (int)ActionType.Insert)
            {
                if (AddParameter(id))
                {
                  this.Close();
                }
                else
                {
                    MessageBox.Show("عملیات ناموفق");
                }
            }
            else
            {
                //Edit

                if (EditParameter(id))
                {
                   // return;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("عملیات ناموفق");
                }
            }

        }
        private bool AddParameter(int id)
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                tbl_Parameters obj = new tbl_Parameters()
                {
                    ParameterName = txtParameterName.Text,
                    StationId = id
                };
                mybank.tbl_Parameters.Add(obj);
                mybank.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private bool EditParameter(int id)
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                var Edit = (from x in mybank.tbl_Parameters
                            where x.ParameterId == id
                            select x).SingleOrDefault();
                Edit.ParameterName = txtParameterName.Text;
                mybank.SaveChanges(); 
                return true;
            }
            catch (Exception)
            {

                return false;   
            }
        }
    }
}
