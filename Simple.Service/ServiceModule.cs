using Autofac;
using Simple.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Service
{
    public class ServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UsersService>()
                .As<IUsersService>()
                .PropertiesAutowired()
                .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
