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
using Otomasyon_V0.Forms.FrmTasks;

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

        private void BtnTaskAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTaskAdd frmTaskAdd = new FrmTaskAdd();
            frmTaskAdd.Show();
        }

        private void BtnCalculator_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
        }

        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.youtube.com/");
        }

        private void BtnNews_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.haberler.com/");
        }

        private void BtnFinance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://tr.investing.com/");
        }

        private void BtnMap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://earth.google.com/web/");
        }

        private void BtnTaskDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTaskDetails frmTaskDetails = new FrmTaskDetails();
            frmTaskDetails.Show();
        }
    }
}
