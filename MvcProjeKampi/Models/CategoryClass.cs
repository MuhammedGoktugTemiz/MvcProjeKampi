using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProjeKampi.Models
{
    // Kategori adı ve kategoriye ait öğe sayısı bilgilerini içeren sınıf.
    public class CategoryClass
    {
        public string CategoryName { get; set; } // Kategori adı.

        public int CategoryCount { get; set; } // Kategoriye ait öğe sayısı.
    }
}
