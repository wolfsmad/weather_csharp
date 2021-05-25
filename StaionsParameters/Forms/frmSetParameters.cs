using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaionsParameters.Forms
{
    enum ActionType
    {
        Insert = 1,
        Edit = 2
    }
    public partial class frmSetParameters : Form
    {
        public frmSetParameters()
        {
            InitializeComponent();
        }
        private void frmParameters_Load(object sender, EventArgs e)
        {
            FillCmb();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbStations.SelectedIndex > -1)
            {
                int stationid = (int)cmbStations.SelectedValue;
                frmAddEditSetParameter frm = new frmAddEditSetParameter((int)ActionType.Insert,stationId: stationid);
                frm.ShowDialog();
                //if (frm.DialogResult == DialogResult.OK)
                //{
                    FillGrid(stationid);
                //}
            }
            else
            {
                MessageBox.Show("لطفا یک ایستگاه انتخاب نمایید", "پیغام");
            }

        }
        private void cmbStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)cmbStations.SelectedValue;
                FillGrid(id);
            }
            catch (Exception)
            {
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmbStations.SelectedIndex > -1 && grdParameter.RowCount > 0)
            {
                int stationid = (int)cmbStations.SelectedValue;
                int setParameterId = (int)(int)grdParameter.CurrentRow.Cells[0].Value;
                int parameterid = (int)grdParameter.CurrentRow.Cells[1].Value;

                frmAddEditSetParameter frm = new frmAddEditSetParameter( (int)ActionType.Edit, setParameterId, stationid, parameterid);
                frm.ShowDialog();
                FillGrid(stationid);
            }
            else
            {
                MessageBox.Show("لطفا یک ایستگاه انتخاب نمایید", "پیغام");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdParameter.RowCount > 0)
            {
                if (MessageBox.Show("آیا از حذف پارامتر مورد نظر اطمینان دارید ؟", "پیغام", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int setParameterid = (int)grdParameter.CurrentRow.Cells[0].Value;
                    
                    if (Delete(setParameterid))
                    {
                        MessageBox.Show("عملیات حذف با موفقیت به پایان رسید","پیغام");
                        FillGrid((int)cmbStations.SelectedValue);
                    }
                    else
                    {
                        MessageBox.Show("عملیات حذف با خطا مواجه شد", "پیغام");
                        return;
                    }
                }
            }
        }
        #region Methods
        private bool Delete(int setParameterid)
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                var item = (from x in mybank.tbl_SetParameter
                            where x.SetParameterId == setParameterid
                            select x).SingleOrDefault();
                mybank.tbl_SetParameter.Remove(item);
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
            var list = (from x in mybank.tbl_Stations
                        orderby x.StationName
                        select x).ToList();
            cmbStations.DataSource = list;
            cmbStations.DisplayMember = "StationName";
            cmbStations.ValueMember = "StationId";
            cmbStations.SelectedIndex = -1;

        }
        private void FillGrid(int id)
        {
            WeatherDbEntities mybank = new WeatherDbEntities();
            var list = (from x in mybank.tbl_SetParameter
                        join a in mybank.tbl_Parameter
                        on x.ParameterId equals a.ParameterId
                        where x.StationId == id
                        select new {
                            x.ParameterId,
                            x.SetParameterId,
                            a.ParameterName,

                        }).ToList();
            grdParameter.AutoGenerateColumns = false;
            grdParameter.DataSource = list;
        }
        #endregion
    }
}
