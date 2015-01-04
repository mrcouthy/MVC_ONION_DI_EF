using Simple.Interface.Repository;
using Simple.Interface.Service;
using Simple.Repository;
using Simple.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple.Web.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            string constr = ConfigurationManager.ConnectionStrings["SimpleConnection"].ConnectionString;
            IUsersRepository ur = new UsersRepository(constr);
            IUsersService us = new UsersService(ur);
            return this.View(us.GetUsers());
        }
    }
}