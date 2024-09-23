using HerfaTest.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerfaTest.POM
{
    public class CartPage
    {
        IWebDriver _driver;

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        By cardholder_Name= By.XPath("//input[@name=\"cardholderame\"]");
        By cardNumber = By.XPath("//input[@name=\"cardNumber\"]");
        By cvv = By.XPath("//input[@name=\"cvv\"]");
        By expirteDate = By.XPath("//input[@name=\"expire\"]");
        By PayButton = By.XPath("//button[@type=\"submit\"]");
        By rememberMeCheack = By.XPath("//input[@type=\"checkbox\"]");
        By backLink = By.XPath("/html/body/div[1]/section[2]/div/div/div/div/form/a");
        


        public void EnterCardHolder(string value)
        {
            _driver.FindElement(cardholder_Name).SendKeys(value);
        }

        public void EnterCardNumber(string value) 
        {
            _driver.FindElement(cardNumber).SendKeys(value);

        }

        public void EnterCvv(string value)
        {
            _driver.FindElement(cvv).SendKeys(value);
        }


        public void EnterExpireDate(string expireDate)
        {
            var expireDateField = ManageDriver.driver.FindElement(By.Name("expire"));
            string script = $"arguments[0].value = '{expireDate}';";
            ((IJavaScriptExecutor)ManageDriver.driver).ExecuteScript(script, expireDateField);
        }

        public void ClickPayButton()
        {
            _driver.FindElement(PayButton).Click();
        }

        public void ClickRememberMeButton()
        {
            _driver.FindElement(rememberMeCheack).Click();
        }

        public void ClickBackLink()
        {
            _driver.FindElement(backLink).Click();
        }

        public string GetCardHolder()
        {
            IWebElement holderNameInput = _driver.FindElement(By.XPath("//input[@name=\"cardholderame\"]"));
            return holderNameInput.GetAttribute("value");
        }


        public string GetCardNumber()
        {
            IWebElement cardNumberInput = _driver.FindElement(By.XPath("//input[@name=\"cardNumber\"]"));
            return cardNumberInput.GetAttribute("value");
        }

        public string GetCvv()
        {
            IWebElement CvvInput = _driver.FindElement(By.XPath("//input[@name=\"cvv\"]"));
            return CvvInput.GetAttribute("value");
        }

        public string GetExpireDate()
        {
            IWebElement ExpireDateInput = _driver.FindElement(By.XPath("//input[@name=\"expire\"]"));
            return ExpireDateInput.GetAttribute("value");
        }
    }
}
