using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaionsParameters.Forms;
using StaionsParameters;

namespace Weather
{
    public partial class frmStations : Form
    {
        public frmStations()
        {
            InitializeComponent();
        }

        private void frmStations_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditStation frm = new frmAddEditStation(0);
            frm.ShowDialog();
            FillGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Get FRom Grid Id
            if (grdStation.RowCount == 0)
            {
                return;
            }
            int id = Convert.ToInt32(grdStation.CurrentRow.Cells[0].Value);
            string StationName = grdStation.CurrentRow.Cells[1].Value.ToString();
            frmAddEditStation frm = new frmAddEditStation(id, StationName);
            frm.ShowDialog();
            FillGrid();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdStation.RowCount == 0)
            {
                MessageBox.Show("لطفا ابتدا ایستگاه وارد نمائید", "خطا");
                return;
            }
            if (MessageBox.Show("آیا از حذف اطلاعات اطمینان دارید؟", "پیغام", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(grdStation.CurrentRow.Cells[0].Value);
                if (Delete(id))
                {
                    FillGrid();
                }
                else
                {
                    MessageBox.Show("عملیات ناموفق به پایان رسید", " خطا", MessageBoxButtons.OK);
                }
            }

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text);
        }
        #region Functions
        private void FillGrid(string query = "")
        {
            WeatherDbEntities mybank = new WeatherDbEntities();
            var list = (from x in mybank.tbl_Stations
                        where x.StationName.Contains(query)
                        select x).ToList();
            grdStation.AutoGenerateColumns = false;
            grdStation.DataSource = list;

            //    this.tbl_StationsTableAdapter.Fill(this.weatherDbDataSet.tbl_Stations);
        }

        private bool Delete(int id)
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                var listDelete = (from x in mybank.tbl_Stations
                                  where x.StationId == id
                                  select x).SingleOrDefault();
                mybank.tbl_Stations.Remove(listDelete);
                mybank.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        private void Search()
        {

        }


        #endregion


    }
}
