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
using Otomasyon_V0.Forms;

namespace Otomasyon_V0.Forms
{
    public partial class FrmEmployeeList : Form
    {
        public FrmEmployeeList()
        {
            InitializeComponent();
            List();

            var value = (from x in isTakipOtomasyonEntities.TblDepartman
                         select new
                         {
                             x.ID,
                             x.Ad
                         }).ToList();
            LkUpEmployee.Properties.ValueMember = "ID";
            LkUpEmployee.Properties.DisplayMember = "Ad";
            LkUpEmployee.Properties.DataSource =value;
        }
        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        TblPersonel tblPersonel = new TblPersonel();

        void List()
        {
            var values = from x in isTakipOtomasyonEntities.TblPersonel
                         select new
                         {
                             x.ID,
                             x.Ad,
                             x.Soyad,
                             x.Mail,
                             Dprtmn=x.TblDepartman.Ad,
                             x.Durum
                         };
            grdControlEmployeeList.DataSource = values.ToList();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            tblPersonel.Ad = TxtAd.Text;
            tblPersonel.Soyad = TxtSoyad.Text;
            tblPersonel.Mail = TxtMail.Text;
            tblPersonel.Departman = int.Parse(LkUpEmployee.EditValue.ToString());
            tblPersonel.Gorsel = TxtGorsel.Text;
            isTakipOtomasyonEntities.TblPersonel.Add(tblPersonel);
            isTakipOtomasyonEntities.SaveChanges();
            XtraMessageBox.Show("Yeni Personel Başarıyla Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            List();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
        }

        private void BtnDeleted_Click(object sender, EventArgs e)
        {
            var find = int.Parse(TxtID.Text);
            var value = isTakipOtomasyonEntities.TblPersonel.Find(find);
            value.Durum = false;
            isTakipOtomasyonEntities.SaveChanges();
            XtraMessageBox.Show("Personel Silme İşlemi Başarıyla Tamamlanmıştır","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            List();
        }
    }
}
