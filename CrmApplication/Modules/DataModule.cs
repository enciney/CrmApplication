using Autofac;
using CrmApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrmApplication.Modules
{
	public class DataModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<EmployeeRepo>().As<IEmployeeRepo>().InstancePerRequest();
			base.Load(builder);
		}
	}
}