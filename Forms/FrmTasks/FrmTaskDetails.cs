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
using Otomasyon_V0.DBEntity;

namespace Otomasyon_V0.Forms.FrmTasks
{
    public partial class FrmTaskDetails : Form
    {
        public FrmTaskDetails()
        {
            InitializeComponent();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        private void FrmTaskDetails_Load(object sender, EventArgs e)
        {
            isTakipOtomasyonEntities.TblGorevDetay.Load();
            bindingSource1.DataSource = isTakipOtomasyonEntities.TblGorevDetay.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            isTakipOtomasyonEntities.SaveChanges();

        }
    }
}
