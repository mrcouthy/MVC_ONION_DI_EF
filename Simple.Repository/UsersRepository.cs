using Simple.Domain;
using Simple.Interface.Repository;
using Simple.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly string configuration;
        public UsersRepository(string configuration)
        {
            this.configuration = configuration;
        }

        public Users SaveUsers(Users user)
        {
            using (var context = new SimpleContext(this.configuration))
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            return user;
        }

        public Users GetUsers(string userID)
        {
            using (var context = new SimpleContext(this.configuration))
            {
                var res = (from user in context.Users
                           where user.UserId == userID
                           select user);
                return res.FirstOrDefault();
            }
        }

        public  IEnumerable<Users> GetAllUsers()
        {
            using (var context = new SimpleContext(this.configuration))
            {
                var res = (from user in context.Users
                           select user);
                return res.ToList();
            }
        }
    }
}
