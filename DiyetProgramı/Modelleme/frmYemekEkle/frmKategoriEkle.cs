using Modelleme.AllRepos;
using Modelleme.Context;
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

namespace frmYemekEkle
{
    public partial class frmKategoriEkle : Form
    {
        readonly KategoriRepo katRepo;
        readonly KaloriTakipDbContext db;
        public frmKategoriEkle()
        {
            InitializeComponent();
            katRepo = new KategoriRepo();
         
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad= txtAd.Text;
            bool aktifMi = ckbAktifMi.Checked;

            Kategori kategori = new Kategori()
            {
                KategoriAdi = ad,
                AktifMi = aktifMi,
            };

            katRepo.Ekle(kategori);

            dgvKategoriler.DataSource = katRepo.ButunAktifleriGetir();

        }
    }
}
