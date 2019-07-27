using System;
using Ninject;
using Ninject.Modules;
using Ninject.Syntax;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using DevicesApi.Util;

namespace DevicesApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //внедрение зависимостей
            //NinjectModule registrations = new NinjectRegistrations();
            //var kernel = new StandardKernel(registrations);
            //DependencyResolver.SetResolver(new Ninject.Web.WebApi.NinjectDependencyResolver(kernel));
        }
    }
}
