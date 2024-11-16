using Modelleme.AllRepos;
using Modelleme.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormArayüzü
{
    public partial class FormYemekEkle : Form
    {
        readonly YemekRepo yemekRepo;
        readonly KategoriRepo kategoriRepo;
        Kategori kategori;
        public FormYemekEkle()
        {
            InitializeComponent();
            yemekRepo = new YemekRepo();
            kategoriRepo = new KategoriRepo();
        }
        private void frmYemekEkle_Load(object sender, EventArgs e)
        {
            dgvYemekler.DataSource = yemekRepo.ButunAktifleriGetir();
            cmbKategoriler.DataSource = kategoriRepo.ButunAktifleriGetir();
            cmbKategoriler.DisplayMember = "KategoriAdi";
            cmbKategoriler.SelectedIndex = -1;
        }

        private void cmbKategoriler_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            kategori = cmbKategoriler.SelectedItem as Kategori;
           
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = txtAd.Text;

                // Kalori değeri kontrolü
                if (!double.TryParse(msktxtKalori.Text, out double kalori))
                {
                    MessageBox.Show("Geçersiz kalori değeri. Lütfen sayısal bir değer giriniz.");
                    return;
                }

                // Kategori seçilmiş mi kontrolü
                if (kategori == null)
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz.");
                    return;
                }

                bool AktifMi = chbAktif.Checked;

                Yemek yemek = new Yemek()
                {
                    YemekAdi = ad,
                    KategoriId= kategori.KategoriId,
                    Kalori = kalori,
                    AktifMi = AktifMi,
                  
                };

                yemekRepo.Ekle(yemek);
                MessageBox.Show("Ekleme başarılı!");
                dgvYemekler.DataSource = yemekRepo.ButunAktifleriGetir();
                kategori = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yemek eklenemedi: " + ex.Message);
            }
            //try
            //{
            //    string ad = txtAd.Text;
            //    double kalori = Double.Parse(msktxtKalori.Text);
            //    bool AktifMi = chbAktif.Checked;

            //    Yemek yemek = new Yemek()
            //    {
            //        YemekAdi = ad,
            //        Kategori = kategori,
            //        Kalori = kalori,
            //        AktifMi = AktifMi,
            //        KategoriId = kategori?.KategoriId ?? 0
            //    };

            //    yemekRepo.Ekle(yemek);
            //    MessageBox.Show("Ekleme başarılı!");
            //    kategori = null;

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Yemek eklenemedi" +  ex.Message);
            //}

        }

       

      
    }
}
