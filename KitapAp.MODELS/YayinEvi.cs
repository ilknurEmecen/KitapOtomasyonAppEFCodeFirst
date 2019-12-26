using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapAp.MODELS
{
    [Table("tblYayinEvi")]
    public class YayinEvi
    {
        public int YayinEviId { get; set; }


        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string YayinEviAd { get; set; }

        public ICollection<Kitap> YayınEviKitaplari { get; set; }

    }
}
