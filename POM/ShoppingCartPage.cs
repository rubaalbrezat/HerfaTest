using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerfaTest.POM
{
    public class ShoppingCartPage
    {
        IWebDriver _driver;

        public ShoppingCartPage(IWebDriver driver) 
        {
            _driver = driver;
        }

        By checkoutButton = By.XPath("//a[@href=\"/User/PayForTheOrder\"]");

        public void ClickCheckoutButton()
        {
            _driver.FindElement(checkoutButton).Click();
        }
    }
}
