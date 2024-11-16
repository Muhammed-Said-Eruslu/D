
using Modelleme.Context;
using Modelleme.Model.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AraaProje
{
    public partial class NewUserForm : Form
    {
        KaloriTakipDbContext db;
        public NewUserForm()
        {
            InitializeComponent();
            db = new KaloriTakipDbContext();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string sifre = txtSifre.Text;



            // Kullanıcı adı kontrolü
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez.");
                return;
            }

            // Şifre kontrolü
            if (string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Şifre boş geçilemez.");
                return;
            }

            // Şifre uyumu kontrolü
            if (txtSifre.Text != txtYenidenSifre.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                return;
            }

            // Şifrenin karmaşıklık kontrolü
            string sifreGuc = CheckPassword(sifre);
            if (sifreGuc == "Düşük")
            {
                MessageBox.Show("Şifrenizin güvenliği düşüktür, lütfen daha güçlü bir şifre girin.");
                return;
            }

            // Kullanıcı varlığı kontrolü
            var kullanıcıZaten = db.Kullanicilar.FirstOrDefault(x => x.Email == email);
            if (kullanıcıZaten != null)
            {
                MessageBox.Show("Bu kullanıcı zaten sistemde mevcut.");
                return;
            }

            // Email formatı kontrolü
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi girin.");
                return;
            }

            // Yeni kullanıcı oluşturma ve veritabanına kaydetme
            try
            {
                Kullanici kullanici = new Kullanici()
                {
                    Email = email,
                    Password = sifre,
                    //DogumTarihi = dogumTarihi,
                    //Kilo = kılo2,
                    //Boy = boy2,
                    //Cinsiyet = cinsiyet
                };

                db.Kullanicilar.Add(kullanici);
                db.SaveChanges();

                MessageBox.Show("Kayıt başarılı.");
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private string CheckPassword(string password)
        {
            if (password.Length <= 6 || password.All(char.IsDigit) || password.All(char.IsLetter))
            {
                lblBilgi.ForeColor = Color.Green;
                return "Düşük";
            }

            if (password.Length == 7 && password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                lblBilgi.ForeColor = Color.Orange;
                return "Orta";
            }

            if (password.Length >= 8 && password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                lblBilgi.ForeColor = Color.Red;
                return "Yüksek";
            }

            if(password.Length>15)
            {
                lblBilgi.ForeColor= Color.Red;
                throw new Exception("Şifre 15 karakterden yüksek olamaz");
                
            }

            return "Düşük";
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            //if(txtSifre.Text.Length >6)
            //{
            //    lblBilgi.Visible = true;
            //    lblBilgi.ForeColor = Color.Red;
            //    lblBilgi.Text = "Düşük";
            //}
            string password = txtSifre.Text;
            lblBilgi.Text = CheckPassword(password);
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool showPassword = chbShowPassword.Checked;
            txtSifre.UseSystemPasswordChar = showPassword;
            txtYenidenSifre.UseSystemPasswordChar = showPassword;
        }

        private void linkAlreadyAcoount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
