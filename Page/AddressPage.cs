using OpenQA.Selenium;

namespace automationpractice.Page
{
    public class AddressPage : BasePage
    {
        private IWebElement btnProceedToCheckout =>
            Driver.FindElement(By.CssSelector("#center_column > form > p > button"));
        public AddressPage(IWebDriver webDriver) : base(webDriver) {}

        public void ConfirmAddress()
        {
            btnProceedToCheckout.Click();
        }
    }
}