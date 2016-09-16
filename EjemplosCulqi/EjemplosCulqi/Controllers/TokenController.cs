using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemplosCulqi.Controllers
{
    public class TokenController : Controller
    {
        // GET: Token
        public ActionResult NuevoToken()
        {
            return View();
        }
    }
}