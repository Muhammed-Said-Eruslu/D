using Modelleme.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Model.Entities
{
    public class OgunYemek: BaseClass
    {
        public int OgunYemekDetayId { get; set; }   
        public int OgunId { get; set; }
        public  Ogun Ogun { get; set; }
        public bool AktifMi { get; set; } = false;
        public int YemekId { get; set; }
        public   Yemek Yemek { get; set; }
        public double Miktar { get; set; }
    }
}
