using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gallery_application
{
    public partial class galeri : Form
    {
        public galeri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LA73MV0\SQLEXPRESS;Initial Catalog=gallery;Integrated Security=True");
        
       

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txt.Text = openFileDialog1.FileName;
        }

        private void galeri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'galleryDataSet.resimler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.resimlerTableAdapter.Fill(this.galleryDataSet.resimler);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (cb.Text == "" || txt.Text == "")
            {
                MessageBox.Show("EKSİK ALANLARI DOLDURUNUZ");
            }
            else
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into resimler (kategori,resim)values (@p1, @p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", cb.Text);
                komut.Parameters.AddWithValue("@p2", txt.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("KAYIT EKLENDİ");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            cb.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }
    }
}
