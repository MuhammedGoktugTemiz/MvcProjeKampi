using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    // Genel bir veri erişim katmanı arayüzü. Temel CRUD (Create, Read, Update, Delete) işlemlerini içerir.
    public interface IRepository<T>
    {
        // Tüm varlık listesini almak için kullanılır.
        List<T> List();

        // Belirli bir filtreleme ifadesine göre varlık listesini almak için kullanılır.
        List<T> List(Expression<Func<T, bool>> filter);

        // Yeni bir varlık eklemek için kullanılır.
        void Insert(T p);

        // Belirli bir filtreleme ifadesine göre varlığı getirmek için kullanılır.
        T Get(Expression<Func<T, bool>> filter);

        // Varlığı silmek için kullanılır.
        void Delete(T p);

        // Varlığı güncellemek için kullanılır.
        void Update(T p);
    }
}
