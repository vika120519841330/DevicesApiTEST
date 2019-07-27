using DevicesApi.Domain.Core;
using ONIONv3.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesApi.Infrastructure.Data
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly MyContext context;
        public DeviceRepository()
        {
            context = new MyContext();
        }
        public IEnumerable<Device> ShowAllDevices()
        {
            return context.Devices;
        }
        public Device GetDevice(int id)
        {
            var tmp = from bd in context.Devices
                      where bd.DeviceId == id
                      select bd;
            return tmp.Count() > 0 ? tmp.First() : null;
        }
        public void AddDevice(Device inst)
        {
            context.Devices.Add(inst);
            context.SaveChanges();
        }

        public void DeleteDevice(int id)
        {
            var tmp = GetDevice(id);
            if (tmp != null)
            {
                context.Devices.Remove(tmp);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Запрошенный идентификационный номер устройства не существует!!" +
                    "Попробуйте ввести другой идентификационный номер устройства!!");
            }
        }
    }
}
