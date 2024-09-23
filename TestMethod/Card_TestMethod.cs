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
    public class Card_TestMethod
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
        public void ValidPaymentfields()
        {
            try {
                ShoppingCart_TestMethod shoppingCart = new ShoppingCart_TestMethod();
                shoppingCart.ShoppingMethod();


                CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


                Thread.Sleep(5000);

                CartPage usercartPage = new CartPage(ManageDriver.driver);


                usercartPage.EnterCardHolder("BatoolJarrah");
                usercartPage.EnterCardNumber("5555666677778907");
                usercartPage.EnterCvv("379");
                usercartPage.EnterExpireDate("2025-03");
                usercartPage.ClickPayButton();

                Thread.Sleep(5000);

		

				IWebElement errorMessageElement = ManageDriver.driver.FindElement(By.XPath("//div[@class='modal-body']//h5"));

				var expectedMessage = "The operation was performed successfully";
				var actualMessage = errorMessageElement.Text;
				Assert.AreEqual(expectedMessage, actualMessage, "The error message does not match the expected result");
				Console.WriteLine("TC Completed Successfully");
			}
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the payment process");
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


        [TestMethod]
        public void InvalidCardHolderfield()
        {
            try {
                ShoppingCart_TestMethod shoppingCart = new ShoppingCart_TestMethod();
                shoppingCart.ShoppingMethod();
              


				CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


                Thread.Sleep(5000);

                CartPage usercartPage = new CartPage(ManageDriver.driver);


                usercartPage.EnterCardHolder("BatoolJarrahh");
                usercartPage.EnterCardNumber("5555666677778907");
                usercartPage.EnterCvv("379");
                usercartPage.EnterExpireDate("2025-03");
                usercartPage.ClickPayButton();

                Thread.Sleep(5000);
                var expectedURL = "https://localhost:44349/User/PayForTheOrder";
                var actualUrl = ManageDriver.driver.Url;
                Assert.AreEqual(expectedURL, actualUrl, "succesful test case");
                Console.WriteLine("TC Completed Successfully");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the payment process");
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



        [TestMethod]
        public void InvalidCardNumberfield()
        {
            try {
				Login_TestMethod loginpage = new Login_TestMethod();
				loginpage.LoginMethod();



				CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


                Thread.Sleep(5000);

                CartPage usercartPage = new CartPage(ManageDriver.driver);


                usercartPage.EnterCardHolder("BatoolJarrah");
                usercartPage.EnterCardNumber("5555666677778904");
                usercartPage.EnterCvv("379");
                usercartPage.EnterExpireDate("2025-03");
                usercartPage.ClickPayButton();

                Thread.Sleep(5000);
                var expectedURL = "https://localhost:44349/User/PayForTheOrder";
                var actualUrl = ManageDriver.driver.Url;
                Assert.AreEqual(expectedURL, actualUrl, "succesful test case");
                Console.WriteLine("TC Completed Successfully");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the payment process");
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



        [TestMethod]
        public void InvalidCvvfield()
        {
            try {
                ShoppingCart_TestMethod shoppingCart = new ShoppingCart_TestMethod();
                shoppingCart.ShoppingMethod();



                CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


                Thread.Sleep(5000);

                CartPage usercartPage = new CartPage(ManageDriver.driver);


                usercartPage.EnterCardHolder("BatoolJarrah");
                usercartPage.EnterCardNumber("5555666677778907");
                usercartPage.EnterCvv("379");
                usercartPage.EnterExpireDate("2025-03");
                usercartPage.ClickPayButton();

                Thread.Sleep(5000);
                var expectedURL = "https://localhost:44349/User/PayForTheOrder";
                var actualUrl = ManageDriver.driver.Url;
                Assert.AreEqual(expectedURL, actualUrl, "succesful test case");
                Console.WriteLine("TC Completed Successfully");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the payment process");
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



        [TestMethod]
        public void InvalidExpireDatefield()
        {
            try {
                ShoppingCart_TestMethod shoppingCart = new ShoppingCart_TestMethod();
                shoppingCart.ShoppingMethod();


                CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


                Thread.Sleep(5000);

                CartPage usercartPage = new CartPage(ManageDriver.driver);


                usercartPage.EnterCardHolder("BatoolJarrah");
                usercartPage.EnterCardNumber("5555666677778907");
                usercartPage.EnterCvv("379");
                usercartPage.EnterExpireDate("2025-04");
                usercartPage.ClickPayButton();

                Thread.Sleep(5000);
                var expectedURL = "https://localhost:44349/User/PayForTheOrder";
                var actualUrl = ManageDriver.driver.Url;
                Assert.AreEqual(expectedURL, actualUrl, "succesful test case");
                Console.WriteLine("TC Completed Successfully");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the payment process");
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



        [TestMethod]
        public void ExpiredCard()
        {
            try {
                ShoppingCart_TestMethod shoppingCart = new ShoppingCart_TestMethod();
                shoppingCart.ShoppingMethod();



                CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


                Thread.Sleep(5000);

                CartPage usercartPage = new CartPage(ManageDriver.driver);


                usercartPage.EnterCardHolder("haneen");
                usercartPage.EnterCardNumber("5555666677778903");
                usercartPage.EnterCvv("363");
                usercartPage.EnterExpireDate("2023-12");
                usercartPage.ClickPayButton();

                Thread.Sleep(5000);
                var expectedURL = "https://localhost:44349/User/PayForTheOrder";
                var actualUrl = ManageDriver.driver.Url;
                Assert.AreEqual(expectedURL, actualUrl, "succesful test case");
                Console.WriteLine("TC Completed Successfully");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the payment process");
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



        [TestMethod]
        public void  RememberCart()
        {
            try
            {
                ShoppingCart_TestMethod shoppingCart = new ShoppingCart_TestMethod();
                shoppingCart.ShoppingMethod();


                CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


                Thread.Sleep(5000);

                CartPage usercartPage = new CartPage(ManageDriver.driver);


                usercartPage.EnterCardHolder("BatoolJarrah");
                usercartPage.EnterCardNumber("5555666677778907");
                usercartPage.EnterCvv("379");
                usercartPage.EnterExpireDate("2025-03");
                usercartPage.ClickRememberMeButton();
                usercartPage.ClickPayButton();

                Thread.Sleep(5000);

                var expectedURL = "https://localhost:44349/User/ShoppingCart";
                var actualUrl = ManageDriver.driver.Url;
                Assert.AreEqual(expectedURL, actualUrl, "succesful test case");
               

                CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");
                Thread.Sleep(5000);

                string actualCardHolder = usercartPage.GetCardHolder();
                string actualCardNumber = usercartPage.GetCardNumber();
                string actualCvv = usercartPage.GetCvv();
                string actualExpireDate = usercartPage.GetExpireDate();

                Assert.AreEqual("BatoolJarrah", actualCardHolder, "card holder name does not match");
                Assert.AreEqual("5555666677778907", actualCardNumber, "card number does not match");
                Assert.AreEqual("379", actualCvv, "CVV does not match.");
                Assert.AreEqual("2025-03", actualExpireDate, "expiration date does not match");

                Console.WriteLine("TC Completed Successfully: Card information is remembered succssfuly");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the payment process");
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



        [TestMethod]
        public void BackLinkWithWithoutFillFields()
        {
            try
            {
                ShoppingCart_TestMethod shoppingCart = new ShoppingCart_TestMethod();
                shoppingCart.ShoppingMethod();
            

				CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


                Thread.Sleep(5000);

                CartPage usercartPage = new CartPage(ManageDriver.driver);


                usercartPage.ClickBackLink();

                Thread.Sleep(5000);
                var expectedURL = "https://localhost:44349/User/ShoppingCart";
                var actualUrl = ManageDriver.driver.Url;
                Assert.AreEqual(expectedURL, actualUrl, "succesful test case");
                Console.WriteLine("TC Completed Successfully");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the payment process");
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



        [TestMethod]
        public void BackLinkWithFillFields()
        {
            try
            {
				ShoppingCart_TestMethod shoppingCart = new ShoppingCart_TestMethod();
				shoppingCart.ShoppingMethod();

				CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


                Thread.Sleep(5000);

                CartPage usercartPage = new CartPage(ManageDriver.driver);

                usercartPage.EnterCardHolder("BatoolJarrah");
                usercartPage.EnterCardNumber("5555666677778907");
                usercartPage.EnterCvv("379");
                usercartPage.EnterExpireDate("2025-03");
                usercartPage.ClickBackLink();

                Thread.Sleep(5000);
                var expectedURL = "https://localhost:44349/User/ShoppingCart";
                var actualUrl = ManageDriver.driver.Url;
                Assert.AreEqual(expectedURL, actualUrl, "succesful test case");
                Console.WriteLine("TC Completed Successfully");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the payment process");
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



        [TestMethod]
        public void EmptyCard()
        {
            try
            {
                ShoppingCart_TestMethod shoppingCart = new ShoppingCart_TestMethod();
                shoppingCart.ShoppingMethod();


                CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


                Thread.Sleep(5000);

                CartPage usercartPage = new CartPage(ManageDriver.driver);


                usercartPage.EnterCardHolder(" ");
                usercartPage.EnterCardNumber(" ");
                usercartPage.EnterCvv(" ");
                usercartPage.EnterExpireDate(" ");
                usercartPage.ClickPayButton();

                Thread.Sleep(5000);
                var expectedURL = "https://localhost:44349/User/PayForTheOrder";
                var actualUrl = ManageDriver.driver.Url;
                Assert.AreEqual(expectedURL, actualUrl, "succesful test case");
                Console.WriteLine("TC Completed Successfully");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the payment process");
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




        [TestMethod]
        public void CardWithInsufficientBalance()
        {
            try
            {
                ShoppingCart_TestMethod shoppingCart = new ShoppingCart_TestMethod();
                shoppingCart.ShoppingMethod();
              

				CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


                Thread.Sleep(5000);

                CartPage usercartPage = new CartPage(ManageDriver.driver);


                usercartPage.EnterCardHolder("Iyad Mohammad");
                usercartPage.EnterCardNumber("8765432187654321");
                usercartPage.EnterCvv("844");
                usercartPage.EnterExpireDate("2026-01");
                usercartPage.ClickPayButton();

                Thread.Sleep(5000);

                IWebElement errorMessageElement = ManageDriver.driver.FindElement(By.XPath("/html/body/div[1]/section[2]/div/div/div/div/form/span/div/ul/li"));

                var expectedMessage = "Transaction rejected, insufficient balance";
                var actualMessage = errorMessageElement.Text;
                Assert.AreEqual(expectedMessage, actualMessage, "The error message does not match the expected result");
                Console.WriteLine("TC Completed Successfully");
            }
            catch (NoSuchElementException ex)
            {

                Console.WriteLine("Element not found: " + ex.Message);
                Assert.Fail("Element not found during the payment process");
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

        [TestMethod]
		public void InvalidFormatCardNumberfield()
		{
			try
			{
                ShoppingCart_TestMethod shoppingCart = new ShoppingCart_TestMethod();
                shoppingCart.ShoppingMethod();

              

				CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


				Thread.Sleep(5000);

				CartPage usercartPage = new CartPage(ManageDriver.driver);


				usercartPage.EnterCardHolder("BatoolJarrah");
				usercartPage.EnterCardNumber("876543217guikjb");
				usercartPage.EnterCvv("379");
				usercartPage.EnterExpireDate("2025-03");
				usercartPage.ClickPayButton();

				Thread.Sleep(5000);
				var expectedURL = "https://localhost:44349/User/PayForTheOrder";
				var actualUrl = ManageDriver.driver.Url;
				Assert.AreEqual(expectedURL, actualUrl, "succesful test case");
				Console.WriteLine("TC Completed Successfully");
			}
			catch (NoSuchElementException ex)
			{

				Console.WriteLine("Element not found: " + ex.Message);
				Assert.Fail("Element not found during the payment process");
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

        [TestMethod]
		public void InvalidFormatCvvfield()
		{
			try
			{
                ShoppingCart_TestMethod shoppingCart = new ShoppingCart_TestMethod();
                shoppingCart.ShoppingMethod();



                CommonMethods.NavigateToURL("https://localhost:44349/User/PayForTheOrder");


				Thread.Sleep(5000);

				CartPage usercartPage = new CartPage(ManageDriver.driver);


				usercartPage.EnterCardHolder("BatoolJarrah");
				usercartPage.EnterCardNumber("5555666677778907");
				usercartPage.EnterCvv("3794");
				usercartPage.EnterExpireDate("2025-03");
				usercartPage.ClickPayButton();

				Thread.Sleep(5000);
				var expectedURL = "https://localhost:44349/User/PayForTheOrder";
				var actualUrl = ManageDriver.driver.Url;
				Assert.AreEqual(expectedURL, actualUrl, "succesful test case");
				Console.WriteLine("TC Completed Successfully");
			}
			catch (NoSuchElementException ex)
			{

				Console.WriteLine("Element not found: " + ex.Message);
				Assert.Fail("Element not found during the payment process");
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
