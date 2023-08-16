using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        // Bir hakkında bilgisini aktif hale getirmek için kullanılır.
        public void AboutActive(About about)
        {
            throw new NotImplementedException(); // Metod henüz uygulanmamış durumda.
        }

        // Yeni bir hakkında bilgisi eklemek için kullanılır.
        public void AboutAdd(About about)
        {
            _aboutDal.Insert(about);
        }

        // Bir hakkında bilgisini silmek için kullanılır.
        public void AboutDelete(About about)
        {
            _aboutDal.Delete(about);
        }

        // Varolan bir hakkında bilgisini güncellemek için kullanılır.
        public void AboutUpdate(About about)
        {
            _aboutDal.Update(about);
        }

        public void CategoryAdd(About about)
        {
            throw new NotImplementedException();
        }

        // Belirli bir sayfadaki hakkında bilgilerinin listesini almak için kullanılır.
        public List<About> GetAboutList()
        {
            throw new NotImplementedException(); // Metod henüz uygulanmamış durumda.
        }

        // Belirli bir ID'ye sahip hakkında bilgisini getirmek için kullanılır.
        public About GetByID(int id)
        {
            return _aboutDal.Get(x => x.AboutID == id);
        }

        // Tüm hakkında bilgilerinin listesini almak için kullanılır.
        public List<About> GetList()
        {
            return _aboutDal.List();
        }
    }
}
