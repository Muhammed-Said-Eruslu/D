using Modelleme.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Model.Entities
{
    public class Kategori: BaseClass
    {
        public int KategoriId { get; set; }

        public string KategoriAdi { get; set; }

        public ICollection<Yemek> Yemekler { get; set; }
            
    }
}
