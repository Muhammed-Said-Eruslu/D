namespace frmYemekEkle
{
    partial class frmKategoriEkle
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
            dgvKategoriler = new DataGridView();
            btnEkle = new Button();
            txtAd = new TextBox();
            ckbAktifMi = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).BeginInit();
            SuspendLayout();
            // 
            // dgvKategoriler
            // 
            dgvKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategoriler.Location = new Point(32, 220);
            dgvKategoriler.Name = "dgvKategoriler";
            dgvKategoriler.RowHeadersWidth = 51;
            dgvKategoriler.Size = new Size(601, 218);
            dgvKategoriler.TabIndex = 11;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(152, 134);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(126, 53);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(206, 41);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 9;
            // 
            // ckbAktifMi
            // 
            ckbAktifMi.AutoSize = true;
            ckbAktifMi.Location = new Point(216, 85);
            ckbAktifMi.Name = "ckbAktifMi";
            ckbAktifMi.Size = new Size(62, 24);
            ckbAktifMi.TabIndex = 8;
            ckbAktifMi.Text = "Aktif";
            ckbAktifMi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 86);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 7;
            label2.Text = "Aktif mi?:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 44);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 6;
            label1.Text = "Kategori Adı:";
            // 
            // frmKategoriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 450);
            Controls.Add(dgvKategoriler);
            Controls.Add(btnEkle);
            Controls.Add(txtAd);
            Controls.Add(ckbAktifMi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKategoriEkle";
            Text = "frmKategoriEkle";
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKategoriler;
        private Button btnEkle;
        private TextBox txtAd;
        private CheckBox ckbAktifMi;
        private Label label2;
        private Label label1;
    }
}