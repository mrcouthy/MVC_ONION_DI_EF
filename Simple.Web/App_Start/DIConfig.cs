using Autofac;
using Autofac.Integration.Mvc;
using Simple.Repository;
using Simple.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
 
namespace Simple.Web.App_Start
{
    public class DIConfig
    {
        public static void ResolveDependencies()
        {
            var builder = new ContainerBuilder();
            
            string constr = ConfigurationManager.ConnectionStrings["SimpleConnection"].ConnectionString;
            builder.RegisterModule(new RepositoryModule(constr));
            builder.RegisterModule(new ServiceModule());

            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired().InstancePerLifetimeScope();
            var container = builder.Build();
            // Set MVC DI resolver to use our Autofac container
            //install-package autofac.mvc5
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}