using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    // Kategori (Category) nesnesi için veri erişim katmanı sınıfı.
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;

        // Bir kategori nesnesini silmek için kullanılır.
        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        // Belirli bir filtreleme ifadesine göre kategori nesnesi getirmek için kullanılır.
        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException(); // Metod henüz uygulanmamış durumda.
        }

        // Yeni bir kategori nesnesi eklemek için kullanılır.
        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        // Tüm kategori nesnelerinin listesini almak için kullanılır.
        public List<Category> List()
        {
            return _object.ToList();
        }

        // Belirli bir filtreleme ifadesine göre kategori nesnelerinin listesini almak için kullanılır.
        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException(); // Metod henüz uygulanmamış durumda.
        }

        // Bir kategori nesnesini güncellemek için kullanılır.
        public void Update(Category p)
        {
            throw new NotImplementedException(); // Metod henüz uygulanmamış durumda.
        }
    }
}
