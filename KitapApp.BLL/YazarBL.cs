using KitapAp.MODELS;
using KitapApp.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapApp.BLL
{
    public class YazarBL:IDisposable
    {
        KitapDbContext ctx = new KitapDbContext();

        public bool Ekle(Yazar yz)
        {
            ctx.Yazarlar.Add(yz);
            
            return ctx.SaveChanges() > 0;
        }


        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }
    }
}
