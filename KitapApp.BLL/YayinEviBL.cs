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
    public class YayinEviBL:IDisposable
    {

        KitapDbContext ctx = new KitapDbContext();

        public bool Ekle(YayinEvi y)
        {

           ctx.YayinEvleri.Add(y);

            return ctx.SaveChanges() > 0;
        }

       
        public bool Guncelle(YayinEvi o)
        {
            ctx.Entry<YayinEvi>(o).State = EntityState.Modified;
            return ctx.SaveChanges() > 0;
        }

        public bool Sil(YayinEvi o)
        {
            ctx.YayinEvleri.Remove(o);
            return ctx.SaveChanges() > 0;
        }


        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }
    }
}
