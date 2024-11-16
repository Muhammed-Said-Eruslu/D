using Modelleme.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelleme.Model;
using Modelleme.Model.Abstracts;
using Microsoft.EntityFrameworkCore;


namespace Modelleme.AllRepos
{
    public class BaseRepo <T> where T : BaseClass
    {

        protected readonly KaloriTakipDbContext db;
        protected readonly DbSet<T> set;

        public BaseRepo()
        {
            db = new KaloriTakipDbContext();
            set= db.Set<T>();   
        }
        public void Ekle(T concrete)
        {

            set.Add(concrete);
            db.SaveChanges();
        }

        public List<T> ButunAktifleriGetir()
        {
            return set.Where(a => a.AktifMi).ToList();
        }

        public IQueryable<T> AktifleriGetirINum()
        {
            return set.Where(a => a.AktifMi);
        }
    }
}
