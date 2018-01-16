using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;

namespace WebDriverScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://login.yahoo.com/");

                var userNameField = driver.FindElementById("login-username");
                userNameField.SendKeys("TestCase60");
                var nextButton = driver.FindElementById("login-signin");
                nextButton.Click();

                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("login-passwd")));

                var userPasswordField = driver.FindElementById("login-passwd");
                userPasswordField.SendKeys("waterfire1234");
                var signinButton = driver.FindElementById("login-signin");
                signinButton.Click();

                //var result = driver.FindElementByXPath("//div[@id ='case_login']/h3").Text;

                //File.WriteAllText("result.txt", result);

                driver.GetScreenshot().SaveAsFile(@"screen.png", ScreenshotImageFormat.Png);

            }
        }
    } 
}
