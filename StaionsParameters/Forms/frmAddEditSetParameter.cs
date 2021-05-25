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
    
    public partial class frmAddEditSetParameter : Form
    {

        
        int stationId;
        int parameterId;
        int setParameterId;
        int actionType;
        public frmAddEditSetParameter(int actionType,int setParameterId = 0, int stationId =0,int parameterId = 0)
        {
            InitializeComponent();
            
            this.stationId = stationId;
            this.parameterId = parameterId;
            this.setParameterId = setParameterId;


            this.actionType = actionType;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditParameter_Load(object sender, EventArgs e)
        {
            FillCmb();
            if (actionType == (int)ActionType.Edit)
            {
                cmbStation.SelectedValue = stationId;
                cmbParameter.SelectedValue = parameterId;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckDuplicate((int)cmbStation.SelectedValue,(int)cmbParameter.SelectedValue))
            {
                MessageBox.Show("پارامتر مورد نظر برای ایستگاه جاری موجود می باشد");
                return;
            }
            if (cmbParameter.SelectedIndex ==  -1 || cmbStation.SelectedIndex == -1 )
            {
                MessageBox.Show("تمامی گزینه ها می بایست انتخاب گردد");
                return;
            }
            if (actionType == (int)ActionType.Insert)
            {
                if (AddParameter())
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

                if (EditParameter(setParameterId))
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
        private bool AddParameter()
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                tbl_SetParameter obj = new tbl_SetParameter()
                {
                    ParameterId =(int) cmbParameter.SelectedValue,
                    StationId = (int)cmbStation.SelectedValue
                };
                mybank.tbl_SetParameter.Add(obj);
                mybank.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private bool EditParameter(int setParameterId)
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                var Edit = (from x in mybank.tbl_SetParameter
                            where  x.SetParameterId == setParameterId
                            select x).SingleOrDefault();
                Edit.ParameterId = (int)cmbParameter.SelectedValue;
                mybank.SaveChanges(); 
                return true;
            }
            catch (Exception)
            {

                return false;   
            }
        }
        private void FillCmb()
        {
            WeatherDbEntities mybank = new WeatherDbEntities();

            var listStations = (from x in mybank.tbl_Stations
                                where x.StationId == stationId
                               select x).ToList();
            cmbStation.DataSource = listStations;
            cmbStation.DisplayMember = "StationName";
            cmbStation.ValueMember = "StationId";
           

            var listParameters = (from x in mybank.tbl_Parameter
                                    select x).ToList();
            cmbParameter.DataSource = listParameters;
            cmbParameter.DisplayMember = "ParameterName";
            cmbParameter.ValueMember = "ParameterId";
            cmbParameter.SelectedIndex = -1;

        }
        private bool CheckDuplicate(int stationId , int parameterId)
        {
            WeatherDbEntities mybank = new WeatherDbEntities();

            var list = (from x in mybank.tbl_SetParameter
                        where x.StationId == stationId && x.ParameterId == parameterId
                        select x).Count();
            if (list > 0)
            {
                return false;
            }
            return true;
        }
    }
}
