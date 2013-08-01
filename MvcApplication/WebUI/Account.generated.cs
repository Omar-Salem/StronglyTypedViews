using System;
using System.Web.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
namespace StronglyTypedViews

{
public partial class Account : Controller
{
public ViewResult ChangePassword(WebUI.Models.ChangePasswordModel model)
{
return View("~/Views/Account/ChangePassword.cshtml", (object)model);
}
public ViewResult LogOn(WebUI.Models.LogOnModel model)
{
return View("~/Views/Account/LogOn.cshtml", (object)model);
}
public ViewResult Register(WebUI.Models.RegisterModel model)
{
return View("~/Views/Account/Register.cshtml", (object)model);
}

}
}
