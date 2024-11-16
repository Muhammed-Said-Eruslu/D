namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblKarsilama = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnOgunekleSil = new Button();
            btnOgunEkle = new Button();
            btnYemekCesidiRaporu = new Button();
            btnGünSonuRaporu = new Button();
            btnHaftalıkRapor = new Button();
            btnHome = new Button();
            panel3 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblKarsilama
            // 
            lblKarsilama.AutoSize = true;
            lblKarsilama.BackColor = Color.Gray;
            lblKarsilama.Location = new Point(19, 8);
            lblKarsilama.Name = "lblKarsilama";
            lblKarsilama.Size = new Size(64, 15);
            lblKarsilama.TabIndex = 1;
            lblKarsilama.Text = "Hoşgeldin!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblKarsilama);
            panel1.Location = new Point(806, 62);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 32);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnOgunekleSil);
            panel2.Controls.Add(btnOgunEkle);
            panel2.Controls.Add(btnYemekCesidiRaporu);
            panel2.Controls.Add(btnGünSonuRaporu);
            panel2.Controls.Add(btnHaftalıkRapor);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 678);
            panel2.TabIndex = 3;
            // 
            // btnOgunekleSil
            // 
            btnOgunekleSil.BackColor = SystemColors.ControlDarkDark;
            btnOgunekleSil.ForeColor = SystemColors.ActiveCaptionText;
            btnOgunekleSil.Image = (Image)resources.GetObject("btnOgunekleSil.Image");
            btnOgunekleSil.Location = new Point(-3, 552);
            btnOgunekleSil.Name = "btnOgunekleSil";
            btnOgunekleSil.Size = new Size(200, 75);
            btnOgunekleSil.TabIndex = 8;
            btnOgunekleSil.Text = "Öğün Güncelle/Sil";
            btnOgunekleSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOgunekleSil.UseVisualStyleBackColor = false;
            btnOgunekleSil.Click += btnOgunekleSil_Click;
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.BackColor = SystemColors.ControlDarkDark;
            btnOgunEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnOgunEkle.Image = (Image)resources.GetObject("btnOgunEkle.Image");
            btnOgunEkle.Location = new Point(-3, 457);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(200, 75);
            btnOgunEkle.TabIndex = 7;
            btnOgunEkle.Text = "Öğün Ekle";
            btnOgunEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOgunEkle.UseVisualStyleBackColor = false;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // btnYemekCesidiRaporu
            // 
            btnYemekCesidiRaporu.BackColor = SystemColors.ControlDarkDark;
            btnYemekCesidiRaporu.ForeColor = SystemColors.ActiveCaptionText;
            btnYemekCesidiRaporu.Image = (Image)resources.GetObject("btnYemekCesidiRaporu.Image");
            btnYemekCesidiRaporu.Location = new Point(-3, 356);
            btnYemekCesidiRaporu.Name = "btnYemekCesidiRaporu";
            btnYemekCesidiRaporu.Size = new Size(200, 75);
            btnYemekCesidiRaporu.TabIndex = 6;
            btnYemekCesidiRaporu.Text = "Yemek Çeşidi Raporu";
            btnYemekCesidiRaporu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnYemekCesidiRaporu.UseVisualStyleBackColor = false;
            btnYemekCesidiRaporu.Click += btnYemekCesidiRaporu_Click;
            // 
            // btnGünSonuRaporu
            // 
            btnGünSonuRaporu.BackColor = SystemColors.ControlDarkDark;
            btnGünSonuRaporu.ForeColor = SystemColors.ActiveCaptionText;
            btnGünSonuRaporu.Image = (Image)resources.GetObject("btnGünSonuRaporu.Image");
            btnGünSonuRaporu.Location = new Point(-3, 259);
            btnGünSonuRaporu.Name = "btnGünSonuRaporu";
            btnGünSonuRaporu.Size = new Size(200, 75);
            btnGünSonuRaporu.TabIndex = 5;
            btnGünSonuRaporu.Text = "Gün Sonu Raporu";
            btnGünSonuRaporu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGünSonuRaporu.UseVisualStyleBackColor = false;
            btnGünSonuRaporu.Click += btnGünSonuRaporu_Click;
            // 
            // btnHaftalıkRapor
            // 
            btnHaftalıkRapor.BackColor = SystemColors.ControlDarkDark;
            btnHaftalıkRapor.Image = (Image)resources.GetObject("btnHaftalıkRapor.Image");
            btnHaftalıkRapor.Location = new Point(-3, 159);
            btnHaftalıkRapor.Name = "btnHaftalıkRapor";
            btnHaftalıkRapor.Size = new Size(200, 75);
            btnHaftalıkRapor.TabIndex = 1;
            btnHaftalıkRapor.Text = "Haftalık Ve Aylık  Rapor";
            btnHaftalıkRapor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHaftalıkRapor.UseVisualStyleBackColor = false;
            btnHaftalıkRapor.Click += btnHaftalıkRapor_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ControlDarkDark;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(0, 62);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 75);
            btnHome.TabIndex = 0;
            btnHome.Text = "ANA SAYFA";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(825, 56);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = FormArayuzu_UI_.Properties.Resources.power_off_icon_1951274;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(773, 0);
            button1.Name = "button1";
            button1.Size = new Size(52, 53);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1025, 678);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblKarsilama;
        private Panel panel1;
        private Panel panel2;
        private Button btnHome;
        private Button btnHaftalıkRapor;
        private Button btnGünSonuRaporu;
        private Button btnYemekCesidiRaporu;
        private Button btnOgunEkle;
        private Button btnOgunekleSil;
        private Panel panel3;
        private Button button1;
    }
}
