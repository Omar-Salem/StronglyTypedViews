using System;
using System.Web.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
namespace StronglyTypedViews
{
    public partial class Shared : Controller
    {
        public ViewResult Error(System.Web.Mvc.HandleErrorInfo model)
        {
            return View("~/Views/Shared/Error.cshtml", (object)model);
        }

    }
}
