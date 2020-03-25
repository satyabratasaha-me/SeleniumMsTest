using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UISpecs
{
    [TestClass]
    public class E2ETests
    {
        static ChromeDriver driver;

        [TestMethod]
        public void Test1()
        {
            driver.FindElement(By.XPath("//*[@class='sb-globalNav__links ']//a[text()='Sign in']")).Click();
            var actualForgotYourPassword = driver.FindElement(By.XPath("//a[@data-e2e='forgotPasswordLink']")).Text;
            var expectedForgotYourPassword = "Forgot your password?";
            Assert.IsTrue(actualForgotYourPassword.Equals(expectedForgotYourPassword), "Forgot Your Password Link No Found on Page");

        }

        [TestMethod]
        public void Test2()
        {
            driver.FindElement(By.XPath("//*[@class='sb-globalNav__links ']//a[text()='Sign in']")).Click();
            var actualForgotYourPassword = driver.FindElement(By.XPath("//a[@data-e2e='forgotPasswordLink']")).Text;
            var expectedForgotYourPassword = "Forgot your password?";
            Assert.IsTrue(actualForgotYourPassword.Equals(expectedForgotYourPassword), "Forgot Your Password Link No Found on Page");

        }

        [ClassCleanup]
        public static void AfterAllTests()
        {
            driver.Close();
            driver.Quit();
        }

        [ClassInitialize]
        public static void BeforeAllTests(TestContext testContext)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.starbucks.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TestInitialize]
        public void BeforeEachTest()
        {
            driver.Navigate().GoToUrl("https://www.starbucks.com/");
          
        }
    }
}
