using OpenQA.Selenium;

namespace automationpractice.Page
{
    public class HomePage : BasePage
    {
        private const string PageAddress = "http://automationpractice.com/";
        private IWebElement searchField => Driver.FindElement(By.Id("search_query_top"));
        private IWebElement btnSearch => Driver.FindElement(By.XPath("//button[@name='submit_search']"));
        public HomePage(IWebDriver webDriver) : base(webDriver){}

        public void NavigateToWebsite()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
        }

        public void SearchByProductName(string productName)
        {
            searchField.Clear();
            searchField.SendKeys(productName);
            btnSearch.Click();
        }
    }
}