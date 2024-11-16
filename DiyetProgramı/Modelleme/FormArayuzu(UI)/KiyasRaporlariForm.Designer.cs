namespace FormArayuzu_UI_
{
    partial class KiyasRaporlariForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiyasRaporlariForm));
            btnHafta = new Button();
            btnAy = new Button();
            dgvRapor = new DataGridView();
            btnHaftalıkKategori = new Button();
            btnAylıkKategöri = new Button();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHafta
            // 
            btnHafta.BackColor = SystemColors.Info;
            btnHafta.Location = new Point(952, 325);
            btnHafta.Name = "btnHafta";
            btnHafta.Size = new Size(155, 67);
            btnHafta.TabIndex = 0;
            btnHafta.Text = "Haftalık Öğün Bazlı Rapor";
            btnHafta.UseVisualStyleBackColor = false;
            btnHafta.Click += btnHafta_Click;
            // 
            // btnAy
            // 
            btnAy.BackColor = SystemColors.Info;
            btnAy.Location = new Point(952, 239);
            btnAy.Name = "btnAy";
            btnAy.Size = new Size(155, 67);
            btnAy.TabIndex = 1;
            btnAy.Text = "Aylık Öğün Bazlı Rapor";
            btnAy.UseVisualStyleBackColor = false;
            btnAy.Click += btnAy_Click;
            // 
            // dgvRapor
            // 
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.Dock = DockStyle.Bottom;
            dgvRapor.GridColor = SystemColors.InactiveCaption;
            dgvRapor.Location = new Point(0, 465);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.RowHeadersWidth = 51;
            dgvRapor.Size = new Size(1107, 252);
            dgvRapor.TabIndex = 2;
            dgvRapor.CellContentClick += dgvRapor_CellContentClick;
            // 
            // btnHaftalıkKategori
            // 
            btnHaftalıkKategori.BackColor = SystemColors.Info;
            btnHaftalıkKategori.Location = new Point(952, 75);
            btnHaftalıkKategori.Margin = new Padding(3, 4, 3, 4);
            btnHaftalıkKategori.Name = "btnHaftalıkKategori";
            btnHaftalıkKategori.Size = new Size(155, 67);
            btnHaftalıkKategori.TabIndex = 3;
            btnHaftalıkKategori.Text = "Haftalık Kategöri Bazlı Rapor";
            btnHaftalıkKategori.UseVisualStyleBackColor = false;
            btnHaftalıkKategori.Click += btnHaftalıkKategori_Click;
            // 
            // btnAylıkKategöri
            // 
            btnAylıkKategöri.BackColor = SystemColors.Info;
            btnAylıkKategöri.Location = new Point(952, 149);
            btnAylıkKategöri.Margin = new Padding(3, 4, 3, 4);
            btnAylıkKategöri.Name = "btnAylıkKategöri";
            btnAylıkKategöri.Size = new Size(155, 67);
            btnAylıkKategöri.TabIndex = 4;
            btnAylıkKategöri.Text = "Aylık Kategöri Bazlı Rapor";
            btnAylıkKategöri.UseVisualStyleBackColor = false;
            btnAylıkKategöri.Click += btnAylıkKategöri_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Dock = DockStyle.Right;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1021, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 67);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 67);
            panel1.TabIndex = 6;
            // 
            // KiyasRaporlariForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.newback1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1107, 717);
            Controls.Add(panel1);
            Controls.Add(btnAylıkKategöri);
            Controls.Add(btnHaftalıkKategori);
            Controls.Add(dgvRapor);
            Controls.Add(btnAy);
            Controls.Add(btnHafta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KiyasRaporlariForm";
            Text = "KiyasRaporlariForm";
            Load += KiyasRaporlariForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnHafta;
        private Button btnAy;
        private DataGridView dgvRapor;
        private Button btnHaftalıkKategori;
        private Button btnAylıkKategöri;
        private Button button1;
        private Panel panel1;
    }
}