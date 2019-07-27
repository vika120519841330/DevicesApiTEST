using System;
using Ninject.Modules;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevicesApi.Domain.Core;
using DevicesApi.Infrastructure.Data;
using DeviceApi.Domain.Interfaces;

namespace DevicesApi.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IDeviceRepository>().To<DeviceRepository>();
            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}