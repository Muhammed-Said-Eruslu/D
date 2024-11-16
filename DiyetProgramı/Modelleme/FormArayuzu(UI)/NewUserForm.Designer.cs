namespace AraaProje
{
    partial class NewUserForm
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
            panel2 = new Panel();
            lblBilgi = new Label();
            chbShowPassword = new CheckBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            linkAlreadyAcoount = new LinkLabel();
            pictureBox5 = new PictureBox();
            btnRegister = new Button();
            txtSifre = new TextBox();
            label5 = new Label();
            txtYenidenSifre = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            btnClose = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(lblBilgi);
            panel2.Controls.Add(chbShowPassword);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(linkAlreadyAcoount);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(txtSifre);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtYenidenSifre);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 718);
            panel2.TabIndex = 19;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.Location = new Point(162, 318);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(0, 15);
            lblBilgi.TabIndex = 12;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Font = new Font("Microsoft Sans Serif", 12F);
            chbShowPassword.Location = new Point(141, 370);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(124, 24);
            chbShowPassword.TabIndex = 5;
            chbShowPassword.Text = "Şifreyi Göster";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = FormArayuzu_UI_.Properties.Resources.not_visible_interface_symbol_of_an_eye_with_a_slash_on_it_icon_icons_com_57783;
            pictureBox4.Location = new Point(92, 365);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(162, 50);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 3;
            label3.Text = "E-Mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(89, 90);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Lütfen Emailinizi Giriniz";
            txtEmail.Size = new Size(240, 35);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(149, 141);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Şifre";
            // 
            // linkAlreadyAcoount
            // 
            linkAlreadyAcoount.AutoSize = true;
            linkAlreadyAcoount.Font = new Font("Microsoft Sans Serif", 12F);
            linkAlreadyAcoount.LinkColor = Color.FromArgb(128, 255, 255);
            linkAlreadyAcoount.Location = new Point(101, 563);
            linkAlreadyAcoount.Name = "linkAlreadyAcoount";
            linkAlreadyAcoount.Size = new Size(172, 20);
            linkAlreadyAcoount.TabIndex = 14;
            linkAlreadyAcoount.TabStop = true;
            linkAlreadyAcoount.Text = "Zaten Hesabın Var Mı?";
            linkAlreadyAcoount.LinkClicked += linkAlreadyAcoount_LinkClicked;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = FormArayuzu_UI_.Properties.Resources.preferencesdesktopuserpassword_94510;
            pictureBox5.Location = new Point(51, 258);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.FlatAppearance.BorderColor = Color.White;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.Red;
            btnRegister.Font = new Font("Microsoft Sans Serif", 12F);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(101, 481);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(187, 41);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnKayıt_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(89, 176);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.PlaceholderText = "Lütfen Şifreyi Giriniz";
            txtSifre.Size = new Size(240, 35);
            txtSifre.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(117, 223);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 3;
            label5.Text = "Şifreyi Tekrar Gir";
            // 
            // txtYenidenSifre
            // 
            txtYenidenSifre.Location = new Point(89, 258);
            txtYenidenSifre.Multiline = true;
            txtYenidenSifre.Name = "txtYenidenSifre";
            txtYenidenSifre.PasswordChar = '*';
            txtYenidenSifre.PlaceholderText = "Şifreyi Tekrar Giriniz";
            txtYenidenSifre.Size = new Size(240, 35);
            txtYenidenSifre.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = FormArayuzu_UI_.Properties.Resources.preferencesdesktopuserpassword_94510;
            pictureBox2.Location = new Point(51, 176);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = FormArayuzu_UI_.Properties.Resources._4105936_email_envelope_mail_message_snail_mail_1139381;
            pictureBox1.Location = new Point(51, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Cross;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = FormArayuzu_UI_.Properties.Resources.newback;
            pictureBox3.Location = new Point(0, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1182, 815);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 41);
            panel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.Image = FormArayuzu_UI_.Properties.Resources.cancel_close_delete_exit_logout_remove_x_icon_123217;
            button1.Location = new Point(1114, 6);
            button1.Name = "button1";
            button1.Size = new Size(56, 29);
            button1.TabIndex = 11;
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
            btnClose.BackColor = Color.Orange;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Orange;
            btnClose.Location = new Point(1136, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 41);
            btnClose.TabIndex = 10;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 856);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewUserForm";
            Text = "RegisterScreen";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private CheckBox chbShowPassword;
        private PictureBox pictureBox4;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private PictureBox pictureBox5;
        private TextBox txtSifre;
        private Label label5;
        private TextBox txtYenidenSifre;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private LinkLabel linkAlreadyAcoount;
        private Button btnRegister;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label2;
        private Button btnClose;
        private Label lblBilgi;
        private Button button1;
    }
}