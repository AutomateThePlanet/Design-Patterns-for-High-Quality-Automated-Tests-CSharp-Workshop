﻿// Copyright 2022 Automate The Planet Ltd.
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

namespace TestsReadabilityDemos.Fourth
{
    public class BreadcrumbSection
    {
        private readonly Driver _driver;
        
        public BreadcrumbSection(Driver driver)
        {
            _driver = driver;
        }

        private Element Breadcrumb => _driver.FindElement(By.ClassName("woocommerce-breadcrumb"));
     
        public void OpenBreadcrumbItem(string itemToOpen)
        {
            Breadcrumb.FindElement(By.LinkText(itemToOpen)).Click();
        }        
    }
}
