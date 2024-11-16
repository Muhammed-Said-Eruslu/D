namespace AraaProje
{
    partial class Form1
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
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            btnClose = new Button();
            pnlLogin = new Panel();
            chbShowPassword = new CheckBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            linkCreateAccount = new LinkLabel();
            btnLogin = new Button();
            txtSifre = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 41);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Image = FormArayuzu_UI_.Properties.Resources.cancel_close_delete_exit_logout_remove_x_icon_123217;
            button1.Location = new Point(786, 6);
            button1.Name = "button1";
            button1.Size = new Size(46, 29);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 1;
            label2.Text = "Diet Tracking Program";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(798, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 41);
            btnClose.TabIndex = 7;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(chbShowPassword);
            pnlLogin.Controls.Add(pictureBox4);
            pnlLogin.Controls.Add(pictureBox2);
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Controls.Add(linkCreateAccount);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtSifre);
            pnlLogin.Controls.Add(label4);
            pnlLogin.Controls.Add(txtEmail);
            pnlLogin.Controls.Add(label3);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Location = new Point(398, 88);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(382, 567);
            pnlLogin.TabIndex = 9;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Font = new Font("Microsoft Sans Serif", 12F);
            chbShowPassword.Location = new Point(142, 321);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(124, 24);
            chbShowPassword.TabIndex = 2;
            chbShowPassword.Text = "Şifreyi Göster";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = FormArayuzu_UI_.Properties.Resources.not_visible_interface_symbol_of_an_eye_with_a_slash_on_it_icon_icons_com_57783;
            pictureBox4.Location = new Point(93, 317);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = FormArayuzu_UI_.Properties.Resources.preferencesdesktopuserpassword_94510;
            pictureBox2.Location = new Point(52, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = FormArayuzu_UI_.Properties.Resources._4105936_email_envelope_mail_message_snail_mail_113938;
            pictureBox1.Location = new Point(52, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // linkCreateAccount
            // 
            linkCreateAccount.AutoSize = true;
            linkCreateAccount.Font = new Font("Microsoft Sans Serif", 12F);
            linkCreateAccount.LinkColor = Color.FromArgb(128, 255, 255);
            linkCreateAccount.Location = new Point(124, 440);
            linkCreateAccount.Name = "linkCreateAccount";
            linkCreateAccount.Size = new Size(111, 20);
            linkCreateAccount.TabIndex = 5;
            linkCreateAccount.TabStop = true;
            linkCreateAccount.Text = "Hesap Oluştur";
            linkCreateAccount.LinkClicked += linkCreateAccount_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Red;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(90, 374);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(187, 41);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(90, 265);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.PlaceholderText = "Lütfen Şifrenizi Giriniz";
            txtSifre.Size = new Size(240, 35);
            txtSifre.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(150, 230);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(90, 179);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Lütfen Emalinizi Giriniz";
            txtEmail.Size = new Size(240, 35);
            txtEmail.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(163, 139);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 3;
            label3.Text = "E-Mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(150, 54);
            label1.Name = "label1";
            label1.Size = new Size(85, 31);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Cross;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = FormArayuzu_UI_.Properties.Resources.hasta_beslenme;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(844, 705);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 705);
            Controls.Add(panel1);
            Controls.Add(pnlLogin);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "LoginScreen";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnClose;
        private Panel pnlLogin;
        private CheckBox chbShowPassword;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private LinkLabel linkCreateAccount;
        private Button btnLogin;
        private TextBox txtSifre;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox3;
        private Button button1;
    }
}
