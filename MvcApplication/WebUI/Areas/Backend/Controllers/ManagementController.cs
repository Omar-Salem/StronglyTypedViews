using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Backend.Controllers
{
    public class ManagementController : Controller
    {
        //
        // GET: /Backend/Management/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetProduct(int prodId)
        {
            return View(prodId);
        }

    }
}
