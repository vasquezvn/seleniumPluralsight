using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.es";

            var searchBox = driver.FindElement(By.Id("lst-id"));
            searchBox.SendKeys("pluralsight");
            searchBox.Submit();

            var imagesLink = driver.FindElement(By.ClassName("qs"));
            imagesLink.Click();

            var divContainer = driver.FindElement(By.Id("rg"));
            var imageLink = divContainer.FindElements(By.ClassName("rg_1"))[0];
            imageLink.Click();

        }
    }
}
