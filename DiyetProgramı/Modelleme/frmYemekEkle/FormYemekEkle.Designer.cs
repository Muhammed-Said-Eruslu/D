namespace FormArayüzü
{
    partial class FormYemekEkle
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
            label1 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            cmbKategoriler = new ComboBox();
            dgvYemekler = new DataGridView();
            btnEkle = new Button();
            label3 = new Label();
            msktxtKalori = new MaskedTextBox();
            label4 = new Label();
            chbAktif = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 22);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Yemek Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 55);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Yemek Kategorisi:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(164, 19);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(151, 27);
            txtAd.TabIndex = 2;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(164, 52);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(151, 28);
            cmbKategoriler.TabIndex = 3;
            cmbKategoriler.SelectedIndexChanged += this.cmbKategoriler_SelectedIndexChanged_3;
            // 
            // dgvYemekler
            // 
            dgvYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekler.Location = new Point(113, 155);
            dgvYemekler.Name = "dgvYemekler";
            dgvYemekler.RowHeadersWidth = 51;
            dgvYemekler.Size = new Size(638, 283);
            dgvYemekler.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(370, 30);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(207, 70);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 92);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 6;
            label3.Text = "Kalorisi:";
            // 
            // msktxtKalori
            // 
            msktxtKalori.Location = new Point(164, 89);
            msktxtKalori.Mask = "00000";
            msktxtKalori.Name = "msktxtKalori";
            msktxtKalori.Size = new Size(48, 27);
            msktxtKalori.TabIndex = 7;
            msktxtKalori.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 132);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 8;
            label4.Text = "Aktif mi?:";
            // 
            // chbAktif
            // 
            chbAktif.AutoSize = true;
            chbAktif.Location = new Point(164, 128);
            chbAktif.Name = "chbAktif";
            chbAktif.Size = new Size(62, 24);
            chbAktif.TabIndex = 9;
            chbAktif.Text = "Aktif";
            chbAktif.UseVisualStyleBackColor = true;
            // 
            // FormYemekEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chbAktif);
            Controls.Add(label4);
            Controls.Add(msktxtKalori);
            Controls.Add(label3);
            Controls.Add(btnEkle);
            Controls.Add(dgvYemekler);
            Controls.Add(cmbKategoriler);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormYemekEkle";
            Text = "frmYemekEkle";
            Load += frmYemekEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private ComboBox cmbKategoriler;
        private DataGridView dgvYemekler;
        private Button btnEkle;
        private Label label3;
        private MaskedTextBox msktxtKalori;
        private Label label4;
        private CheckBox chbAktif;
    }
}