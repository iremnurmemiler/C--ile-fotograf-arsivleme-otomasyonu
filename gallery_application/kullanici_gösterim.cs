using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gallery_application
{
    public partial class kullanici_gösterim : Form
    {
        public kullanici_gösterim()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kullanici_gösterim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'galleryDataSet1.kullanicilarr' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanicilarrTableAdapter.Fill(this.galleryDataSet1.kullanicilarr);

        }
    }
}
