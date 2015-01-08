using Autofac;
using Simple.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Repository
{
    public class RepositoryModule:Module
    {
        private string config;
        public RepositoryModule(string config)
        {
            this.config = config;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UsersRepository>().
                As<IUsersRepository>()
                .WithParameter("configuration", config)
                .PropertiesAutowired()
                .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
