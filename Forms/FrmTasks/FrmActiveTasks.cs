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

namespace Otomasyon_V0.Forms.FrmTasks
{
    public partial class FrmActiveTasks : Form
    {
        public FrmActiveTasks()
        {
            InitializeComponent();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();
        DateTime Today =DateTime.Today;

        private void FrmActiveTasks_Load(object sender, EventArgs e)
        {
            grdControlActiveTasks.DataSource = (from x in isTakipOtomasyonEntities.TblGorevDetay
                                    select new
                                    {
                                        x.Aciklama,
                                        x.Tarih,
                                        x.Saat
                                    }).Where(x => x.Tarih < Today).ToList(); 
            
        }
    }
}
