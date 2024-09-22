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
    public class Products_TestMethod
    {
		[ClassInitialize]
		public static  void ClassInitialize(TestContext testContext)
        {
            ManageDriver.MaximizeDriver();
        }

        [ClassCleanup]

        public static void ClassCleanup() 
        {
            ManageDriver.CloseDriver();
        }

        [TestMethod]

        public void ProductPageMethod()
        {
            try
            {
                HomePage_TestMethod homepage = new HomePage_TestMethod();
                homepage.HomePageMethod();

                ProductsPage productsPage = new ProductsPage(ManageDriver.driver);

                Thread.Sleep(5000);
                productsPage.ClickaddProduct1();
                productsPage.ClickaddProduct2();
                productsPage.ClickShippingIcon();

                Thread.Sleep(5000);

                var expectedUrl = "https://localhost:44349/User/ShoppingCart";
                var actualUrl = ManageDriver.driver.Url;

                Assert.AreEqual(expectedUrl, actualUrl, "succssful");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the add products process");
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
