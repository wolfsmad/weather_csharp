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
        int actiontype;
        int parameterid;
        string parameterName;
        public frmAddEditParameter(int actiontype,int parameterid =0,string parameterName = "" )
        {
            this.actiontype = actiontype;
            this.parameterid = parameterid;
            this.parameterName = parameterName;
            InitializeComponent();
        }

        private void frmAddEditParameter_Load(object sender, EventArgs e)
        {
            if ((int)ActionType.Edit == actiontype)
            {
                txtParamterName.Text = parameterName;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtParamterName.Text.Length < 2)
            {
                MessageBox.Show("نام پارامتر نامعتبر می باشد.", "خطا", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("آیا از ثبت اطلاعات اطمینان دارید؟", "پیغام", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!CheckDuplicate(txtParamterName.Text))
                {
                    MessageBox.Show("نام پارامتر تکراری می باشد", "خطا", MessageBoxButtons.OK);
                    return;
                }
                if (parameterid != 0)
                {
                    //Edit
                    if (Edit(parameterid))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("عملیات ناموفق به پایان رسید", "خطا", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    //insert

                    if (Add())
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("عملیات ناموفق به پایان رسید", "خطا", MessageBoxButtons.OK);
                        return;
                    }

                }
            }
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        #region Methods

        private bool Add()
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                tbl_Parameter obj = new tbl_Parameter()
                {
                    ParameterName = txtParamterName.Text
                };
                mybank.tbl_Parameter.Add(obj);
                mybank.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        private bool Edit(int id)
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                var listEdit = (from x in mybank.tbl_Parameter
                                where x.ParameterId == id
                                select x).FirstOrDefault();
                listEdit.ParameterName = txtParamterName.Text;
                mybank.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool CheckDuplicate(string name)
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();

                var checklist = (from x in mybank.tbl_Parameter
                                 where x.ParameterName == name
                                 select x).Count();
                if (checklist > 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

      
    }
}
