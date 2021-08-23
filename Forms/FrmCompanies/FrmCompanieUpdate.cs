using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Otomasyon_V0.DBEntity;
using Otomasyon_V0.Forms;

namespace Otomasyon_V0.Forms.FrmCompanies
{
    public partial class FrmCompanieUpdate : Form
    {
        public FrmCompanieUpdate()
        {
            InitializeComponent();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();
        TblFirma tblFirma = new TblFirma();
        
        private void BtnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCompanieUpdate_Load(object sender, EventArgs e)
        {
            isTakipOtomasyonEntities.TblFirma.Load();
            bindingSource1.DataSource = isTakipOtomasyonEntities.TblFirma.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            isTakipOtomasyonEntities.SaveChanges();
        }
    }
}
