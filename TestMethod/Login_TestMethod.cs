using HerfaTest.Helpers;
using HerfaTest.POM;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerfaTest.TestMethod
{
    [TestClass]
    public class Login_TestMethod
    {
        [ClassInitialize]

        public static void ClassIntialize(TestContext testContext)
        {
            ManageDriver.MaximizeDriver();
        }

        [ClassCleanup]

        public static void ClassCleanup()
        {
            ManageDriver.CloseDriver();
        }

        [TestMethod]
        public void LoginMethod()
        {
            try
            {
                CommonMethods.NavigateToURL("https://localhost:44349/Auth/Login");
                Thread.Sleep(5000);

                LoginPage loginPage = new LoginPage(ManageDriver.driver);

                loginPage.EnterEmailAdress("rubaalbrezat@gmail.com");
                loginPage.EnterPassword("123@Qwee");
                loginPage.ClickloginButton();
                Thread.Sleep(5000);


                var expectedURL = "https://localhost:44349/User";
                var actualURL = ManageDriver.driver.Url;
                Assert.AreEqual(expectedURL, actualURL, "Actual URL not equal the expected URL_TC");
                Console.WriteLine("TC Completed Successfully");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the login process");
            }
            catch (WebDriverException ex)
            {

                Console.WriteLine("WebDriver error: " + ex.Message);
                Assert.Fail("WebDriver error occurred");
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);
                Assert.Fail("Test case failed: An unexpected error occurred.");

            }


        }
    }
}
