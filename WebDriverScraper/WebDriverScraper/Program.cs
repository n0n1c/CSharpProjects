using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriverScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://testing-ground.scraping.pro/login");

                var userNameField = driver.FindElementById("usr");
                var userPaswordField = driver.FindElementById("pwd");
                var loginButton = driver.FindElementByXPath("//input[@value='Login']");

                userNameField.SendKeys("admin");
                userPaswordField.SendKeys("12345");

                loginButton.Click();

                var result = driver.FindElementByXPath("//div[@id ='case_login']/h3").Text;

                File.WriteAllText("result.txt", result);

                driver.GetScreenshot().SaveAsFile(@"screen.png", ScreenshotImageFormat.Png);

            }
        }
    }
}
