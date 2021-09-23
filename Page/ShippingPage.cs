using OpenQA.Selenium;

namespace automationpractice.Page
{
    public class ShippingPage : BasePage
    {
        private IWebElement chkAgreetoTerms => Driver.FindElement(By.Id("uniform-cgv"));
        private IWebElement btnProceedToCheckout => Driver.FindElement(By.CssSelector("#form > p > button"));
        public ShippingPage(IWebDriver webDriver) : base(webDriver) {}
        public void AgreeToTheTerms()
        {
            if (!chkAgreetoTerms.Selected)
            {
                chkAgreetoTerms.Click();
            }
            btnProceedToCheckout.Click();
        }
    }
}