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
    public partial class frmInfoParameter : Form
    {
        public frmInfoParameter()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbParameter.SelectedIndex == -1)
            {
                MessageBox.Show("لطفا یک خصوصیت انتخاب نمایید", "پیغام");
                return;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grdInfoParameter.RowCount == 0)
            {
                return;
            }

            if (MessageBox.Show("آیا از حذف اطلاعات مورد نظر اطمینان دارید ؟", "پیغام", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            int parameterid = (int)cmbParameter.SelectedValue;
            int observeid = (int)grdInfoParameter.CurrentRow.Cells[0].Value;
            int stationid = (int)grdInfoParameter.CurrentRow.Cells[1].Value;
            int value = (int)grdInfoParameter.CurrentRow.Cells[4].Value;
            string date = grdInfoParameter.CurrentRow.Cells[5].Value.ToString();

            //frmAddEditParameter frm = new frmAddEditParameter((int)ActionType.Edit, stationid: stationid, observeid: observeid, parameterid: parameterid
            //    , date: date, value: value);
            //frm.ShowDialog();
            FillGrid(parameterid);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdInfoParameter.RowCount > 0)
            {
                if (MessageBox.Show("آیا از حذف اطلاعات مورد نظر اطمینان دارید ؟", "پیغام", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int observeid = (int)grdInfoParameter.CurrentRow.Cells[0].Value;
                    int stationid = (int)cmbParameter.SelectedValue;
                    if (Delete(observeid))
                    {
                        MessageBox.Show("عملیات حذف با موفقیت به پایان رسید", "پیغام");
                        FillGrid(stationid);
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
        private void FillGrid(int id)
        {
            WeatherDbEntities mybank = new WeatherDbEntities();
            var listjoin = (from a in mybank.tbl_ObserveData
                            join b in mybank.tbl_Parameters
                            on a.ParameterId equals b.ParameterId
                            join c in mybank.tbl_Stations
                            on b.StationId equals c.StationId
                            where b.ParameterId == id
                            select new
                            {
                                a.ObserveId,
                                a.ParameterId,
                                b.StationId,
                                b.ParameterName,
                                a.Value,
                                a.Date
                            }).ToList();
            grdInfoParameter.AutoGenerateColumns = false;
            grdInfoParameter.DataSource = listjoin;
        }
        private void FillCmb()
        {
            WeatherDbEntities mybank = new WeatherDbEntities();
            var list = (from x in mybank.tbl_Parameters
                        select x).ToList();
            cmbParameter.DataSource = list;
            cmbParameter.ValueMember = "ParameterId";
            cmbParameter.DisplayMember = "ParameterName";
            cmbParameter.SelectedIndex = -1;
        }
        private bool Delete(int id)
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                var item = (from x in mybank.tbl_ObserveData
                            where x.ObserveId == id
                            select x).SingleOrDefault();
                mybank.tbl_ObserveData.Remove(item);
                mybank.SaveChanges();
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
