

using Modelleme.Context;
using Modelleme.Model.Entities;
using WinFormsApp1;

namespace AraaProje
{
    public partial class Form1 : Form
    {
        KaloriTakipDbContext db;
        Kullanici kullanici;


        public Form1()
        {
            InitializeComponent();
            db = new KaloriTakipDbContext();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

        
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {




           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = false;
            }
        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var kullanýcýDogrulama = db.Kullanicilar.FirstOrDefault(k => k.Email == txtEmail.Text && k.Password == txtSifre.Text);
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("E-mail Kýsmý Boþ Geçilemez");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Þifre Boþ Geçilemez");
                return;
            }
            if (kullanýcýDogrulama != null) // null gelmedýyse kullanýcýný gýrdýgý veri eþleþmiþ demektir
            {
                MessageBox.Show("Giriþ Baþarýlý Yönlendiriliyorsunuz");
                MainForm mainForm = new MainForm();
                mainForm.kullanici=kullanýcýDogrulama;
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Þifre Veya Kullanýcý Adý Yanlýþ");
                return;
            }
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
            //this.Hide();
        }
    }
}
