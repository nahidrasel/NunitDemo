
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UiTestProject
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void CheckLogin()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            // var loginButtonLocator = driver.FindElement(By.ClassName("login-button"));

            // WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(10));

            // IWebElement login = wait.Until(driver => loginButton);

            var username = driver.FindElement(By.Name("user-name"));

            username.SendKeys("standard_user");
            var password = driver.FindElement(By.Name("password"));
            password.SendKeys("secret_sauce");
            var loginButton = driver.FindElement(By.Id("login-button"));
            loginButton.Submit();
            Assert.IsTrue(driver.Url.Contains("inventory.html"));

            driver.Quit();
        }
    }
}
