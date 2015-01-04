using Simple.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Interface.Repository
{
    public interface IUsersRepository
    {
        Users GetUsers(string userID);

        IEnumerable<Users> GetAllUsers();

        Users SaveUsers(Users user);
        
    }
}
