using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    // Entity Framework tabanlı About nesnesi için veri erişim katmanı sınıfı.
    // EfAboutDal, GenericRepository sınıfından türetilir ve IAboutDal arayüzünü uygular.
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        // Özel bir işlem veya değişiklik yapılmadığından, GenericRepository'den türetilen metotlar kullanılır.
    }
}
