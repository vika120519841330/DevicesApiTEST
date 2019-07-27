using DeviceApi.Domain.Interfaces;
using DevicesApi.Domain.Core;
using DevicesApi.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevicesApi.Controllers
{
    public class UserController : ApiController
    {
        private IUserRepository iuserrep;

        //т.к. контейнер Ninject подключить не удается - если получится - раскомментировать
        //public UserController(IUserRepository iusr)
        //{
        //    iuserrep = iusr;
        //}

        //т.к. контейнер Ninject подключить не удается - если получится - закомментировать
        public UserController()
        {
            iuserrep = new UserRepository();
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<User> ShowAllUsers()
        {
            return iuserrep.ShowAllUsers();
        }
        

        [HttpGet]
        [Route("{id:int}")]
        public User GetUser(int id)
        {
            return iuserrep.GetUser(id);
        }

        [HttpPost]
        public void AddUser([FromBody]User inst)
        {
            iuserrep.AddUser(inst);
        }

        [HttpDelete]
        public void DeleteUser(int id)
        {
            iuserrep.DeleteUser(id); 
        }
    }
}
