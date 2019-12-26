using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapAp.MODELS
{
   public  class Yazar
    {
        public int YazarId { get; set; }
        public string YazarAdiSoyadi { get; set; }

        public ICollection<Kitap> KitapYazarlari { get; set; }
    }
}
