using Simple.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Repository.Context
{
    public class SimpleContext : DbContext
    {
        public SimpleContext()
            : base()
        {
            //This is required for mvc scaffolding only!
        }
        private static SqlProviderServices instance = SqlProviderServices.Instance;
        public SimpleContext(string configuration)
            : base(configuration)
        {
        }
        public virtual DbSet<Users> Users { get; set; }
    }
}
