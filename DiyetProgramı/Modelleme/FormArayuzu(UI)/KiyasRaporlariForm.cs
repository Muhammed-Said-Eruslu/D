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

namespace FormArayuzu_UI_
{
    public partial class KiyasRaporlariForm : Form
    {
        public Kullanici kullanici;
        KaloriTakipDbContext db;
        public KiyasRaporlariForm()
        {
            InitializeComponent();
            db = new KaloriTakipDbContext();
        }


        private void KiyasRaporlariForm_Load(object sender, EventArgs e)
        {

        }

        public void btnHafta_Click(object sender, EventArgs e)
        {
            var son1HaftaTarihi = DateTime.Now.AddDays(-7);

            dgvRapor.DataSource = db.Ogunler
                .Where(o => o.Tarih >= son1HaftaTarihi)
                .GroupBy(o => o.KullaniciId)
                .Select(g => new
                {
                    KullaniciEmail = g.FirstOrDefault().Kullanici.Email,
                    OgunSayisi = g.Count(),
                    ToplamKalori = g.SelectMany(o => o.Yemekleri)
                                    .Where(oy => oy.Yemek.AktifMi)
                                    .Sum(oy => oy.Yemek.Kalori * oy.Miktar)
                })
                .OrderByDescending(x => x.ToplamKalori)
           .ToList();
        }

        private void btnAy_Click(object sender, EventArgs e)
        {
            var son1AyTarihi = DateTime.Now.AddMonths(-1);

            dgvRapor.DataSource = db.Ogunler
                .Where(o => o.Tarih >= son1AyTarihi)
                .GroupBy(o => o.KullaniciId)
                .Select(g => new
                {
                    KullaniciEmail = g.FirstOrDefault()
                    .Kullanici.Email,
                    OgunSayisi = g.Count(),
                    ToplamKalori = g.SelectMany(o => o.Yemekleri)
                                    .Where(oy => oy.Yemek.AktifMi)
                                    .Sum(oy => oy.Yemek.Kalori * oy.Miktar)  // Toplam kaloriyi hesaplıyoruz
                })
                .OrderByDescending(x => x.ToplamKalori)
            .ToList();
        }

        private void btnHaftalıkKategori_Click(object sender, EventArgs e)
        {
            var son1HaftaTarihi = DateTime.Now.AddDays(-7);

            dgvRapor.DataSource = db.OgunYemekler
                 .Where(oy => oy.Ogun.Tarih >= son1HaftaTarihi)
                 .GroupBy(oy => oy.Yemek.KategoriId)
                 .Select(g => new
                 {
                     KategoriAdi = g.FirstOrDefault().Yemek.Kategori.KategoriAdi,
                     ToplamYemekMiktar = g.Sum(oy => oy.Miktar),
                     ToplamKalori = g.Sum(oy => oy.Yemek.Kalori * oy.Miktar)
                 })
                 .OrderByDescending(x => x.ToplamKalori)
                 .ToList();
        }

        private void btnAylıkKategöri_Click(object sender, EventArgs e)
        {
            var son1AyTarihi = DateTime.Now.AddMonths(-1);

            dgvRapor.DataSource = db.OgunYemekler
                .Where(oy => oy.Ogun.Tarih >= son1AyTarihi)
                .GroupBy(oy => oy.Yemek.KategoriId)
                .Select(g => new
                {
                    KategoriAdi = g.FirstOrDefault().Yemek.Kategori.KategoriAdi,
                    ToplamYemekMiktar = g.Sum(oy => oy.Miktar),
                    ToplamKalori = g.Sum(oy => oy.Yemek.Kalori * oy.Miktar)
                })
                .OrderByDescending(x => x.ToplamKalori)
            .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvRapor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

