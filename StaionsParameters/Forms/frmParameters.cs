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
    public partial class frmParameters : Form
    {
        public frmParameters()
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
                int id = (int)cmbStations.SelectedValue;
                frmAddEditParameter frm = new frmAddEditParameter(id, (int)ActionType.Insert);
                frm.ShowDialog();
                //if (frm.DialogResult == DialogResult.OK)
                //{
                    FillGrid(id);
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
                int id = (int)grdParameter.CurrentRow.Cells[0].Value;
                string name = grdParameter.CurrentRow.Cells[1].Value.ToString();
                frmAddEditParameter frm = new frmAddEditParameter(id, (int)ActionType.Edit, name);
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
                    int id = (int)grdParameter.CurrentRow.Cells[0].Value;
                    int stationid = (int)cmbStations.SelectedValue;
                    if (Delete(id))
                    {
                        MessageBox.Show("عملیات حذف با موفقیت به پایان رسید","پیغام");
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
        private bool Delete(int id)
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                var item = (from x in mybank.tbl_Parameters
                            where x.ParameterId == id
                            select x).SingleOrDefault();
                mybank.tbl_Parameters.Remove(item);
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
            var list = (from x in mybank.tbl_Parameters
                        where x.StationId == id
                        select new {
                            x.ParameterId,
                            x.ParameterName
                        }).ToList();
            grdParameter.DataSource = list;
        }
        #endregion
    }
}
