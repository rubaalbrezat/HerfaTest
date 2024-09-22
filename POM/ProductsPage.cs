using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerfaTest.POM
{
    public class ProductsPage
    {
        IWebDriver _driver;

        public ProductsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        By Product1 = By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div/div[2]/div[1]/form/button/p/i");
        By Product2 = By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/div/div[2]/div[1]/form/button/p/i");
        By Shippingicon = By.XPath("//a[@href=\"/User/ShoppingCart\"]");

        public void ClickaddProduct1()
        {
            _driver.FindElement(Product1).Click();
        }0

        public void ClickaddProduct2()
        {
            _driver.FindElement(Product2).Click();
        }

        public void ClickShippingIcon()
        {
            _driver.FindElement(Shippingicon).Click();
        }

    }
}
