using EMEA_GOP.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EMEA_GOP.Amazone
{
    internal class AmazonePage
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            //Given I open Google Chrome browser
            driver = new ChromeDriver("C:\\Users\\chand\\source\\repos\\EMEA_GOP\\EMEA_GOP\\Driver");
            driver.Manage().Window.Maximize();
       
        }
        [Test]
        public void VerifyAmazoneHomepage()
        {
            //When I hit url as www.Amazon.com
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            IWebElement Logo = driver.FindElement(By.XPath("//*[@id=\"nav-logo-sprites\"]"));
            Assert.IsTrue(Logo.Displayed);
            //Then Amazon home page should appear
           
        }

        [Test]
        public void verifyMainMenu()
        {
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            IWebElement Menu = driver.FindElement(By.XPath("//*[@id=\"nav-main\"]"));
            Assert.IsTrue(Menu.Displayed);
        }

        [Test]
        public void VerifySearchBox()
        {
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            IWebElement Search = driver.FindElement(By.XPath("//*[@id=\"twotabsearchtextbox\"]"));
            Search.SendKeys("mobile");
            IWebElement BtnSearch = driver.FindElement(By.XPath("//*[@id=\"nav-search-bar-form\"]/div[3]"));
            BtnSearch.Click();
        }
        [Test]
        public void PurchesProcess()
        {
            
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            IWebElement lnkSignIn = driver.FindElement(By.XPath("//*[@id=\"nav-link-accountList-nav-line-1\"]"));
            lnkSignIn.Click();
            IWebElement BtnLogIn = driver.FindElement(By.XPath("//*[@id=\"ap_email\"]"));
            BtnLogIn.SendKeys("8917346658");
            IWebElement BtnContinue = driver.FindElement(By.XPath("//*[@id=\"continue\"]"));
            BtnContinue.Click();
            IWebElement BtnPassward = driver.FindElement(By.XPath("//*[@id=\"ap_password\"]"));
            BtnPassward.SendKeys("Chandra.655");
            IWebElement BtnEnter = driver.FindElement(By.XPath("//*[@id=\"signInSubmit\"]"));
            BtnEnter.Click();
            IWebElement Search = driver.FindElement(By.XPath("//*[@id=\"twotabsearchtextbox\"]"));
            Search.Clear();
            Search.SendKeys("mobile");
            IWebElement BtnSearch = driver.FindElement(By.XPath("//*[@id=\"nav-search-bar-form\"]/div[3]"));
            BtnSearch.Click();
            IWebElement BtnSamsung = driver.FindElement(By.XPath("//*[@id=\"p_89/Samsung\"]/span/a/span"));
            BtnSamsung.Click();
            IWebElement NewMobile = driver.FindElement(By.XPath("//*[@id=\"search\"]/div[1]/div[1]/div/span[1]/div[1]/div[9]/div/div/div/div/div/div[1]/div/div[2]/div/span/a/div/img"));
            NewMobile.Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            IWebElement BtnBuyNow = driver.FindElement(By.XPath("//span[@id='submit.buy-now']"));
            BtnBuyNow.Click();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            IWebElement otherMobile = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/div/span[1]/div[1]/div[10]/div/div/div/div/div/div[1]/div/div[2]/div/span/a/div"));
            otherMobile.Click();
            driver.SwitchTo().Window(driver.WindowHandles[2]);
        }



    }
}


