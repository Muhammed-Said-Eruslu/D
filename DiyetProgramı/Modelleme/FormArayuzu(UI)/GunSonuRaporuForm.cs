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
    public partial class GunSonuRaporuForm : Form
    {
        public Kullanici kullanici;
        KaloriTakipDbContext db;
        public GunSonuRaporuForm()
        {
            InitializeComponent();
            db = new KaloriTakipDbContext();
        }

        private void GunSonuRaporuForm_Load(object sender, EventArgs e)
        {

            // Kullanıcının aktif öğünlerini alıyoruz
            var ogunler = db.Ogunler
                .Where(o => o.KullaniciId == kullanici.KullaniciId && o.Tarih.Date == DateTime.Now.Date && o.AktifMi)  // Bugün tarihli ve aktif öğünler
                .ToList();

            // Her öğün için yemekleri ve kalorileri alıyoruz (Aktif yemekleri de kontrol ediyoruz)
            var ogunKalorileri = db.OgunYemekler
                .Where(oy => ogunler.Select(o => o.OgunId).Contains(oy.OgunId) && oy.Yemek.AktifMi)  // Yemeklerin de aktif olmasını sağlıyoruz
                .Join(db.Yemekler, oy => oy.YemekId, y => y.YemekId, (oy, y) => new
                {
                    OyuncuYemekId = oy.OgunYemekDetayId,
                    OgunId = oy.OgunId,
                    YemekAdi = y.YemekAdi,
                    KategoriAdi = y.Kategori.KategoriAdi,
                    Kalori = y.Kalori,
                    Miktar = oy.Miktar
                })
                .ToList();

            // Her öğün için toplam kalori hesaplama
            var ogunBazindaKaloriler = ogunKalorileri
                .GroupBy(og => og.OgunId)  // Öğün bazında grupluyoruz
                .Select(g => new//yeni bir kolon açıyor
                {
                    OgunId = g.Key,
                    OgunTarihi = ogunler.First(o => o.OgunId == g.Key).Tarih,
                    ToplamKalori = g.Sum(og => og.Kalori * og.Miktar)  // Her yemeğin kalori * miktarını topluyoruz
                })//gunlük öğün kalorisi
                .ToList();

            // Kullanıcının tüm öğünlerdeki toplam kalori
            double toplamKalori = ogunKalorileri
                .Sum(og => og.Kalori * og.Miktar);


            lblToplamKalori.Text = $"Toplam Kalori: {toplamKalori} kcal";

            // DataGridView'e öğün bazında kalori raporunu dolduralım
            var raporListesi = ogunBazindaKaloriler.Select(og => new
            {
                OgunTarihi = og.OgunTarihi.ToString("dd.MM.yyyy"),
                ToplamKalori = og.ToplamKalori
            }).ToList();

            dgvRapor.DataSource = raporListesi;
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
