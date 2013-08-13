using System;
using System.Web.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using WebUI.Models;
namespace StronglyTypedViews

{
public partial class Account : Controller
{
public ViewResult ChangePassword_Grid(ChangePasswordModel model)
{
return View("~/Views/Account/ChangePassword.Grid.cshtml", (object)model);
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
