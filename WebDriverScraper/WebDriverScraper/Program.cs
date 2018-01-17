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
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("--ignore-ssl-errors");


            using (var driver = new ChromeDriver(options))
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

                driver.Navigate().GoToUrl("https://finance.yahoo.com/portfolio/p_0/view/v1");

                IWebElement element2 = wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='main']")));

                var result = driver.FindElementByXPath("//*[@id='main']/section/section[2]/div[2]/table/tbody").Text;

                Console.WriteLine(result);

                File.WriteAllText("result.txt", result);

                driver.GetScreenshot().SaveAsFile(@"screen.png", ScreenshotImageFormat.Png);

            }
        }
    } 
}
