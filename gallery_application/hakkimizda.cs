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
    public partial class hakkimizda : Form
    {
        public hakkimizda()
        {
            InitializeComponent();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/iremnurmemiler/C--ile-fotograf-arsivleme");
        }
    }
}
