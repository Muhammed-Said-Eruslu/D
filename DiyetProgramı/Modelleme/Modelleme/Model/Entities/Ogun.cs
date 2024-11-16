using Modelleme.Model.Abstracts;

namespace Modelleme.Model.Entities
{
    public class Ogun: BaseClass
    {
       public int OgunId { get; set; }  
        public int KullaniciId { get; set; }
        public DateTime Tarih { get; set; }

        public Kullanici Kullanici { get; set; }
        public ICollection<OgunYemek> Yemekleri { get; set; }
    }
}