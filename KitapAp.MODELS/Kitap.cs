using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapAp.MODELS
{

    [Table("tblKitaplar")]

    public class Kitap
    {
        public int KitapId { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string KitapAdi { get; set; }



        public int YayinEviId { get; set; }
        public YayinEvi YayinEv { get; set; }


        [Column(TypeName = "varchar")]
        [MaxLength(4)]
        [Required]
        public string BasimYili { get; set; }


        public int YazarId { get; set; }
        public Yazar Yazari { get; set; }

        public int KitapTuruId { get; set; }
        public KitapTuru KitapTuru { get; set; }


        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        [Required]
        public string SayfaSayisi { get; set; }

    }
}
