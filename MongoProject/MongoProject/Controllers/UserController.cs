using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MongoProject.Controllers
{
    public class UserController:Controller
    {
        public ActionResult Registration()
        {
           return View();
        }
    }
}