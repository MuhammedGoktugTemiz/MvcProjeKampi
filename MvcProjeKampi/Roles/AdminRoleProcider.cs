using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MvcProjeKampi.Roles
{
    // Yönetici rol sağlayıcısı sınıfı.
    public class AdminRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Kullanıcıları belirli rollerle ilişkilendirme işlemi.
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        // Yeni bir rol oluşturma işlemi.
        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        // Bir rolü silme işlemi.
        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        // Bir roldeki kullanıcıları arama işlemi.
        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        // Tüm rollerin listesini alma işlemi.
        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        // Belirli bir kullanıcının rollerini alma işlemi.
        public override string[] GetRolesForUser(string username)
        {
            Context c = new Context();
            var x = c.Admins.FirstOrDefault(y => y.AdminUserName == username);

            if (x != null)
            {
                return new string[] { x.AdminRole };
            }
            else
            {
                // Belirli bir hata durumu veya varsayılan rol döndürme işlemi
                return new string[] { "DefaultRole" }; // Varsayılan bir rol döndürdüğünüzü varsayalım.
            }
        }

        // Bir roldeki kullanıcıların listesini alma işlemi.
        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        // Belirli bir kullanıcının belirli bir rolde olup olmadığını kontrol etme işlemi.
        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        // Kullanıcıları belirli rollerden çıkarma işlemi.
        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        // Bir rolün var olup olmadığını kontrol etme işlemi.
        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
