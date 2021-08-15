using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otomasyon_V0.Forms;
using Otomasyon_V0.Forms.FrmEmployee;

namespace Otomasyon_V0
{
    public partial class Beginpage : Form
    {
        public Beginpage()
        {
            InitializeComponent();
        }

        private void BtnEmployeeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEmployeeList frmEmployeeList = new FrmEmployeeList();
            frmEmployeeList.MdiParent = this;
            frmEmployeeList.Show();
        }

        private void BtnCompanyList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCompaniesList frmCompaniesList = new FrmCompaniesList();
            frmCompaniesList.MdiParent = this;
            frmCompaniesList.Show();
        }

        private void BtnDepartmentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepartmentList frmDepartmentList = new FrmDepartmentList();
            frmDepartmentList.MdiParent = this;
            frmDepartmentList.Show();
        }

        private void BtnTaskList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTasksList frmTasksList = new FrmTasksList();
            frmTasksList.MdiParent = this;
            frmTasksList.Show();
        }

        private void BtnEmployeeStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEmployeeStatistic frmEmployeeStatistic = new FrmEmployeeStatistic();
            frmEmployeeStatistic.MdiParent = this;
            frmEmployeeStatistic.Show();
        }
    }
}
