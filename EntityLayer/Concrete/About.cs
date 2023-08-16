using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // Hakkında (About) nesnesi sınıfı.
    public class About
    {
        [Key]
        public int AboutID { get; set; } // Hakkında nesnesinin benzersiz tanımlayıcısı.

        [StringLength(1000)]
        public string AboutDetails1 { get; set; } // Hakkında detaylarının ilk bölümü.

        [StringLength(1000)]
        public string AboutDetails2 { get; set; } // Hakkında detaylarının ikinci bölümü.

        [StringLength(100)]
        public string AboutImage1 { get; set; } // Hakkında görselinin ilk adı.

        [StringLength(100)]
        public string AboutImage2 { get; set; } // Hakkında görselinin ikinci adı.
    }
}
