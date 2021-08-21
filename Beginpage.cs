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
using Otomasyon_V0.DBEntity;

namespace Otomasyon_V0
{
    public partial class Beginpage : Form
    {
        public Beginpage()
        {
            InitializeComponent();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        FrmEmployeeList frmEmployeeList;
        FrmCompaniesList frmCompaniesList;
        FrmDepartmentList frmDepartmentList;
        FrmTasksList frmTasksList;
        FrmEmployeeStatistic frmEmployeeStatistic;
        FrmTaskAdd frmTaskAdd;
        FrmTaskDetails frmTaskDetails;


        private void BtnEmployeeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmEmployeeList==null||frmEmployeeList.IsDisposed)
            {
                frmEmployeeList= new FrmEmployeeList();
                frmEmployeeList.MdiParent = this;
                frmEmployeeList.Show();
            }
            
        }

        private void BtnCompanyList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCompaniesList == null || frmCompaniesList.IsDisposed)
            {
                frmCompaniesList = new FrmCompaniesList();
                frmCompaniesList.MdiParent = this;
                frmCompaniesList.Show();
            }
        }

        private void BtnDepartmentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDepartmentList == null || frmDepartmentList.IsDisposed)
            {
                frmDepartmentList = new FrmDepartmentList();
                frmDepartmentList.MdiParent = this;
                frmDepartmentList.Show();
            }
        }

        private void BtnTaskList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmTasksList == null || frmTasksList.IsDisposed)
            {
                frmTasksList = new FrmTasksList();
                frmTasksList.MdiParent = this;
                frmTasksList.Show();
            }
        }

        private void BtnEmployeeStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmEmployeeStatistic == null || frmEmployeeStatistic.IsDisposed)
            {
                frmEmployeeStatistic = new FrmEmployeeStatistic();
                frmEmployeeStatistic.MdiParent = this;
                frmEmployeeStatistic.Show();
            }
        }

        private void BtnTaskAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmTaskAdd == null || frmTaskAdd.IsDisposed)
            {
                frmTaskAdd = new FrmTaskAdd();
                frmTaskAdd.Show();
            }
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
            if (frmTaskDetails == null || frmTaskDetails.IsDisposed)
            {
                frmTaskDetails = new FrmTaskDetails();
                frmTaskDetails.Show();
            }
        }
    }
}
