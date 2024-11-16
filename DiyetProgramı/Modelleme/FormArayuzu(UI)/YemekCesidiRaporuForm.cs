using Microsoft.Data.SqlClient;
using Modelleme.Context;
using Modelleme.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FormArayuzu_UI_
{
    public partial class YemekCesidiRaporuForm : Form
    {
        Kullanici kullanici;
        KaloriTakipDbContext db;
        SqlConnection connection;

        public YemekCesidiRaporuForm()
        {
            InitializeComponent();
            db = new KaloriTakipDbContext();
            connection = new SqlConnection("Server=.;Database=KaloriTakipDeneme3;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"); // Bağlantı dizesi
            EnCokYenilenYemekBul();
        }

        private void YemekCesidiRaporuForm_Load(object sender, EventArgs e)
        {
            // Veritabanındaki aktif yemekleri alıyoruz, aktif olanları filtreliyoruz
            var enCokYenenYemekler = db.OgunYemekler
                .Where(oy => oy.Ogun.AktifMi && oy.Yemek.AktifMi) // Aktif öğün ve yemekler
                .GroupBy(oy => oy.YemekId)  // Yemeklere göre grupluyoruz
                .Select(g => new
                {
                    YemekAdi = g.FirstOrDefault().Yemek.YemekAdi,
                    KategoriAdi = g.FirstOrDefault().Yemek.Kategori.KategoriAdi,
                    ToplamMiktar = g.Sum(oy => oy.Miktar)  // Miktar toplamını hesaplıyoruz
                })
                .OrderByDescending(g => g.ToplamMiktar)  // En çok yenen yemekleri önce getiriyoruz
                .Take(10) // İlk 10 yemek
                .ToList();

            // Bu veriyi DataGridView'e aktarıyoruz
            dgvTop10Yemekler.DataSource = enCokYenenYemekler;
            EnCokYenilenYemekBul();
        }

        private void EnCokYenilenYemekBul()
        {
            var yemekler = dgvTop10Yemekler.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Cells["YemekAdi"].Value != null && row.Cells["ToplamMiktar"].Value != null)
                .Select(row => new
                {
                    YemekAdi = row.Cells["YemekAdi"].Value.ToString(),
                    Adet = Convert.ToInt32(row.Cells["ToplamMiktar"].Value)
                })
                .ToList();

            if (!yemekler.Any())
            {
                lblBirinciYemek.Text = "Yemek verisi bulunmamaktadır.";
                return;
            }

            var maxAdet = yemekler.Max(y => y.Adet);

            var enCokYenilenYemekler = yemekler
                .Where(y => y.Adet == maxAdet)  // Aynı adetteki yemekleri alıyoruz
                .ToList();

            var yemekListesi = string.Join(Environment.NewLine, enCokYenilenYemekler.Select(y => $"{y.YemekAdi} - Adet: {y.Adet}"));
            lblBirinciYemek.Text = $"En çok yenilen yemekler:\n{yemekListesi}";

            // TableLayoutPanel'i sıfırlıyoruz (eski verilerden temizliyoruz)
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.ColumnCount = enCokYenilenYemekler.Count;

            // Dinamik olarak yemeklerin resimlerini ekliyoruz
            int columnIndex = 0;
            foreach (var yemek in enCokYenilenYemekler)
            {
                var pictureBox = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Resmi yüklemek için LoadResimFromDatabase fonksiyonunu çağırıyoruz
                var image = LoadResimFromDatabase(yemek.YemekAdi);
                if (image != null)
                {
                    pictureBox.Image = image;
                }
                else
                {
                    pictureBox.Image = null;
                }

                // Resmi ilgili hücreye ekliyoruz
                tableLayoutPanel1.Controls.Add(pictureBox, columnIndex, 0);
                columnIndex++;
            }
        }

        private Image LoadResimFromDatabase(string yemekAdi)
        {
            try
            {
                string query = "SELECT Resim FROM Yemekler WHERE YemekAdi = @YemekAdi"; // Parametreli sorgu
                using (SqlConnection connection = new SqlConnection("Server=.;Database=KaloriTakipDeneme3;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@YemekAdi", yemekAdi);

                    byte[] imageBytes = command.ExecuteScalar() as byte[];
                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            return Image.FromStream(ms); // Resmi döndürüyoruz
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
