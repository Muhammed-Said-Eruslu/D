namespace FormArayuzu_UI_
{
    partial class BenimOgunEklem
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
            components = new System.ComponentModel.Container();
            label3 = new Label();
            numAdet = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            cmbYemekler = new ComboBox();
            cmbKategoriler = new ComboBox();
            dgvYemekler = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblHosgeldin = new Label();
            lblToplamKalori = new Label();
            btnKaydet = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            SaatYılAyGün = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)numAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Sienna;
            label3.Location = new Point(22, 312);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 14;
            label3.Text = "Adet";
            // 
            // numAdet
            // 
            numAdet.BackColor = Color.SaddleBrown;
            numAdet.Location = new Point(81, 310);
            numAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAdet.Name = "numAdet";
            numAdet.Size = new Size(133, 23);
            numAdet.TabIndex = 13;
            numAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Sienna;
            label2.Location = new Point(18, 192);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 12;
            label2.Text = "Yemek:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SaddleBrown;
            label1.Location = new Point(12, 145);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 11;
            label1.Text = "Kategori";
            // 
            // cmbYemekler
            // 
            cmbYemekler.BackColor = Color.SaddleBrown;
            cmbYemekler.FormattingEnabled = true;
            cmbYemekler.Location = new Point(81, 189);
            cmbYemekler.Margin = new Padding(3, 2, 3, 2);
            cmbYemekler.Name = "cmbYemekler";
            cmbYemekler.Size = new Size(133, 23);
            cmbYemekler.TabIndex = 10;
            cmbYemekler.SelectedIndexChanged += cmbYemekler_SelectedIndexChanged;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.BackColor = Color.SaddleBrown;
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(81, 142);
            cmbKategoriler.Margin = new Padding(3, 2, 3, 2);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(133, 23);
            cmbKategoriler.TabIndex = 9;
            cmbKategoriler.SelectedIndexChanged += cmbKategoriler_SelectedIndexChanged;
            // 
            // dgvYemekler
            // 
            dgvYemekler.BackgroundColor = Color.Sienna;
            dgvYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekler.Dock = DockStyle.Bottom;
            dgvYemekler.Location = new Point(0, 476);
            dgvYemekler.Margin = new Padding(3, 2, 3, 2);
            dgvYemekler.Name = "dgvYemekler";
            dgvYemekler.RowHeadersWidth = 51;
            dgvYemekler.Size = new Size(809, 290);
            dgvYemekler.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 64, 0);
            button1.Location = new Point(463, 450);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 16;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 64, 0);
            button2.Location = new Point(551, 450);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 17;
            button2.Text = "Düzenle";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 64, 0);
            button3.Location = new Point(639, 450);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 18;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            // 
            // lblHosgeldin
            // 
            lblHosgeldin.AutoSize = true;
            lblHosgeldin.BackColor = Color.Sienna;
            lblHosgeldin.Location = new Point(0, 53);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.Size = new Size(38, 15);
            lblHosgeldin.TabIndex = 19;
            lblHosgeldin.Text = "label4";
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.BackColor = Color.Sienna;
            lblToplamKalori.Location = new Point(133, 361);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(38, 15);
            lblToplamKalori.TabIndex = 20;
            lblToplamKalori.Text = "label5";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(192, 64, 0);
            btnKaydet.ForeColor = Color.Black;
            btnKaydet.Location = new Point(727, 450);
            btnKaydet.Margin = new Padding(3, 2, 3, 2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(82, 22);
            btnKaydet.TabIndex = 21;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.ActiveCaption;
            dateTimePicker1.CalendarTitleForeColor = Color.Sienna;
            dateTimePicker1.Location = new Point(81, 243);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(133, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Sienna;
            label5.Location = new Point(12, 251);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 23;
            label5.Text = "TARİHİ";
            // 
            // SaatYılAyGün
            // 
            SaatYılAyGün.Interval = 1000;
            SaatYılAyGün.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 50);
            panel1.TabIndex = 25;
            // 
            // button4
            // 
            button4.BackColor = Color.SaddleBrown;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.ForeColor = Color.Transparent;
            button4.Image = Properties.Resources.power_off_icon_1951271;
            button4.Location = new Point(734, 0);
            button4.Name = "button4";
            button4.Size = new Size(75, 52);
            button4.TabIndex = 26;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // BenimOgunEklem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.pngtree_cartoon_food_feast_promotion_advertising_background_image_941049;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 766);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnKaydet);
            Controls.Add(lblToplamKalori);
            Controls.Add(lblHosgeldin);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvYemekler);
            Controls.Add(label3);
            Controls.Add(numAdet);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbYemekler);
            Controls.Add(cmbKategoriler);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "BenimOgunEklem";
            Text = "BenimOgunEklem";
            Load += BenimOgunEklem_Load;
            ((System.ComponentModel.ISupportInitialize)numAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        public NumericUpDown numAdet;
        private Label label2;
        private Label label1;
        private ComboBox cmbYemekler;
        private ComboBox cmbKategoriler;
        private DataGridView dgvYemekler;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblHosgeldin;
        private Label lblToplamKalori;
        private Button btnKaydet;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private System.Windows.Forms.Timer SaatYılAyGün;
        private Panel panel1;
        private Button button4;
    }
}