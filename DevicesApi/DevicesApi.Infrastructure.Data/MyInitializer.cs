using DevicesApi.Domain.Core;
using ONIONv3.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesApi.Infrastructure.Data
{
    public class MyInitializer : DropCreateDatabaseAlways<MyContext>
    {
        Device d1, d2, d3, d4, d5;
        User u1, u2, u3;
        protected override void Seed(MyContext context)
        {
            u1 = new User
            {
                UserId = 1,
                UserFullName = "Иванов Иван Иванович",
                UserPassport = "MP4578964",
                UsersDevices = new List<Device>() { d1, d2 }
            };
            d1 = new Device
            {
                DeviceId = 11,
                DeviceSerialNum = "PO4566HH",
                DeviceTitle = "TV_Samsung",
                DeviceOwner = u1
            };
            d2 = new Device
            {
                DeviceId = 12,
                DeviceSerialNum = "ddf558ggg6-H",
                DeviceTitle = "Mobile_Sony",
                DeviceOwner = u1
            };
            context.Users.Add(u1);
            context.Devices.Add(d1);
            context.Devices.Add(d2);

            u2 = new User
            {
                UserId = 2,
                UserFullName = "Петров Петр Петрович",
                UserPassport = "PB4569852",
                UsersDevices = new List<Device>() { d3 }
            };
            d3 = new Device
            {
                DeviceId = 13,
                DeviceSerialNum = "fgdsh9985_11",
                DeviceTitle = "Mobile_LG",
                DeviceOwner = u2
            };
            context.Users.Add(u2);
            context.Devices.Add(d3);

            u3 = new User
            {
                UserId = 3,
                UserFullName = "Сидоров Андрей Александрович",
                UserPassport = "MP4596851",
                UsersDevices = new List<Device>() { d4, d5 }
            };
            d4 = new Device
            {
                DeviceId = 14,
                DeviceSerialNum = "fgdzhzdHY98",
                DeviceTitle = "PC_ASUS",
                DeviceOwner = u3
            };
            d5 = new Device
            {
                DeviceId = 15,
                DeviceSerialNum = "fgdsh9985_11",
                DeviceTitle = "Mobile_LG",
                DeviceOwner = u3
            };

            context.Users.Add(u3);
            context.Devices.Add(d4);
            context.Devices.Add(d5);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}

