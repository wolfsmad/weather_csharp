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
    public partial class frmInfoStation : Form
    {
        public frmInfoStation()
        {
            InitializeComponent();
        }
        private void frmInfoStation_Load(object sender, EventArgs e)
        {
            FillCmb();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdInfoStation.RowCount > 0)
            {
                if (MessageBox.Show("آیا از حذف اطلاعات مورد نظر اطمینان دارید ؟", "پیغام", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int observeid = (int)grdInfoStation.CurrentRow.Cells[0].Value;
                    int stationid = (int)cmbStations.SelectedValue;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbStations.SelectedIndex == -1)
            {
                MessageBox.Show("لطفا یک ایستگاه انتخاب نمایید", "پیغام");
                return;
            }
            int stationid = (int)cmbStations.SelectedValue;
            frmAddEditInfoStation frm = new frmAddEditInfoStation((int)ActionType.Insert, stationid);
            frm.ShowDialog();
            FillGrid(stationid);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grdInfoStation.RowCount == 0)
            {
                return;
            }

            if (MessageBox.Show("آیا از حذف اطلاعات مورد نظر اطمینان دارید ؟", "پیغام", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;

            }
            int stationid = (int)cmbStations.SelectedValue;
            int observeid = (int)grdInfoStation.CurrentRow.Cells[0].Value;
            int parameterid = (int)grdInfoStation.CurrentRow.Cells[1].Value;
            int value = (int)grdInfoStation.CurrentRow.Cells[4].Value;
            string date = grdInfoStation.CurrentRow.Cells[5].Value.ToString();

            frmAddEditInfoStation frm = new frmAddEditInfoStation((int)ActionType.Edit, stationid: stationid, observeid: observeid, parameterid: parameterid
                , date: date, value: value);
            frm.ShowDialog();
            FillGrid(stationid);
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
        #region Methods
        private void FillGrid(int id)
        {
            WeatherDbEntities mybank = new WeatherDbEntities();
            var listjoin = (from a in mybank.tbl_ObserveData
                            join b in mybank.tbl_Parameters
                            on a.ParameterId equals b.ParameterId
                            join c in mybank.tbl_Stations
                            on b.StationId equals c.StationId
                            where c.StationId == id
                            select new
                            {
                                a.ObserveId,
                                a.ParameterId,
                                b.StationId,
                                b.ParameterName,
                                a.Value,
                                a.Date
                            }).ToList();
            grdInfoStation.AutoGenerateColumns = false;
            grdInfoStation.DataSource = listjoin;
        }
        private void FillCmb()
        {
            WeatherDbEntities mybank = new WeatherDbEntities();
            var list = (from x in mybank.tbl_Stations
                        select x).ToList();
            cmbStations.DataSource = list;
            cmbStations.ValueMember = "StationId";
            cmbStations.DisplayMember = "StationName";
            cmbStations.SelectedIndex = -1;
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
