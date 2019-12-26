using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapAp.MODELS
{
   
    public class KitapTuru
    {
        public int KitapTuruId { get; set; }
        public string KitapTuruAd { get; set; }

        public ICollection<Kitap> KitapTurleri { get; set; }
    }
}
