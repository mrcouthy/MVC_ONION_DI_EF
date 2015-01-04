using Simple.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Interface.Service
{
    public interface IUsersService
    {    
        Users GetUsers(string userID);
        IEnumerable<Users> GetUsers();
    }
}
