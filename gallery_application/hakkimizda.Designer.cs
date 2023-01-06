
namespace gallery_application
{
    partial class hakkimizda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hakkimizda));
            this.ımageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageSlider1
            // 
            this.ımageSlider1.AnimationTime = 1200;
            this.ımageSlider1.CurrentImageIndex = 0;
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images1"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images2"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images3"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images4"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images5"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images6"))));
            this.ımageSlider1.Location = new System.Drawing.Point(129, 74);
            this.ımageSlider1.Name = "ımageSlider1";
            this.ımageSlider1.Size = new System.Drawing.Size(282, 197);
            this.ımageSlider1.TabIndex = 4;
            this.ımageSlider1.Text = "ımageSlider1";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(129, 40);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(288, 13);
            this.hyperlinkLabelControl1.TabIndex = 5;
            this.hyperlinkLabelControl1.Text = "https://github.com/iremnurmemiler/C--ile-fotograf-arsivleme";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // hakkimizda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 344);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.ımageSlider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hakkimizda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hakkimizda";
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
    }
}