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
    public partial class frmAddEditInfoParameter : Form
    {
        private int actionType;
        private int parameterid;
        private int observeid;
        private int stationid;
        private int setParameterId;
        private string date = "";
        private int value = 0;
        public frmAddEditInfoParameter(int actiontype, int parameterid, int stationid = 0, int observeid = 0,int setParameterId = 0,string date = "",int value = 0)
        {
            this.actionType = actiontype;
            this.parameterid = parameterid;
            this.observeid = observeid;
            this.stationid = stationid;
            this.date = date;
            this.value = value;
            this.setParameterId = setParameterId;
            InitializeComponent();
        }

        private void frmAddEditInfoParameter_Load(object sender, EventArgs e)
        {
            FillCmb(parameterid);
            if ((int)ActionType.Edit == actionType)
            {
                txtPersianDate.Text = date;
                cmbStation.SelectedValue = setParameterId;
                txtValue.Value = value; 
            }
        }
        private void FillCmb(int parameterid)
        {
            WeatherDbEntities mybank = new WeatherDbEntities();
            var list = (from x in mybank.tbl_SetParameter
                        join a in mybank.tbl_Stations
                        on x.StationId equals a.StationId
                        where x.ParameterId ==  parameterid
                        select new
                        {
                            x.SetParameterId,
                            a.StationName
                        }).ToList();
            cmbStation.DataSource = list;
            cmbStation.DisplayMember = "StationName";
            cmbStation.ValueMember = "SetParameterId";
        }
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((int)ActionType.Insert == actionType)
            {
                if (Add())
                {
                    MessageBox.Show("عملیات با موفقیت به پایان رسید", "پیغام");
                    this.Close();
                }
            }
            else if ((int)ActionType.Edit == actionType)
            {
                if (Edit(observeid))
                {
                    MessageBox.Show("عملیات با موفقیت به پایان رسید", "پیغام");
                    this.Close();
                }
            }
        }
        #region Methods
        private bool Add()
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
            tbl_ObserveData obj = new tbl_ObserveData()
            {
                SetParameterId = (int)cmbStation.SelectedValue,
                Date = txtPersianDate.Text,
                Value = (int)txtValue.Value,

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
                itemEdit.SetParameterId =(int)cmbStation.SelectedValue;
                itemEdit.Date = txtPersianDate.Text;
                itemEdit.Value = (int)txtValue.Value;
                mybank.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
