using KitapAp.MODELS;
using KitapApp.DAL;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapApp.BLL
{
    public class KitapTuruBL:IDisposable
    {
        KitapDbContext ctx = new KitapDbContext();

        public bool Ekle(KitapTuru k)
        {

            ctx.KitapTurleri.Add(k);
           
            return ctx.SaveChanges() > 0;
        }

        public bool Guncelle(KitapTuru o)
        {
            ctx.Entry<KitapTuru>(o).State = EntityState.Modified;
            return ctx.SaveChanges() > 0;
        }

        public bool Sil(KitapTuru o)
        {
            ctx.KitapTurleri.Remove(o);
            return ctx.SaveChanges() > 0;
        }



        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }
    }
}
