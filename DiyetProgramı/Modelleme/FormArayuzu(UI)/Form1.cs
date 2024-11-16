

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

            var kullan�c�Dogrulama = db.Kullanicilar.FirstOrDefault(k => k.Email == txtEmail.Text && k.Password == txtSifre.Text);
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("E-mail K�sm� Bo� Ge�ilemez");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("�ifre Bo� Ge�ilemez");
                return;
            }
            if (kullan�c�Dogrulama != null) // null gelmed�yse kullan�c�n� g�rd�g� veri e�le�mi� demektir
            {
                MessageBox.Show("Giri� Ba�ar�l� Y�nlendiriliyorsunuz");
                MainForm mainForm = new MainForm();
                mainForm.kullanici=kullan�c�Dogrulama;
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("�ifre Veya Kullan�c� Ad� Yanl��");
                return;
            }
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
            //this.Hide();
        }
    }
}
