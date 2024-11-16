namespace FormArayuzu_UI_
{
    partial class OgunGuncelle
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
            cmbKategoriler = new ComboBox();
            cmbYemekler = new ComboBox();
            label1 = new Label();
            lbl = new Label();
            dgvYemekleri = new DataGridView();
            numAdet = new NumericUpDown();
            LB = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnOgunSil = new Button();
            panel1 = new Panel();
            button1 = new Button();
            lsbOgunler = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvYemekleri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(69, 102);
            cmbKategoriler.Margin = new Padding(3, 2, 3, 2);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(133, 23);
            cmbKategoriler.TabIndex = 2;
            cmbKategoriler.SelectedIndexChanged += cmbKategoriler_SelectedIndexChanged;
            // 
            // cmbYemekler
            // 
            cmbYemekler.FormattingEnabled = true;
            cmbYemekler.Location = new Point(69, 144);
            cmbYemekler.Margin = new Padding(3, 2, 3, 2);
            cmbYemekler.Name = "cmbYemekler";
            cmbYemekler.Size = new Size(133, 23);
            cmbYemekler.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(13, 106);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 4;
            label1.Text = "kategori";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Location = new Point(13, 152);
            lbl.Name = "lbl";
            lbl.Size = new Size(42, 15);
            lbl.TabIndex = 5;
            lbl.Text = "Yemek";
            // 
            // dgvYemekleri
            // 
            dgvYemekleri.BackgroundColor = Color.AntiqueWhite;
            dgvYemekleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekleri.Dock = DockStyle.Bottom;
            dgvYemekleri.Location = new Point(0, 626);
            dgvYemekleri.Margin = new Padding(3, 2, 3, 2);
            dgvYemekleri.Name = "dgvYemekleri";
            dgvYemekleri.RowHeadersWidth = 51;
            dgvYemekleri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYemekleri.Size = new Size(1130, 149);
            dgvYemekleri.TabIndex = 6;
            dgvYemekleri.CellClick += dgvYemekleri_CellClick;
            // 
            // numAdet
            // 
            numAdet.Location = new Point(71, 194);
            numAdet.Margin = new Padding(3, 2, 3, 2);
            numAdet.Name = "numAdet";
            numAdet.Size = new Size(131, 23);
            numAdet.TabIndex = 7;
            // 
            // LB
            // 
            LB.AutoSize = true;
            LB.BackColor = Color.Transparent;
            LB.Location = new Point(12, 196);
            LB.Name = "LB";
            LB.Size = new Size(32, 15);
            LB.TabIndex = 8;
            LB.Text = "Adet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(962, 49);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Öğünlerin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(13, 60);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 10;
            label3.Text = "Seçilen Öğünün Yemekleri";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Transparent;
            btnGuncelle.Location = new Point(784, 564);
            btnGuncelle.Margin = new Padding(3, 2, 3, 2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(172, 58);
            btnGuncelle.TabIndex = 12;
            btnGuncelle.Text = "Öğünü Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(614, 564);
            btnSil.Margin = new Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(151, 58);
            btnSil.TabIndex = 13;
            btnSil.Text = "Seçilen Yemeği Öğünden Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnOgunSil
            // 
            btnOgunSil.Location = new Point(428, 564);
            btnOgunSil.Margin = new Padding(3, 2, 3, 2);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(160, 58);
            btnOgunSil.TabIndex = 14;
            btnOgunSil.Text = "Seçili Öğünü Sil";
            btnOgunSil.UseVisualStyleBackColor = true;
            btnOgunSil.Click += btnOgunSil_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 46);
            panel1.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Transparent;
            button1.Image = Properties.Resources.power_off_icon_1951272;
            button1.Location = new Point(1055, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 46);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lsbOgunler
            // 
            lsbOgunler.ForeColor = Color.Transparent;
            lsbOgunler.FormattingEnabled = true;
            lsbOgunler.ItemHeight = 15;
            lsbOgunler.Location = new Point(962, 71);
            lsbOgunler.Margin = new Padding(3, 2, 3, 2);
            lsbOgunler.Name = "lsbOgunler";
            lsbOgunler.Size = new Size(168, 559);
            lsbOgunler.TabIndex = 11;
            lsbOgunler.SelectedIndexChanged += lsbOgunler_SelectedIndexChanged;
            // 
            // OgunGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.indir__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1130, 775);
            Controls.Add(lsbOgunler);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnOgunSil);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(label2);
            Controls.Add(LB);
            Controls.Add(numAdet);
            Controls.Add(dgvYemekleri);
            Controls.Add(lbl);
            Controls.Add(label1);
            Controls.Add(cmbYemekler);
            Controls.Add(cmbKategoriler);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "OgunGuncelle";
            Text = "OgunGuncelle";
            Load += OgunGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvYemekleri).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbKategoriler;
        private ComboBox cmbYemekler;
        private Label label1;
        private Label lbl;
        private DataGridView dgvYemekleri;
        private NumericUpDown numAdet;
        private Label LB;
        private Label label2;
        private Label label3;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnOgunSil;
        private Panel panel1;
        private Button button1;
        private ListBox lsbOgunler;
    }
}