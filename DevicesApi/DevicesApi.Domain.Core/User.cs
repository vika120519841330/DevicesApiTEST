using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesApi.Domain.Core
{
    public class User
    {
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public string UserPassport { get; set; }
        public List<Device> UsersDevices { get; set; }
    }
}
