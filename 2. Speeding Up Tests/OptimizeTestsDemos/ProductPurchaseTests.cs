using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace StabilizeTestsDemos.SixthVersion
{
    [TestClass]
    public class ProductPurchaseTests : BaseTest
    {   

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
