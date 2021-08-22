using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otomasyon_V0.DBEntity;
using Otomasyon_V0.Forms;

namespace Otomasyon_V0.Forms
{
    public partial class FrmCompaniesList : Form
    {
        public FrmCompaniesList()
        {
            InitializeComponent();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        private void FrmCompaniesList_Load(object sender, EventArgs e)
        {
            grdControlCompaniesList.DataSource = (from x in isTakipOtomasyonEntities.TblFirma
                                                  select new
                                                  {
                                                      x.Ad,
                                                      x.Telefon,
                                                      x.Mail,
                                                      x.Alan,
                                                      x.Yetkili
                                                  }).ToList();
        }
    }
}
