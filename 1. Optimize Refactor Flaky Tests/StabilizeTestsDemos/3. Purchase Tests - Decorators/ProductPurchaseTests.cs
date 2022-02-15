using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;

namespace StabilizeTestsDemos.ThirdVersion
{
    [TestClass]
    public class ProductPurchaseTests
    {
        private static Driver _driver;
        private static string _purchaseEmail;
        private static string _purchaseOrderNumber;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _driver = new LoggingDriver(new WebCoreDriver());
            _driver.Start(Browser.Chrome);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _driver.Quit();
        }

        private string GetUserPasswordFromDb(string userName)
        {
            return "@purISQzt%%DYBnLCIhaoG6$";
        }

        private string GenerateUniqueEmail()
        {
            return $"{Guid.NewGuid()}@berlinspaceflowers.com";
        }
    }
}
