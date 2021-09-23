using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace automationpractice.Page
{
    public class SearchResultPage : BasePage
    {
        private IWebElement searchedProductName => Driver.FindElement(By.CssSelector(".lighter"));
        private IWebElement productContainer => Driver.FindElement(By.CssSelector(".product-container"));
        private IWebElement btnAddToCart => Driver.FindElement(By.XPath("//a [@title='Add to cart']"));
        private IWebElement btnProceedToCheckout => Driver.FindElement(By.XPath("//a [@title='Proceed to checkout']"));
        public SearchResultPage(IWebDriver webDriver) : base(webDriver) {}

        public void VerifySearchedProduct()
        {
            string searchedProductNameText = searchedProductName.Text;
            Assert.AreEqual("t-shirt", searchedProductNameText.Replace("\"","").ToLower(), "Product name is not correct");
            Assert.IsTrue(productContainer.Displayed);
        }
        public void VerifyAddedProduct()
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,200);");
            Actions action = new Actions(Driver);
            action.MoveToElement(productContainer);
            action.Build().Perform();
            btnAddToCart.Click();
            btnProceedToCheckout.Click();
        }
        
        
    }
}