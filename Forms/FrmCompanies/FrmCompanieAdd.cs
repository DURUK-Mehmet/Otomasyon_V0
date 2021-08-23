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

namespace Otomasyon_V0.Forms.FrmCompanies
{
    public partial class FrmCompanieAdd : Form
    {
        public FrmCompanieAdd()
        {
            InitializeComponent();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        TblFirma tblFirma = new TblFirma();

        private void BtnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCompanieAdd_Click(object sender, EventArgs e)
        {
            tblFirma.Ad = TxtCompanieName.Text;
            tblFirma.Telefon = TxtCompanieNumber.Text;
            tblFirma.Mail = TxtCompanieMail.Text;
            tblFirma.Alan = TxtCompanieBranch.Text;
            tblFirma.Yetkili = TxtCompanieAuthorized.Text;
            tblFirma.İl = TxtCompanieCity.Text;
            tblFirma.İlce = TxtCompanieDistrict.Text;
            tblFirma.Adres = TxtCompanieAddress.Text;
            isTakipOtomasyonEntities.TblFirma.Add(tblFirma);
            isTakipOtomasyonEntities.SaveChanges();
            XtraMessageBox.Show("Firma Başarıyla Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
