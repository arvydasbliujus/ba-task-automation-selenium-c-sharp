using NUnit.Framework;
using OpenQA.Selenium;

namespace automationpractice.Page
{
    public class PaymentPage : BasePage
    {
        private IWebElement lnkPayByBank => Driver.FindElement(By.CssSelector(".bankwire"));
        private IWebElement lnkPayByCheck => Driver.FindElement(By.CssSelector(".cheque"));
        public PaymentPage(IWebDriver webDriver) : base(webDriver) {}

        public void VerifyPaymentsOptions()
        {
            string lnkPayByBankText = lnkPayByBank.Text;
            string lnkPayCheckText = lnkPayByCheck.Text;
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,300);");
            //Assert.AreEqual(payByBank.ToLower(), lnkPayByBankText.Replace("\"","").ToLower().Contains(payByBank), "wrong");
            //Assert.AreEqual(cheque.ToLower(), lnkPayCheckText.Replace("\"","").ToLower().Contains(cheque), "wrong");
            //Assert.AreEqual("Pay by bank wire", lnkPayByBankText.Contains("Pay by bank wire"), "wrong");
            //Assert.AreEqual("Pay by check", lnkPayCheckText.Contains("Pay by check"), "wrong");
            Assert.IsTrue(lnkPayByBankText.Contains("Pay by bank wire"), "wrong");
            Assert.IsTrue(lnkPayCheckText.Contains("Pay by check"), "wrong");
            lnkPayByBank.Click();
        }
    }
}