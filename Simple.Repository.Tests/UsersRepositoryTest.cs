using NUnit.Framework;
using Simple.Domain;
using Simple.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Repository.Tests
{
    public class UsersRepositoryTest
    {
        IUsersRepository usersRepository;
        [SetUp]
        public void SetConnections()
        {
            string constr = ConfigurationManager.ConnectionStrings["SimpleConnection"].ConnectionString;
            usersRepository = new UsersRepository(constr);
        }
        [Test]
        public void CouldSaveUsers()
        {
            string testname = DateTime.Now.ToString();
            Users user = new Users { FirstName = testname, LastName = "test", Phone = "5522185", UserId = testname };
            usersRepository.SaveUsers(user);
            Users fetched=usersRepository.GetUsers(testname);
            Assert.IsTrue(fetched.FirstName == testname);
        }

        
    }
}
