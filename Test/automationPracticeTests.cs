using NUnit.Framework;

namespace automationpractice.Test
{
    public class automationPracticeTests : BaseTest
    {
        [Test]
        public static void ProductPurchaseTest()
        {
            _homePage.NavigateToWebsite();
            _homePage.SearchByProductName("t-shirt");
            _searchResultPage.VerifySearchedProduct();
            _searchResultPage.VerifyAddedProduct();
            _shoppingCartPage.VerifyProductVisibilityInCart();
            _authenticationPage.SignIn("test.ba.automationpratice@test.com", "12345");
            _addressPage.ConfirmAddress();
            _shippingPage.AgreeToTheTerms();
            _paymentPage.VerifyPaymentsOptions();
            _orderSummaryPage.PaymentConfirmation();
        }
    }
}