using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Otomasyon_V0.DBEntity;

namespace Otomasyon_V0.Forms
{
    public partial class FrmDepartmentList : Form
    {
        public FrmDepartmentList()
        {
            InitializeComponent();
            List();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        TblDepartman tblDepartman = new TblDepartman();
        
        void List()
        {
            var veriables = (from x in isTakipOtomasyonEntities.TblDepartman
                             select new
                             {
                                 x.ID,
                                 x.Ad
                             }).ToList();
            grdControlDepartmentList.DataSource = veriables;
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            tblDepartman.Ad = TxtAd.Text;
            isTakipOtomasyonEntities.TblDepartman.Add(tblDepartman);
            isTakipOtomasyonEntities.SaveChanges();
            List();
            XtraMessageBox.Show("Departman Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnDeleted_Click(object sender, EventArgs e)
        {
            int find = int.Parse(TxtID.Text);
            var value = isTakipOtomasyonEntities.TblDepartman.Find(find);
            isTakipOtomasyonEntities.TblDepartman.Remove(value);
            isTakipOtomasyonEntities.SaveChanges();
            List();
            XtraMessageBox.Show("Seçilen Departman Başarıyla Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int find = int.Parse(TxtID.Text);
            var value = isTakipOtomasyonEntities.TblDepartman.Find(find);
            value.Ad = TxtAd.Text;
            isTakipOtomasyonEntities.SaveChanges();
            List();
            XtraMessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
