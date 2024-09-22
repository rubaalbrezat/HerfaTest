using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerfaTest.POM
{
    public class UserRegisterPage
    {
        IWebDriver _driver;

        public UserRegisterPage(IWebDriver driver)
        {
            _driver = driver;
        }


        By FirstName = By.XPath("//div//input[@id='Fname']");
        By LastName = By.XPath("//div//input[@id='Lname']");
        By Female = By.XPath("//div/input[@value='F']");
        By Male = By.XPath("//div/input[@value='M']");
        By PhoneNumber = By.XPath("//div/input[@id='Phonenumber']");
        By BirthDate = By.XPath("//div/input[@id='Dateofbirth']");
        By EmailAddres = By.XPath("//div/input[@id='Email']");
        By Image = By.XPath("//div/input[@name='ImageFileUser']");
        By Pass = By.XPath("//div/input[@id='myPass']");
        By CoPass = By.XPath("//div/input[@id='myPass2']");
        By Submit = By.XPath("//div/button[@type='submit']");
        By loginLink = By.XPath("//p/a[@href='/Auth/Login']");


        public void EnterFirstName(string value)
        {
            _driver.FindElement(FirstName).SendKeys(value);
        }

        public void EnterLastName(string value)
        {
            _driver.FindElement(LastName).SendKeys(value);
        }

        public void ClickMaleButton()
        {
            _driver.FindElement(Male).Click();
        }

        public void ClickFeMaleButton()
        {
            _driver.FindElement(Female).Click();
        }

        public void EnterBirthDate(string value)
        {
            _driver.FindElement(BirthDate).SendKeys(value);
        }

        public void EnterPhoneNumber(string value)
        {
            _driver.FindElement(PhoneNumber).SendKeys(value);
        }

        public void EnterEmail(string value)
        {
            _driver.FindElement(EmailAddres).SendKeys(value);
        }

        public void EnterImage(string value)
        {
            _driver.FindElement(Image).SendKeys(value);
        }

        public void EnterPassword(string value)
        {
            _driver.FindElement(Pass).SendKeys(value);
        }

        public void EnterConfirmationPassword(string value)
        {
            _driver.FindElement(CoPass).SendKeys(value);
        }

        public void ClickSubmitButton()
        {
            _driver.FindElement(Submit).Click();
        }

        public void ClickLoginLink()
        {
            _driver.FindElement(loginLink).Click();
        }
    }
}
