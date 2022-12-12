using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EMEA_GOP.FirefoxAutomate
{
    internal class FirefoxeAuto
    {
        IWebDriver driver;


        [SetUp]
        public void setup()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void Verify_Get_Page_Title_name_and_Title_length()
        {
            driver.Navigate().GoToUrl("http://DemoQA.com");
            string titels = driver.Title;
            
            
            
            Assert.AreEqual("ToolsQA", titels, "Title is not matching");

        }
        [Test]
        public void Page_URL_and_Page_Url_Length()
        {
            driver.Navigate().GoToUrl("http://DemoQA.com");
            string Url = driver.Url;
            Console.WriteLine(Url + Url.Length);
        }
        [Test]
        public void Page_Source_and_Page_Source_length()
        {
            FirefoxeAuto firefoxeAuto = new FirefoxeAuto();
            firefoxeAuto.Verify_Stource_Code(driver);
        }
        public void Verify_Stource_Code(IWebDriver _driver)
        {
            _driver.Navigate().GoToUrl("http://DemoQA.com");
            string Source = _driver.PageSource;
            Console.WriteLine(Source + Source.Length);
            _driver.Navigate().Back();
            _driver.Navigate().Forward();
            _driver.Navigate().Refresh();
            _driver.Close();

        }
        //[Test]
        //public void 
    }
}
