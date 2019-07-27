using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesApi.Domain.Core
{
    public interface IDeviceRepository
    {
        IEnumerable<Device> ShowAllDevices();

        Device GetDevice(int id);

        void AddDevice(Device inst);

        void DeleteDevice(int id);
    }
}
