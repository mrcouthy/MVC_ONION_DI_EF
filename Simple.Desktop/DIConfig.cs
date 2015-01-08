using Autofac;
using Simple.Repository;
using Simple.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Desktop
{
    public class DIConfig
    {
        public static IContainer container;
        public static void ResolveDependencies()
        {
            var builder = new ContainerBuilder();

            string constr = ConfigurationManager.ConnectionStrings["SimpleConnection"].ConnectionString;
            builder.RegisterModule(new RepositoryModule(constr));
            builder.RegisterModule(new ServiceModule());

            container = builder.Build();
            // Set MVC DI resolver to use our Autofac container
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
