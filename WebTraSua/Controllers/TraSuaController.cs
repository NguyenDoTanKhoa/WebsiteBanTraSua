using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTraSua.Controllers
{
    public class TraSuaController : Controller
    {
        // GET: TraSua
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NavPartial()
        {
            return View();
        }
        public ActionResult FooterPartial()
        {
            return View();
        }
    }
}