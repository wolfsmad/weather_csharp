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
    public partial class frmAddEditStation : Form
    {
        int id;
        string StationName;
        public frmAddEditStation(int id, string StationName = "")
        {
            InitializeComponent();
            this.id = id;
            this.StationName = StationName;

        }

        private void frmAddEditStation_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                txtStationName.Text = StationName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStationName.Text.Length <= 2)
            {
                MessageBox.Show("نام ایستگاه نامعتبر می باشد.", "خطا", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("آیا از ثبت اطلاعات اطمینان دارید؟", "پیغام", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (id != 0)
                {
                    //Edit
                    if (Edit(id))
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
                    if (Insert())
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
        private bool Insert()
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                tbl_Stations obj = new tbl_Stations()
                {
                    StationName = txtStationName.Text
                };
                mybank.tbl_Stations.Add(obj);
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
                var listEdit = (from x in mybank.tbl_Stations
                                where x.StationId == id
                                select x).FirstOrDefault();
                listEdit.StationName = txtStationName.Text;
                mybank.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
