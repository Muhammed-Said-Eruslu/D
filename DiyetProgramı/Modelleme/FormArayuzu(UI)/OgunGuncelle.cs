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
using WinFormsApp1;

namespace FormArayuzu_UI_
{
    public partial class OgunGuncelle : Form
    {
        private Ogun selectedOgun;

        public Kullanici kullanici;
        readonly OgunRepo ogunRepo;
        Ogun ogun;
        KaloriTakipDbContext db;
        readonly YemekRepo yemekRepo;
        KategoriRepo katRepo;
        public OgunGuncelle()
        {
            InitializeComponent();
            db = new KaloriTakipDbContext();
            ogunRepo = new OgunRepo();
            yemekRepo = new YemekRepo();
            katRepo = new KategoriRepo();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void OgunGuncelle_Load(object sender, EventArgs e)
        {
            #region TODO
            // sayfa açıldığında dgvOgunlere kullanıcının öğünleri gelecek
            //kullanıcı dgvOgunlerden bir satırı seçecek
            //seçtiği satırdaki öğünün yemekleri dgvYemekler'e gelecek
            //kullanıcı buradan bir satır seçtiğinde o yemeğin adı comboboxyemeklere (selecteditem üzerinden), kategorisi de cmbkategorilere, adeti de numerice gelecek. kullanıcı değişkliklerini yapıp  güncelleye bastığında;
            //yeni bilgiler ilgili öğünde değiştirilecek,
            // güncelelnme tarihi her zaman datetimenow olacak
            //öğün newlenmeyecek!!!
            //yemek newlenmeyecek!!!
            //öğünyemek newlenmeyecek!!!!

            //ZATEN OLAN ÖĞÜN İLE İŞLEM YAPILACAK!!!!!!!!!
            #endregion

            var ogunler = db.Ogunler.Where(o => o.KullaniciId == kullanici.KullaniciId).ToList();
            var filteredOgunler = ogunler.Where(o => o.Tarih.Year == DateTime.Now.Year).ToList();

            lsbOgunler.DataSource = filteredOgunler;
            lsbOgunler.DisplayMember = "Tarih";
        }

        private void lsbOgunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOgun = lsbOgunler.SelectedItem as Ogun;
            //ogun = selectedOgun;

            if (selectedOgun != null)
            {
                // Öğüne ait yemekleri ve miktarlarını veritabanından alıyoruz
                var yemekler = (from oy in db.OgunYemekler
                                join y in db.Yemekler on oy.YemekId equals y.YemekId
                                where oy.OgunId == selectedOgun.OgunId && oy.Ogun.AktifMi && y.AktifMi
                                select new
                                {
                                    y.YemekId,
                                    y.YemekAdi,
                                    KategoriAdi = y.Kategori.KategoriAdi,
                                    Miktar = oy.Miktar
                                }).ToList();

                // DataGridView'ı temizlemeden yeni yemekleri ekliyoruz
                dgvYemekleri.DataSource = yemekler;


                dgvYemekleri.Columns["YemekId"].Visible = false;
                dgvYemekleri.Columns["KategoriAdi"].HeaderText = "Kategori";
                dgvYemekleri.Columns["YemekAdi"].HeaderText = "Yemek Adı";
                dgvYemekleri.Columns["Miktar"].HeaderText = "Miktar";
            }
        }

        private void dgvYemekleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                cmbKategoriler.DataSource = katRepo.ButunAktifleriGetir();
                cmbKategoriler.DisplayMember = "KategoriAdi";
                cmbKategoriler.ValueMember = "KategoriId";

                if (e.RowIndex >= 0)
                {
                    // Seçilen satırı alıyoruz
                    var selectedRow = dgvYemekleri.Rows[e.RowIndex];

                    // Yemeği alıyoruz
                    int yemekId = (int)selectedRow.Cells["YemekId"].Value;

                    // Yemek tablosundan kategori bilgisini alıyoruz
                    var yemek = db.Yemekler.FirstOrDefault(y => y.YemekId == yemekId);
                    if (yemek != null)
                    {

                        cmbYemekler.SelectedValue = yemek.YemekId;
                        cmbKategoriler.SelectedValue = yemek.KategoriId;
                    }

                    // Miktarı NumericUpDown'a aktarıyoruz
                    numAdet.Value = (decimal)(double)selectedRow.Cells["Miktar"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seçim yaparken hata oluştu: " + ex.Message);
            }
            #region
            //try
            //{
            //    cmbKategoriler.DataSource = katRepo.ButunAktifleriGetir();
            //    cmbKategoriler.DisplayMember = "KategoriAdi";
            //    cmbKategoriler.ValueMember = "KategoriId";
            //    if (e.RowIndex >= 0)
            //    {
            //        // Seçilen satırı alıyoruz
            //        var selectedRow = dgvYemekleri.Rows[e.RowIndex];

            //        // ComboBox ve NumericUpDown'a bu verileri aktarıyoruz
            //        cmbYemekler.SelectedValue = selectedRow.Cells["YemekId"].Value;  // Yemek ID'si ile seçimi yapıyoruz
            //        cmbKategoriler.SelectedValue = selectedRow.Cells["KategoriId"].Value; // Kategori ComboBox'ta
            //        numAdet.Value = (decimal)selectedRow.Cells["Miktar"].Value;  // Miktar NumericUpDown'da
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Seçim yaparken hata oluştu: " + ex.Message);
            //}
            #endregion
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var secilenKategori = (Kategori)cmbKategoriler.SelectedItem;
                if (secilenKategori != null)
                {
                    var filtrelenenYemekler = db.Yemekler
                        .Where(y => y.Kategori == secilenKategori)
                        .ToList();

                    cmbYemekler.DataSource = filtrelenenYemekler;
                    cmbYemekler.DisplayMember = "YemekAdi";
                    cmbYemekler.ValueMember = "YemekId";
                }
                else
                {
                    MessageBox.Show("Kategori bulunamadı.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kategori seçimi hatalı.");
            }
        }

        private void DGVYemekleriDoldur()
        {
            dgvYemekleri.DataSource = (from oy in db.OgunYemekler
                                       join y in db.Yemekler on oy.YemekId equals y.YemekId
                                       where oy.OgunId == selectedOgun.OgunId && oy.Ogun.AktifMi && y.AktifMi
                                       select new
                                       {
                                           y.YemekId,
                                           y.YemekAdi,
                                           KategoriAdi = y.Kategori.KategoriAdi,
                                           Miktar = oy.Miktar
                                       }).ToList();

            dgvYemekleri.Columns["YemekId"].Visible = false;
            dgvYemekleri.Columns["KategoriAdi"].HeaderText = "Kategori";
            dgvYemekleri.Columns["YemekAdi"].HeaderText = "Yemek Adı";
            dgvYemekleri.Columns["Miktar"].HeaderText = "Miktar";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {


            if (dgvYemekleri.SelectedRows.Count > 0)
            {
                var selectedRow = dgvYemekleri.SelectedRows[0];

                var yeniYemekId = (int)cmbYemekler.SelectedValue;
                var yeniKategoriId = (int)cmbKategoriler.SelectedValue;
                var yeniMiktar = (double)numAdet.Value;

                // Veritabanında ilgili öğün ve yemek güncelleniyor
                var yemekAdet = db.OgunYemekler
                                  .FirstOrDefault(oy => oy.OgunId == selectedOgun.OgunId && oy.YemekId == yeniYemekId);

                if (yemekAdet != null)
                {
                    yemekAdet.Miktar = yeniMiktar;  // Miktar bilgisi güncelleniyor
                }

                // Yemek objesi bulunuyor
                var yemek = db.Yemekler.FirstOrDefault(y => y.YemekId == yeniYemekId);
                if (yemek != null)
                {
                    var kategori = db.Kategoriler.FirstOrDefault(k => k.KategoriId == yeniKategoriId);
                    if (kategori != null)
                    {
                        yemek.Kategori = kategori;  // Yemek ile kategori ilişkilendiriliyor
                    }
                }

                // Değişiklikler veritabanına kaydediliyor
                db.SaveChanges();
                MessageBox.Show("Güncelleme Başarılı");

                // DataGridView'ı tekrar güncelliyoruz
                DGVYemekleriDoldur();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Seçilen öğe alınır
            var selectedOgun = lsbOgunler.SelectedItem as Ogun;
            var selectedYemek = dgvYemekleri.SelectedRows[0];

            int yemekId = (int)selectedYemek.Cells["YemekId"].Value;  // Seçilen yemeğin ID'si

            // Veritabanında ilgili öğe bulunur
            var ogunYemek = db.OgunYemekler
                .FirstOrDefault(oy => oy.OgunId == selectedOgun.OgunId && oy.YemekId == yemekId);

            if (ogunYemek != null)
            {
                // Aktiflik durumu false yapılıyor (silme işlemi)
                ogunYemek.AktifMi = false;

                // Ayrıca yemek ve öğün üzerindeki aktiflik durumu da kontrol edilebilir.
                var yemek = db.Yemekler.FirstOrDefault(y => y.YemekId == yemekId);
                if (yemek != null)
                {
                    yemek.AktifMi = false;  // Yemeğin aktifliğini de false yapabilirsin
                }

                // Değişiklikler kaydedilir
                db.SaveChanges();
                MessageBox.Show("Öğün silindi.");

                // Güncel veriler tekrar yüklenir
                DGVYemekleriDoldur();
            }
            else
            {
                MessageBox.Show("Seçilen öğe bulunamadı.");
            }
        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            // Seçilen öğe alınır
            var selectedOgun = lsbOgunler.SelectedItem as Ogun;

            if (selectedOgun != null)
            {
                // Öğünü pasif hale getiriyoruz
                selectedOgun.AktifMi = false;  // Öğün aktiflik durumu false yapılır

                // Öğüne bağlı tüm yemeklerin aktifliğini false yapalım
                var ogunYemekler = db.OgunYemekler.Where(oy => oy.OgunId == selectedOgun.OgunId).ToList();
                foreach (var ogunYemek in ogunYemekler)
                {
                    ogunYemek.AktifMi = false;  // Öğünle ilişkilendirilmiş tüm yemekleri pasif yapıyoruz
                }

                // Değişiklikler kaydedilir
                db.SaveChanges();

                MessageBox.Show("Öğün ve ilgili yemekler silindi.");

                // Listbox'ı güncelle
                lsbOgunler.DataSource = db.Ogunler.Where(o => o.KullaniciId == kullanici.KullaniciId && o.AktifMi).ToList();
                lsbOgunler.DisplayMember = "Tarih";

                // Eğer listbox'tan silinen öğe seçiliyse, onu temizle
                if (lsbOgunler.SelectedItems.Count > 0)
                {
                    lsbOgunler.SelectedIndex = -1;  // Seçili öğeyi temizle
                }

                // Eğer listbox'ta başka bir öğe varsa, o öğeyi seçili hale getirebiliriz
                if (lsbOgunler.Items.Count > 0)
                {
                    lsbOgunler.SelectedIndex = 0; // İlk öğeyi seç
                }

                // DGV'yi temizlemek yerine, sadece öğün silindikten sonra tekrar doldurmak için sadece listbox seçim yapılmalı
                dgvYemekleri.DataSource = null;
            }
            else
            {
                MessageBox.Show("Silinecek öğe bulunamadı.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}



