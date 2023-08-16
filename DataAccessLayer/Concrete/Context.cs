using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    // Veritabanı bağlantısı ve DbSet özelliklerini içeren Context sınıfı.
    public class Context : DbContext
    {
        // About (Hakkında) nesnesine karşılık gelen DbSet özelliği.
        public DbSet<About> Abouts { get; set; }

        // Category (Kategori) nesnesine karşılık gelen DbSet özelliği.
        public DbSet<Category> Categories { get; set; }

        // Contact (İletişim) nesnesine karşılık gelen DbSet özelliği.
        public DbSet<Contact> Contacts { get; set; }

        // Content (İçerik) nesnesine karşılık gelen DbSet özelliği.
        public DbSet<Content> Contents { get; set; }

        // Heading (Başlık) nesnesine karşılık gelen DbSet özelliği.
        public DbSet<Heading> Headings { get; set; }

        // Writer (Yazar) nesnesine karşılık gelen DbSet özelliği.
        public DbSet<Writer> Writers { get; set; }

        // Message (Mesaj) nesnesine karşılık gelen DbSet özelliği.
        public DbSet<Message> Messages { get; set; }

        // ImageFile (Resim Dosyası) nesnesine karşılık gelen DbSet özelliği.
        public DbSet<ImageFile> ImageFiles { get; set; }

        // Admin (Yönetici) nesnesine karşılık gelen DbSet özelliği.
        public DbSet<Admin> Admins { get; set; }
    }
}
