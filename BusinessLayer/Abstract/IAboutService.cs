using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        // Belirli bir sayfadaki hakkında bilgilerinin listesini almak için kullanılır.
        List<About> GetAboutList();

        // Yeni bir hakkında bilgisi eklemek için kullanılır.
        void CategoryAdd(About about);

        // Belirli bir ID'ye sahip hakkında bilgisini getirmek için kullanılır.
        About GetByID(int id);

        // Belirli bir hakkında bilgisini silmek için kullanılır.
        void AboutDelete(About about);

        // Belirli bir hakkında bilgisini aktif hale getirmek için kullanılır.
        void AboutActive(About about);

        // Varolan bir hakkında bilgisini güncellemek için kullanılır.
        void AboutUpdate(About about);
    }
}
