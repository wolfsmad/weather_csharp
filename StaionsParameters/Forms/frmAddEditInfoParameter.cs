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
        private string stationName;
        private string parameterName;
        public frmAddEditInfoParameter(int actiontype, int parameterid, string  stationName ,string parameterName,int observeid = 0 )
        {
            this.actionType = actiontype;
            this.parameterid = parameterid;
            this.observeid = observeid;
            this.stationName = stationName;
            this.parameterName = parameterName;
            InitializeComponent();
        }

        private void frmAddEditInfoParameter_Load(object sender, EventArgs e)
        {
            lblStationName.Text ="ثبت اطلاعات برای " +  stationName + " در خصوصیت  " + parameterName;
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
                    SetParameterId = parameterid,
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
