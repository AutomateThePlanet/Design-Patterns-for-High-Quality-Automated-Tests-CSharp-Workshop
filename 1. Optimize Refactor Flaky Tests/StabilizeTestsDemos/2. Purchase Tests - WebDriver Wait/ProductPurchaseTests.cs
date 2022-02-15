// Copyright 2021 Automate The Planet Ltd.
// Author: Anton Angelov
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace StabilizeTestsDemos.SecondVersion
{
    [TestClass]
    public class ProductPurchaseTests
    {
        private static IWebDriver _driver;
        private static string _purchaseEmail;
        private static string _purchaseOrderNumber;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _driver = new ChromeDriver(Environment.CurrentDirectory);
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

        private void WaitToBeClickable(By by)
        {
            var webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
        }

        private IWebElement WaitAndFindElement(By by)
        {
            var webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            return webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
        }

        private ReadOnlyCollection<IWebElement> WaitAndFindElements(By by)
        {
            var webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            return webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
        }
    }
}
