using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    // Hakkında (About) nesnesi için veri erişim katmanı arayüzü.
    // IAboutDal, IRepository arayüzünden türetilir ve About nesnesine özgü işlemleri içerebilir.
    public interface IAboutDal : IRepository<About>
    {

    }
}
