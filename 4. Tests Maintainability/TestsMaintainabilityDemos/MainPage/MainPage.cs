// Copyright 2022 Automate The Planet Ltd.
// Author: Anton Angelov
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using OpenQA.Selenium;

namespace TestsMaintainabilityDemos.Facades.First
{
    public class MainPage : NavigatableEShopPage
    {
        public MainPage(Driver driver) 
            : base(driver)
        {
        }

        protected override string Url => "http://demos.bellatrix.solutions/";

        public Element AddToCartFalcon9 => Driver.FindElement(By.CssSelector("[data-product_id*='28']"));
        public Element ViewCartButton => Driver.FindElement(By.CssSelector("[class*='added_to_cart wc-forward']"));

        public Element GetAddToCartByName(string name)
        {
            return Driver.FindElement(By.XPath($"//h2[text()='{name}']/parent::a[1]"));
        }

        public Element GetProductBoxByName(string name)
        {
            return Driver.FindElement(By.XPath($"//h2[text()='{name}']/parent::a[1]/following-sibling::a[1]"));
        }

        public void AddRocketToShoppingCart(string rocketName)
        {
            Open();
            GetProductBoxByName(rocketName).Click();
            Driver.WaitForAjax();
            ViewCartButton.Click();
        }

        protected override void WaitForPageLoad()
        {
            AddToCartFalcon9.WaitToExists();
        }
    }
}
