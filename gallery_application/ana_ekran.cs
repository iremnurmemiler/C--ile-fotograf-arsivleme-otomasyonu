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
    public partial class ana_ekran : Form
    {
        public ana_ekran()
        {
            InitializeComponent();
        }
        public string kullanicirolu;

        private void ana_ekran_Load(object sender, EventArgs e)
        {
            
            this.Text = kullanicirolu;
          

           
        }

        public void formgetir(Form form)
        {
           
            panelControl1.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterScreen;
            panelControl1.Controls.Add(form);
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tum_galeri tg = new tum_galeri();
            formgetir(tg);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            galeri galleri = new galeri();
            formgetir(galleri);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form1 islemler = new Form1();
            formgetir(islemler);
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            K_giris kg = new K_giris();
            kg.Show();
            this.Hide();
        }
    

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kullanici_gösterim kg = new kullanici_gösterim();
            formgetir(kg);
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            galeri g = new galeri();
            formgetir(g);
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hakkimizda h = new hakkimizda();
            formgetir(h);
        }
    }
}
