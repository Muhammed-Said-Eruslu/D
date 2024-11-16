using AraaProje;
using FormArayuzu_UI_;
using Modelleme.Model.Entities;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public Kullanici kullanici;

        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string kullaniciAdi = kullanici.Email.Substring(0, kullanici.Email.IndexOf('@'));
            lblKarsilama.Text = $"Hoþgeldin! {kullaniciAdi}";
            this.IsMdiContainer = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }


        private void btnHaftalýkRapor_Click(object sender, EventArgs e)
        {
            KiyasRaporlariForm krfrm = new KiyasRaporlariForm();
            krfrm.kullanici = this.kullanici;
            krfrm.ShowDialog();

        }


        private void btnGünSonuRaporu_Click(object sender, EventArgs e)
        {
            GunSonuRaporuForm gsrfrm = new GunSonuRaporuForm();
            gsrfrm.kullanici = this.kullanici;
            gsrfrm.ShowDialog();
        }


        private void btnYemekCesidiRaporu_Click(object sender, EventArgs e)
        {

            YemekCesidiRaporuForm ycrfrm = new YemekCesidiRaporuForm();
            ycrfrm.ShowDialog();
        }


        private void btnOgunekleSil_Click(object sender, EventArgs e)
        {
            OgunGuncelle guncelle = new OgunGuncelle();
            guncelle.kullanici = this.kullanici;
            guncelle.ShowDialog();
        }


        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            BenimOgunEklem benimOgunEklem = new BenimOgunEklem();
            benimOgunEklem.ogunKullanici = this.kullanici;
            benimOgunEklem.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
