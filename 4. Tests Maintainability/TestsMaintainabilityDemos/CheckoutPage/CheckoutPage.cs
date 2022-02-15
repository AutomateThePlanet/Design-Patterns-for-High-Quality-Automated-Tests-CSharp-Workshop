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
    public class CheckoutPage : EShopPage
    {
        public CheckoutPage(Driver driver) 
            : base(driver)
        {
        }

        public Element BillingFirstName => Driver.FindElement(By.Id("billing_first_name"));
        public Element BillingLastName => Driver.FindElement(By.Id("billing_last_name"));
        public Element BillingCompany => Driver.FindElement(By.Id("billing_company"));
        public Element BillingCountryWrapper => Driver.FindElement(By.Id("select2-billing_country-container"));
        public Element BillingCountryFilter => Driver.FindElement(By.ClassName("select2-search__field"));
        public Element BillingAddress1 => Driver.FindElement(By.Id("billing_address_1"));
        public Element BillingAddress2 => Driver.FindElement(By.Id("billing_address_2"));
        public Element BillingCity => Driver.FindElement(By.Id("billing_city"));
        public Element BillingZip => Driver.FindElement(By.Id("billing_postcode"));
        public Element BillingPhone => Driver.FindElement(By.Id("billing_phone"));
        public Element BillingEmail => Driver.FindElement(By.Id("billing_email"));
        public Element CreateAccountCheckBox => Driver.FindElement(By.Id("createaccount"));
        public Element CheckPaymentsRadioButton => Driver.FindElement(By.CssSelector("[for*='payment_method_cheque']"));
        public Element PlaceOrderButton => Driver.FindElement(By.Id("place_order"));
        public Element ReceivedMessage => Driver.FindElement(By.XPath("//h1"));

        public Element GetCountryOptionByName(string countryName)
        {
            return Driver.FindElement(By.XPath($"//*[contains(text(),'{countryName}')]"));
        }

        public void FillBillingInfo(PurchaseInfo purchaseInfo)
        {
            BillingFirstName.TypeText(purchaseInfo.FirstName);
            BillingLastName.TypeText(purchaseInfo.LastName);
            BillingCompany.TypeText(purchaseInfo.Company);
            BillingCountryWrapper.Click();
            BillingCountryFilter.TypeText(purchaseInfo.Country);
            GetCountryOptionByName(purchaseInfo.Country).Click();
            BillingAddress1.TypeText(purchaseInfo.Address1);
            BillingAddress2.TypeText(purchaseInfo.Address2);
            BillingCity.TypeText(purchaseInfo.City);
            BillingZip.TypeText(purchaseInfo.Zip);
            BillingPhone.TypeText(purchaseInfo.Phone);
            BillingEmail.TypeText(purchaseInfo.Email);
            if (purchaseInfo.ShouldCreateAccount)
            {
                CreateAccountCheckBox.Click();
            }

            if (purchaseInfo.ShouldCheckPayment)
            {
                CheckPaymentsRadioButton.Click();
            }

            PlaceOrderButton.Click();
            Driver.WaitForAjax();
        }

        public void AssertOrderReceived()
        {
            // implement it
        }
    }
}
