using OpenQA.Selenium;

namespace automationpractice.Page
{
    public class AuthenticationPage : BasePage
    {
        private IWebElement emailAddressInput => Driver.FindElement(By.Id("email"));
        private IWebElement passwordInput => Driver.FindElement(By.Id("passwd"));
        private IWebElement btnSignIn => Driver.FindElement(By.Id("SubmitLogin"));
     
        public AuthenticationPage (IWebDriver webDriver) : base(webDriver) {}

        public void SignIn(string email, string password)
        {
            emailAddressInput.SendKeys(email);
            passwordInput.SendKeys(password);
            btnSignIn.Click();
        }
    }
}