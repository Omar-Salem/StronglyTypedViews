using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebUI.Models;

namespace UnitTests
{
    [TestClass]
    public class StronglyTypedViewsTest
    {
        [TestMethod]
        public void TestGeneratedPaths()
        {
            Assert.AreEqual("~/Views/Account/ChangePassword.cshtml", MVCStronglyTypedViews.Account.ChangePassword(null).ViewName);
            Assert.AreEqual("~/Areas/Administration/Views/Management/GetProduct.cshtml",
                            MVCStronglyTypedViews.Areas.Administration.Management.GetProduct(9).ViewName);
            Assert.AreEqual("~/Areas/Backend/Views/Management/GetProduct.cshtml",
                       MVCStronglyTypedViews.Areas.Backend.Management.GetProduct(10).ViewName);
        }

        [TestMethod]
        public void TestObjectTypes()
        {
            Assert.IsInstanceOfType(MVCStronglyTypedViews.Account.ChangePassword(new ChangePasswordModel()).Model, typeof(ChangePasswordModel));
            Assert.IsInstanceOfType(MVCStronglyTypedViews.Areas.Administration.Management.GetProduct(9).Model, typeof(int));
        }
    }
}