namespace FormArayuzu_UI_
{
    partial class GunSonuRaporuForm
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
            dgvRapor = new DataGridView();
            lblToplamKalori = new Label();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRapor
            // 
            dgvRapor.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.Dock = DockStyle.Bottom;
            dgvRapor.Location = new Point(0, 392);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.RowHeadersWidth = 51;
            dgvRapor.Size = new Size(911, 217);
            dgvRapor.TabIndex = 0;
            dgvRapor.CellContentClick += dgvRapor_CellContentClick;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Location = new Point(0, 245);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(50, 20);
            lblToplamKalori.TabIndex = 1;
            lblToplamKalori.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 64);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Dock = DockStyle.Right;
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.power_off_icon_195127;
            button1.Location = new Point(842, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(69, 64);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // GunSonuRaporuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(911, 609);
            Controls.Add(panel1);
            Controls.Add(lblToplamKalori);
            Controls.Add(dgvRapor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GunSonuRaporuForm";
            Text = "GunSonuRaporuForm";
            Load += GunSonuRaporuForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRapor;
        private Label lblToplamKalori;
        private Panel panel1;
        private Button button1;
    }
}