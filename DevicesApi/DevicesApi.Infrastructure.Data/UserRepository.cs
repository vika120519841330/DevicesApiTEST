using DeviceApi.Domain.Interfaces;
using DevicesApi.Domain.Core;
using ONIONv3.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace DevicesApi.Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly MyContext context;
        public UserRepository()
        {
            context = new MyContext();
        }

        public IEnumerable<User> ShowAllUsers()
        {
            return context.Users;
        }
        public User GetUser(int id)
        {
            var tmp = from bd in context.Users
                      where bd.UserId == id
                      select bd;
            return tmp.Count() > 0 ? tmp.First() : null;
        }
        public void AddUser([FromBody]User inst)
        {
            context.Users.Add(inst);
            context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            User tmp = GetUser(id);
            if (tmp != null)
            {
                context.Users.Remove(tmp);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Запрошенный идентификационный номер пользователя не существует!!" +
                    "Попробуйте ввести другой идентификационный номер пользователя!!");
            }
        } 
    }
}
