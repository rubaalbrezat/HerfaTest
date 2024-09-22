using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerfaTest.POM
{
    public class HomePage
    {
        IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        By productsLink = By.XPath("//a[@href=\"/User/Categories\"]");


        public void CllickProductLink()
        {
            _driver.FindElement(productsLink).Click();
        }
    }
}
