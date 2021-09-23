using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace automationpractice.Page
{
    public class OrderSummaryPage : BasePage
    {
        private IWebElement btnOrderConfirm => Driver.FindElement(By.CssSelector("#cart_navigation > button"));
        private IWebElement orderStatus => Driver.FindElement(By.CssSelector(".cheque-indent > .dark")); 
        public OrderSummaryPage(IWebDriver webDriver) : base(webDriver) {}

        public void PaymentConfirmation()
        {
            btnOrderConfirm.Click();
            string orderStatusText = orderStatus.Text;
            Assert.AreEqual("Your order on My Store is complete.", orderStatusText, "Text is not correct");
        }
    }
}

