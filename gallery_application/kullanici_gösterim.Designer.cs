
namespace gallery_application
{
    partial class kullanici_gösterim
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanicilarrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.galleryDataSet1 = new gallery_application.galleryDataSet1();
            this.kullanicilarrTableAdapter = new gallery_application.galleryDataSet1TableAdapters.kullanicilarrTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kadiDataGridViewTextBoxColumn,
            this.adsoyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullanicilarrBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(86, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 232);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kadiDataGridViewTextBoxColumn
            // 
            this.kadiDataGridViewTextBoxColumn.DataPropertyName = "k_adi";
            this.kadiDataGridViewTextBoxColumn.HeaderText = "k_adi";
            this.kadiDataGridViewTextBoxColumn.Name = "kadiDataGridViewTextBoxColumn";
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "ad_soyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "ad_soyad";
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // kullanicilarrBindingSource
            // 
            this.kullanicilarrBindingSource.DataMember = "kullanicilarr";
            this.kullanicilarrBindingSource.DataSource = this.galleryDataSet1;
            // 
            // galleryDataSet1
            // 
            this.galleryDataSet1.DataSetName = "galleryDataSet1";
            this.galleryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilarrTableAdapter
            // 
            this.kullanicilarrTableAdapter.ClearBeforeFill = true;
            // 
            // kullanici_gösterim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 370);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kullanici_gösterim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullanici_gösterim";
            this.Load += new System.EventHandler(this.kullanici_gösterim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private galleryDataSet1 galleryDataSet1;
        private System.Windows.Forms.BindingSource kullanicilarrBindingSource;
        private galleryDataSet1TableAdapters.kullanicilarrTableAdapter kullanicilarrTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
    }
}