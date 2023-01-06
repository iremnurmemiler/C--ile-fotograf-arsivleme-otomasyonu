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
    public partial class K_giris : Form
    {
        public K_giris()
        {
            InitializeComponent();
        }
        galleryEntities1 db = new galleryEntities1();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var kullanici = db.kullanicilarr.Where(x => x.k_adi == txtka.Text && x.sifre == txts.Text).FirstOrDefault();

            if(kullanici==null)
            {
                MessageBox.Show("KULLANICI BULUNAMADI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ( kullanici!=null)
            {
                ana_ekran ae = new ana_ekran();
                ae.kullanicirolu = kullanici.rol;
                ae.Show();
                this.Hide();
            }
        }
    }
}
