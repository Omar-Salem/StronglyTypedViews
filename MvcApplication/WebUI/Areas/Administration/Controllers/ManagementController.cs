using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Areas.Administration.Controllers
{
    public class ManagementController : Controller
    {
        //
        // GET: /Administration/Management/

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult GetProduct(int id)
        {
            return MVCStronglyTypedViews.Areas.Administration.Management.GetProduct(96);
        }
    }
}
