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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        galleryEntities1 kullanici = new galleryEntities1();


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string KA_ = txtka.Text;
            string KA_2 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var sil = kullanici.kullanicilarr.Where(w => w.k_adi == KA_).FirstOrDefault();
            kullanici.kullanicilarr.Remove(sil);
            kullanici.SaveChanges();
            MessageBox.Show("İŞLEM BAŞARILI");
            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
            dataGridView1.DataSource = kullanici.kullanicilarr.ToList();
            txtka.Clear();
            txtad.Clear();
            txtt.Clear();
            txtm.Clear();
            txts.Clear();
            txtr.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kullanici.kullanicilarr.ToList();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            kullanicilarr ekle = new kullanicilarr();
            ekle.k_adi = txtka.Text;
            ekle.ad_soyad = txtad.Text;
            ekle.telefon = txtt.Text;
            ekle.mail = txtm.Text;
            ekle.sifre = txts.Text;
            ekle.rol = txtr.Text;
            kullanici.kullanicilarr.Add(ekle);
            kullanici.SaveChanges();
            MessageBox.Show("İŞLEM BAŞARILI");
            foreach(Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
            dataGridView1.DataSource = kullanici.kullanicilarr.ToList();
            txtka.Clear();
            txtad.Clear();
            txtt.Clear();
            txtm.Clear();
            txts.Clear();
            txtr.Clear();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string KA_ = txtka.Text;
            var güncelle = kullanici.kullanicilarr.Where(w => w.k_adi == KA_).FirstOrDefault();
            güncelle.k_adi = txtka.Text;
            güncelle.ad_soyad = txtad.Text;
            güncelle.telefon = txtt.Text;
            güncelle.mail = txtm.Text;
            güncelle.sifre = txts.Text;
            güncelle.rol = txtr.Text;
            kullanici.SaveChanges();
            MessageBox.Show("İŞLEM BAŞARILI");
            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
            dataGridView1.DataSource = kullanici.kullanicilarr.ToList();
            txtka.Clear();
            txtad.Clear();
            txtt.Clear();
            txtm.Clear();
            txts.Clear();
            txtr.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
