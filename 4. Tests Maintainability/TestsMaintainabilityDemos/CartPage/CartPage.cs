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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace TestsMaintainabilityDemos.Facades.First
{
    public class CartPage : EShopPage
    {
        public CartPage(Driver driver) 
            : base(driver)
        {
            BreadcrumbSection = new BreadcrumbSection(Driver);
            //Elements = new CartPageElements(driver);
            //Assertions = new CartPageAssertions(Elements);
        }

        public BreadcrumbSection BreadcrumbSection { get; }
        public Element CouponCodeTextField => Driver.FindElement(By.Id("coupon_code"));
        public Element ApplyCouponButton => Driver.FindElement(By.CssSelector("[value*='Apply coupon']"));
        public Element QuantityBox => Driver.FindElement(By.CssSelector("[class*='input-text qty text']"));
        public Element UpdateCart => Driver.FindElement(By.CssSelector("[value*='Update cart']"));
        public Element MessageAlert => Driver.FindElement(By.CssSelector("[class*='woocommerce-message']"));
        public Element TotalSpan => Driver.FindElement(By.XPath("//*[@class='order-total']//span"));
        public Element ProceedToCheckout => Driver.FindElement(By.CssSelector("[class*='checkout-button button alt wc-forward']"));

        public void ApplyCoupon(string coupon)
        {
            CouponCodeTextField.TypeText(coupon);
            ApplyCouponButton.Click();
            Driver.WaitForAjax();
        }

        public void IncreaseProductQuantity(int newQuantity)
        {
            QuantityBox.TypeText(newQuantity.ToString());
            UpdateCart.Click();
            Driver.WaitForAjax();
        }

        public void ClickProceedToCheckout()
        {
            ProceedToCheckout.Click();
            Driver.WaitUntilPageLoadsCompletely();
        }

        public void AssertCouponAppliedSuccessfully()
        {
            Assert.AreEqual("Coupon code applied successfully.", MessageAlert.Text);
        }

        public void AssertTotalPrice(string expectedPrice)
        {
            Assert.AreEqual(expectedPrice, TotalSpan.Text);
        }
    }
}
