using Modelleme.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Model.Entities
{
    public class Kullanici: BaseClass
    {
        public int KullaniciId { get; set; }    
        public string Email { get; set; }
        public string Password { get; set; }
        public  ICollection<Ogun> Ogunler { get; set; }
    }
}
