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
using Otomasyon_V0.Forms.FrmCompanies;

namespace Otomasyon_V0.Forms
{
    public partial class FrmCompaniesList : Form
    {
        public FrmCompaniesList()
        {
            InitializeComponent();
            List();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        void List()
        {
            grdControlCompaniesList.DataSource = (from x in isTakipOtomasyonEntities.TblFirma
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.Ad,
                                                      x.Telefon,
                                                      x.Mail,
                                                      x.Alan,
                                                      x.Yetkili,
                                                      x.İl,
                                                      x.İlce,
                                                      x.Adres
                                                  }).ToList();
        }

        private void BtnCompanieAdd_Click(object sender, EventArgs e)
        {
            FrmCompanieAdd frmCompanieAdd = new FrmCompanieAdd();
            frmCompanieAdd.Show();
        }

        private void BtnCompanieUpdate_Click(object sender, EventArgs e)
        {
            FrmCompanieUpdate frmCompanieUpdate = new FrmCompanieUpdate();
            frmCompanieUpdate.Show();
        }

        private void BtnCompanieList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void BtnCompanieDelet_Click(object sender, EventArgs e)
        {
            int find = int.Parse(TxtID.Text);
            var value = isTakipOtomasyonEntities.TblFirma.Find(find);
            isTakipOtomasyonEntities.TblFirma.Remove(value);
            isTakipOtomasyonEntities.SaveChanges();
            List();
            XtraMessageBox.Show("Seçilen Firma Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }

        
    }
}
