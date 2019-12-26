using KitapAp.MODELS;
using KitapApp.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapApp.BLL
{
    public class KitapBL:IDisposable
    {
        KitapDbContext ctx = new KitapDbContext();

        

        public bool Ekle(Kitap k)
        {
            ctx.Kitaplar.Add(k);
            return ctx.SaveChanges() > 0;
            
        }

        public bool Guncelle(Kitap o)
        {
            ctx.Entry<Kitap>(o).State = EntityState.Modified;
            return ctx.SaveChanges() > 0;
        }

        public bool Sil(Kitap o)
        {
            ctx.Kitaplar.Remove(o);
            return ctx.SaveChanges() > 0;
        }


        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }
    }
}
