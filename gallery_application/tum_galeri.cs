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
    public partial class tum_galeri : Form
    {
        public tum_galeri()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void tum_galeri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'galleryDataSet2.resimler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.resimlerTableAdapter.Fill(this.galleryDataSet2.resimler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;


            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }
    }
}
