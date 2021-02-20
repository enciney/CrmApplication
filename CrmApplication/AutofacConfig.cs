using Autofac;
using Autofac.Integration.Mvc;
using CrmApplication.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CrmApplication
{
	public class AutofacConfig
	{
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<DataModule>();
            //registering MVC controller
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();
            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());
            // Register our Data dependencies
            
            var container = builder.Build();
            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}