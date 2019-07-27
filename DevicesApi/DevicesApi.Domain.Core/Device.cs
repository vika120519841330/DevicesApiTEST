using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesApi.Domain.Core
{
    public class Device
    {
        public int DeviceId { get; set; }
        public string DeviceTitle { get; set; }
        public string DeviceSerialNum { get; set; }
        public User DeviceOwner { get; set; }
    }
}
