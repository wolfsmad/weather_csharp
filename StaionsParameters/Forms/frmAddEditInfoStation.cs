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
    public partial class frmAddEditInfoStation : Form
    {
        int stationid;
        int parameterid;
        int value;
        int actiontype;
        int observeid;
        string date;




        public frmAddEditInfoStation(int actiontype, int stationid = 0,int observeid = 0, int parameterid = 0, int value = 0, string date = "")
        {
           
            if (actiontype == (int)ActionType.Edit)
            {
                this.parameterid = parameterid;
                this.date = date;
                this.value = value;
                this.observeid = observeid;
            }
            this.actiontype = actiontype;
            this.stationid = stationid;
            InitializeComponent();
        }

        private void frmAddEditInfoStation_Load(object sender, EventArgs e)
        {
             Fillcmb(stationid);
            if ((int)ActionType.Edit == actiontype)
            {
                txtPersianDate.Text = date;
                txtValue.Value = value;
                cmbParameterName.SelectedValue = parameterid;
            }
           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((int)ActionType.Insert == actiontype)
            {
                if (Add())
                {
                    MessageBox.Show("عملیات با موفقیت به پایان رسید", "پیغام");
                    this.Close();
                }
            }
            else if ((int)ActionType.Edit == actiontype)
            {
                if (Edit(observeid))
                {
                    MessageBox.Show("عملیات با موفقیت به پایان رسید", "پیغام");
                    this.Close();
                }
            }
            
        }
        private void Fillcmb(int stationid)
        {
            WeatherDbEntities mybank = new WeatherDbEntities();
            var list = (from x in mybank.tbl_Parameters
                        where x.StationId == stationid
                        select x).ToList();
            cmbParameterName.DataSource = list;
            cmbParameterName.ValueMember = "ParameterId";
            cmbParameterName.DisplayMember = "ParameterName";
            cmbParameterName.SelectedIndex = -1;
        }
        private bool Add()
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                tbl_ObserveData obj = new tbl_ObserveData()
                {
                    Date = txtPersianDate.Text,
                    ParameterId = (int)cmbParameterName.SelectedValue,
                    Value = (int)txtValue.Value
                };
                mybank.tbl_ObserveData.Add(obj);
                mybank.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool Edit(int observeid)
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                var itemEdit = (from x in mybank.tbl_ObserveData
                                where x.ObserveId == observeid
                                select x).SingleOrDefault();
                itemEdit.ParameterId =(int) cmbParameterName.SelectedValue;
                itemEdit.Date = txtPersianDate.Text;
                itemEdit.Value =(int) txtValue.Value;
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
