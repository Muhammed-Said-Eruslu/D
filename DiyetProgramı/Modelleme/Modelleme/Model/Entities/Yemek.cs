using Modelleme.Model.Abstracts;

namespace Modelleme.Model.Entities
{
    public class Yemek : BaseClass
    {

        public int YemekId { get; set; }
        public string YemekAdi { get; set; }
        public int KategoriId { get; set; }
        public double Kalori {  get; set; }
        public Kategori Kategori { get; set; }
        public byte[] Resim { get; set; }
        public ICollection<OgunYemek> Ogunleri { get; set; }


    }
}