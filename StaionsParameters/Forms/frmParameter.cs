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
    public partial class frmParameter : Form
    {
        public frmParameter()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditParameter frm = new frmAddEditParameter((int)ActionType.Insert);
            frm.ShowDialog();
            FillGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grdParameter.RowCount == 0 )
            {
                return;
            }
            int parameterid = (int)grdParameter.CurrentRow.Cells[0].Value;
            string parameterName = grdParameter.CurrentRow.Cells[1].Value.ToString();
            frmAddEditParameter frm = new frmAddEditParameter((int)ActionType.Edit, parameterid, parameterName);
            frm.ShowDialog();
            FillGrid();
        }

        private void FillGrid(string query="")
        {
            WeatherDbEntities mybank = new WeatherDbEntities();
            var list = (from x in mybank.tbl_Parameter
                        where x.ParameterName.Contains(query)
                        select x).ToList();
            grdParameter.AutoGenerateColumns = false;
            grdParameter.DataSource = list;

        }
      
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text);
        }

        private void frmParameter_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف اطلاعات اطمینان دارید؟", "پیغام", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(grdParameter.CurrentRow.Cells[0].Value);
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
        private bool Delete(int id)
        {
            try
            {
                WeatherDbEntities mybank = new WeatherDbEntities();
                var listDelete = (from x in mybank.tbl_Parameter
                                  where x.ParameterId == id
                                  select x).SingleOrDefault();
                mybank.tbl_Parameter.Remove(listDelete);
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
