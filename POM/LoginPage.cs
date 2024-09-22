using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerfaTest.POM
{
    public class LoginPage
    {
        IWebDriver _driver;

        public  LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        By emailAddress = By.XPath("//input[@type='email']");
        By password = By.XPath("//input[@type='password']");
        By loginButton = By.XPath("//button[@type='submit']");


        public void EnterEmailAdress(string value) 
        {
            _driver.FindElement(emailAddress).SendKeys(value);
        }

        public void EnterPassword(string value)
        { 
          _driver.FindElement(password).SendKeys(value);    
        }

        public void ClickloginButton()
        {
            _driver.FindElement(loginButton).Click();
        }
    }
}
