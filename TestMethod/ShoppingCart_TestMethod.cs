using HerfaTest.Helpers;
using HerfaTest.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerfaTest.TestMethod
{
    [TestClass]
    public class ShoppingCart_TestMethod
    {

		[ClassInitialize]
		public static void ClassInitialize(TestContext testContext)
		{
			ManageDriver.MaximizeDriver();
		}

		[ClassCleanup]

		public static void ClassCleanup()
		{
			ManageDriver.CloseDriver();
		}

		[TestMethod]
		public  void ShoppingMethod()
        {
            try
            {
                Products_TestMethod productPage = new Products_TestMethod();
                productPage.ProductPageMethod();
				

				ShoppingCartPage shoppingCartPage = new ShoppingCartPage(ManageDriver.driver);


                Thread.Sleep(5000);
     

                shoppingCartPage.ClickCheckoutButton();

                Thread.Sleep(5000);

                var expectedUrl = "https://localhost:44349/User/PayForTheOrder";
                var actualUrl = ManageDriver.driver.Url;

                Assert.AreEqual(expectedUrl, actualUrl, "succssful");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the shopping process");
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





