
using FormArayüzü;

namespace frmYemekEkle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategoriEkle frmKategoriEkle = new frmKategoriEkle();
            frmKategoriEkle.ShowDialog();

        }

        private void btnYemek_Click(object sender, EventArgs e)
        {
         FormYemekEkle frmYemekEkle= new FormYemekEkle();
            frmYemekEkle.ShowDialog();
        }
    }
}
