using NUnit.Framework;
using OpenQA.Selenium;

namespace automationpractice.Page
{
    public class ShoppingCartPage : BasePage
    { 
        private IWebElement checkoutSummary => Driver.FindElement(By.Id("cart_summary"));
        private IWebElement btnCheckout => Driver.FindElement(By.CssSelector(".cart_navigation.clearfix > a > span"));
        public ShoppingCartPage(IWebDriver webDriver) : base(webDriver){}
        public void VerifyProductVisibilityInCart()
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,300);");
            Assert.IsTrue(checkoutSummary.Displayed, "Product not visible");
            btnCheckout.Click();
        }
    }
}