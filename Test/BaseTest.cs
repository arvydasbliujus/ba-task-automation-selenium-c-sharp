using automationpractice.Drivers;
using automationpractice.Page;
using automationpractice.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace automationpractice.Test
{
    public class BaseTest
    {
        public static IWebDriver Driver;
        public static HomePage _homePage;
        public static SearchResultPage _searchResultPage;
        public static ShoppingCartPage _shoppingCartPage;
        public static AuthenticationPage _authenticationPage;
        public static AddressPage _addressPage;
        public static ShippingPage _shippingPage;
        public static PaymentPage _paymentPage;
        public static OrderSummaryPage _orderSummaryPage;
        
        [OneTimeSetUp]
        public static void SetUp()
        {
            Driver = CustomDriver.GetChromeDriver();
            _homePage = new HomePage(Driver);
            _searchResultPage = new SearchResultPage(Driver);
            _shoppingCartPage = new ShoppingCartPage(Driver);
            _authenticationPage = new AuthenticationPage(Driver);
            _addressPage = new AddressPage(Driver);
            _shippingPage = new ShippingPage(Driver);
            _paymentPage = new PaymentPage(Driver);
            _orderSummaryPage = new OrderSummaryPage(Driver);
        }
        
        [TearDown]
        public static void TakeScreeshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                ScreenShots.MakeScreeshot(Driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Quit();
        }
    }
}