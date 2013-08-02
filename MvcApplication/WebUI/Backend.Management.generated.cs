using System;
using System.Web.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
namespace StronglyTypedViews.Areas.Backend

{
public partial class Management : Controller
{
public ViewResult GetProduct(int model)
{
return View("~/Areas/Backend/Views/Management/GetProduct.cshtml", (object)model);
}

}
}
