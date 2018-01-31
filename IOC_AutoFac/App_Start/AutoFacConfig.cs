using Autofac;
using Autofac.Integration.WebApi;
using IOC_AutoFac.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace IOC_AutoFac
{
    public static class AutofacConfig
    {
        public static ContainerBuilder GetAutofacContainerBuilder()
        {
            var builder = new ContainerBuilder();

            // Register the Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).InstancePerRequest();
            // builder.RegisterType<TestService>().As<ITestService>();
            builder.RegisterAssemblyTypes(new Assembly[]{
                Assembly.Load("IOC_AutoFac.Services"),
           }).Where(t => !string.IsNullOrWhiteSpace(t.Namespace))
           .AsImplementedInterfaces();

            return builder;
        }
    }
}