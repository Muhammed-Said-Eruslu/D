namespace FormArayuzu_UI_
{
    partial class YemekCesidiRaporuForm
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
            dgvTop10Yemekler = new DataGridView();
            lblBirinciYemek = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTop10Yemekler).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTop10Yemekler
            // 
            dgvTop10Yemekler.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvTop10Yemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTop10Yemekler.Location = new Point(-2, 361);
            dgvTop10Yemekler.Margin = new Padding(3, 2, 3, 2);
            dgvTop10Yemekler.Name = "dgvTop10Yemekler";
            dgvTop10Yemekler.RowHeadersWidth = 51;
            dgvTop10Yemekler.Size = new Size(614, 196);
            dgvTop10Yemekler.TabIndex = 0;
            // 
            // lblBirinciYemek
            // 
            lblBirinciYemek.AutoSize = true;
            lblBirinciYemek.BackColor = Color.Transparent;
            lblBirinciYemek.Location = new Point(12, 276);
            lblBirinciYemek.Name = "lblBirinciYemek";
            lblBirinciYemek.Size = new Size(38, 15);
            lblBirinciYemek.TabIndex = 1;
            lblBirinciYemek.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(618, 361);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(200, 186);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 57);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.power_off_icon_1951275;
            button1.Location = new Point(752, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 51);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // YemekCesidiRaporuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.indir__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(830, 556);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblBirinciYemek);
            Controls.Add(dgvTop10Yemekler);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "YemekCesidiRaporuForm";
            Text = "YemekCesidiRaporuForm";
            Load += YemekCesidiRaporuForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTop10Yemekler).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTop10Yemekler;
        private Label lblBirinciYemek;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button button1;
    }
}