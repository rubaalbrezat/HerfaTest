﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerfaTest.POM
{
    public class RegisterPage
    {
        IWebDriver _driver;

        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;
        }

        By userLink = By.XPath("//div/a[@href='/Auth/RegisterUser']");
        By vendorLink = By.XPath("//div/a[@href='/Auth/RegisterVendor']");
        By haveAccountLink = By.XPath("//div/a[contains(text(), 'I am already registered')]");

        public void ClickUserLink()
        {
            _driver.FindElement(userLink).Click();
        }

        public void ClickVendorLink()
        {
            _driver.FindElement(vendorLink).Click();
        }

        public void ClickHaveAccuntLink()
        {
            _driver.FindElement(haveAccountLink).Click();
        }
    }
}
