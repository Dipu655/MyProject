using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMEA_GOP
{
    internal class DSA
    {
        [Test]
        public void Close()
        {
            IWebDriver driver = new FirefoxDriver();

            //Launch the ToolsQA Website
            driver.Url = "https://demoqa.com/frames-and-windows/";

            driver.FindElement(By.XPath(".//*[@id='tabs-1']/div/p/a")).Click();
            driver.Close();

        }
    }
}

