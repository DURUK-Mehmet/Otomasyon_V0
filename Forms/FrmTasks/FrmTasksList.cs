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
    public partial class FrmTasksList : Form
    {
        public FrmTasksList()
        {
            InitializeComponent();
            List();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        TblGorev tblGorev = new TblGorev();
        TblGorevDetay tblGorevDetay = new TblGorevDetay();

        void List()
        {
            grdControlTasksList.DataSource = (from x in isTakipOtomasyonEntities.TblGorev
                                              select new
                                              {
                                                  x.Aciklama
                                              }).ToList();
        }

        private void FrmTasksList_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
