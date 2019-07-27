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
    public class DeviceController : ApiController
    {
        private IDeviceRepository idivrep;
        //т.к. контейнер Ninject подключить не удается - если получится - раскомментировать
        public DeviceController(IDeviceRepository idrep)
        {
            idivrep = idrep;
        }

        //т.к. контейнер Ninject подключить не удается - если получится - закомментировать
        //public DeviceController()
        //{
        //    idivrep = new DeviceRepository();
        //}

        [HttpGet]
        [Route("")]
        public IEnumerable<Device> ShowAllDevices()
        {
            return idivrep.ShowAllDevices();
        }
        public Device GetDevice(int id)
        {
            var div = idivrep.GetDevice(id);

            if (div == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return idivrep.GetDevice(id);
        }

        [HttpPost]
        public void AddDevice([FromBody]Device inst)
        {
            idivrep.AddDevice(inst);
        }

        [HttpDelete]
        public void DeleteDevice(int id)
        {
            idivrep.DeleteDevice(id);
        }
    }
}