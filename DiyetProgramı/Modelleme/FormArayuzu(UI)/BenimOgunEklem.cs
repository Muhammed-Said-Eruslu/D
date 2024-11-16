using Modelleme.AllRepos;
using Modelleme.Context;
using Modelleme.Model.Entities;

namespace FormArayuzu_UI_
{
    public partial class BenimOgunEklem : Form
    {


        public Kullanici ogunKullanici;

        readonly KategoriRepo katRepo;
        readonly KaloriTakipDbContext db;
        Kategori kategori;
        readonly YemekRepo yemekRepo;
        Yemek yemek;
        Ogun ogun;
        public BenimOgunEklem()
        {
            InitializeComponent();
            katRepo = new KategoriRepo();
            db = new KaloriTakipDbContext();
            yemekRepo = new YemekRepo();
        }

        private void cmbYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BenimOgunEklem_Load(object sender, EventArgs e)
        {


            cmbKategoriler.DataSource = katRepo.ButunAktifleriGetir();
            cmbKategoriler.DisplayMember = "KategoriAdi";


            //SaatYılAyGün.Start();
            lblHosgeldin.Text = "Hoşgeldin" + ogunKullanici.Email;

            dgvYemekler.Columns.Add("YemekAdi", "Yemek Adı");//Yemekadı colum ismi yemek adı colum başlığı
            dgvYemekler.Columns.Add("Miktar", "Miktar");
            dgvYemekler.Columns.Add("Kalori", "Kalori");

            //dgvYemekler.Columns.Add("ToplamKalori", "Toplam Kalori");

        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var secilenKategori = (Kategori)cmbKategoriler.SelectedItem;
                if (secilenKategori == null)
                {
                    MessageBox.Show("Seçilen Kategori bulunamadı");
                }


                var filtrelenenYemekler = db.Yemekler//o kategoriye ait yemekler geliyor  
                                                    .Where(y => y.Kategori == secilenKategori)
                                                    .ToList();
                if (filtrelenenYemekler == null && filtrelenenYemekler.Count == 0)
                {
                    MessageBox.Show("Bu kategorinin yemeği yok...");
                }

                cmbYemekler.DataSource = filtrelenenYemekler;
                cmbYemekler.DisplayMember = "YemekAdi";
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Yemek secilenYemek = (Yemek)cmbYemekler.SelectedItem;


            if (secilenYemek == null)
            {
                MessageBox.Show("Lütfen bir yemek seçin.");
                return;
            }

            if (string.IsNullOrEmpty(numAdet.Text) || !double.TryParse(numAdet.Text, out double miktar))
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.");
                return;
            }


            bool yemekVarMi = dgvYemekler.Rows.Cast<DataGridViewRow>()
                                           .Any(row => row.Cells["YemekAdi"].Value != null &&
                                                       row.Cells["YemekAdi"].Value.ToString() == secilenYemek.YemekAdi);

            if (yemekVarMi)
            {
                MessageBox.Show("Bu yemek zaten eklenmiş. Lütfen farklı bir yemek seçin.");
            }
            else
            {

                dgvYemekler.Rows.Add(secilenYemek.YemekAdi, miktar, secilenYemek.Kalori);

                GuncelleToplamKalori();
            }
        }

        private void GuncelleToplamKalori()
        {
            double toplamKalori = 0;

            foreach (DataGridViewRow row in dgvYemekler.Rows)
            {
                if (row.Cells["Kalori"].Value != null && row.Cells["Miktar"].Value != null)
                {
                    toplamKalori += Convert.ToDouble(row.Cells["Kalori"].Value) * Convert.ToDouble(row.Cells["Miktar"].Value);
                }
            }

            lblToplamKalori.Text = $"Toplam Kalori: {toplamKalori}";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogun yeniOgun = new Ogun
            {
                KullaniciId = ogunKullanici.KullaniciId,
                Tarih = dateTimePicker1.Value,
                Yemekleri = new List<OgunYemek>()
            };

            foreach (DataGridViewRow row in dgvYemekler.Rows)
            {
                if (row.Cells["YemekAdi"].Value != null)
                {
                    string yemekAdi = row.Cells["YemekAdi"].Value.ToString();
                    double miktar = Convert.ToDouble(row.Cells["Miktar"].Value);

                    Yemek yemek = db.Yemekler.FirstOrDefault(y => y.YemekAdi == yemekAdi);

                    if (yemek != null)
                    {
                        OgunYemek ogunYemek = new OgunYemek
                        {
                            YemekId = yemek.YemekId,
                            Miktar = miktar,
                            Ogun = yeniOgun
                        };
                        yeniOgun.Yemekleri.Add(ogunYemek);
                    }
                }
            }

            try
            {
                db.Ogunler.Add(yeniOgun);
                db.SaveChanges();
                MessageBox.Show("Öğün başarıyla kaydedildi!");
                dgvYemekler.Rows.Clear();
                lblToplamKalori.Text = "Toplam Kalori: 0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }






        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Eğer herhangi bir satır seçili değilse, uyarı mesajı verelim
            if (dgvYemekler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz yemeği seçin.");
                return;
            }

            var selectedRow = dgvYemekler.SelectedRows[0];//tek bir tane seçebildiği için index 0 oluyor

            // Yemek bilgilerini al
            Yemek secilenYemek = (Yemek)cmbYemekler.SelectedItem; // Yeni yemek
            double yeniMiktar = Convert.ToDouble(numAdet.Text); // Yeni miktar

            if (secilenYemek != null && !string.IsNullOrEmpty(numAdet.Text))
            {
                // Öncelikle seçili satırdaki yemek bilgisini güncelle
                selectedRow.Cells["YemekAdi"].Value = secilenYemek.YemekAdi; // Yeni yemek adı
                selectedRow.Cells["Miktar"].Value = yeniMiktar; // Yeni miktar
                selectedRow.Cells["Kalori"].Value = secilenYemek.Kalori;
                // Toplam kaloriyi güncelle
                GuncelleToplamKalori();
            }
            else
            {
                MessageBox.Show("Lütfen yemek ve miktar bilgilerini doğru girin.");
            }
        }

        private void dgvYemekler_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvYemekler.SelectedRows.Count > 0)
            {
                var selectedRow = dgvYemekler.SelectedRows[0];
                string yemekAdi = selectedRow.Cells["YemekAdi"].Value.ToString();
                double miktar = Convert.ToDouble(selectedRow.Cells["Miktar"].Value);

                Yemek secilenYemek = db.Yemekler.FirstOrDefault(y => y.YemekAdi == yemekAdi);

                if (secilenYemek != null)
                {

                    cmbKategoriler.SelectedIndexChanged -= cmbKategoriler_SelectedIndexChanged;


                    cmbKategoriler.SelectedItem = secilenYemek.Kategori;


                    cmbKategoriler.SelectedIndexChanged += cmbKategoriler_SelectedIndexChanged;


                    cmbYemekler.DataSource = db.Yemekler.Where(y => y.Kategori == secilenYemek.Kategori).ToList();
                    cmbYemekler.DisplayMember = "YemekAdi";


                    cmbYemekler.SelectedItem = secilenYemek;


                    numAdet.Text = miktar.ToString();


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvYemekler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz yemeği seçin.");
                return;
            }

            var selectedRow = dgvYemekler.SelectedRows[0];
            dgvYemekler.Rows.Remove(selectedRow);

            // Toplam kaloriyi güncelle
            GuncelleToplamKalori();

            MessageBox.Show("Yemek başarıyla silindi!");
        }

        private void numAdet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}