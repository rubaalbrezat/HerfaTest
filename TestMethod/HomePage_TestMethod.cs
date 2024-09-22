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
    public class HomePage_TestMethod
    {
        [ClassInitialize]

        public static void ClassInitializ(TestContext testContext)
        {
            ManageDriver.MaximizeDriver();
        }

        [ClassCleanup]
        public static void ClassCleanUp()
        {
            ManageDriver.CloseDriver();
        }

        [TestMethod]

        public void HomePageMethod()
        {
            try
            {
                Login_TestMethod loginMethod = new Login_TestMethod();
                loginMethod.LoginMethod();

                CommonMethods.NavigateToURL("https://localhost:44349/User");

                HomePage homePage = new HomePage(ManageDriver.driver);
                homePage.CllickProductLink();
                Thread.Sleep(5000);

                var expectedUrl = "https://localhost:44349/User/Categories";
                var actualUrl = ManageDriver.driver.Url;
                Assert.AreEqual(expectedUrl, actualUrl, "succesful");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the process");
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
