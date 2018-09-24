using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoX.Controllers;
using System.Web.Mvc;
using ProyectoX.Models;

namespace ProyectoX.Tests
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FooActionReturnsAboutView()
        {
            var homeController = new HomeController();
            var result = homeController.Foo() as ViewResult;
            Assert.AreEqual("About", result.ViewName);
        }

        [TestMethod]
        public void ContactFormSaysThanks()
        {
            var homeController = new HomeController();
            var result = homeController.Contact("I love your bank.") as ViewResult;
            Assert.IsNotNull(result.ViewBag.TheMessage);
        }

        [TestMethod]
        public void BalanceIsCorrectAfterDeposit()
        {
            var fakeDb = new FakeApplicationDbContext();
            fakeDb.CheckingAccounts = new FakeDbSet<CheckingAccount>();

            var checkingAccount = new CheckingAccount { Id = 1, AccountNumber = "000123TEST", Balance = 0 };
            fakeDb.CheckingAccounts.Add(checkingAccount);
        }
    }
}
