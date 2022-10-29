using EMEA_GOP.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EMEA_GOP
{

    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver("C:\\Users\\chand\\source\\repos\\EMEA_GOP\\EMEA_GOP\\Driver\\");
            driver.Manage().Window.Maximize();
        }
 
        [Test]
        public void VerifySubmitbuttamAsExpected()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/elements");
            IWebElement textbox = driver.FindElement(By.XPath("//*[@id=\"item-0\"]/span"));
            textbox.Click();
            IWebElement txtFullname = driver.FindElement(By.Id("userName"));
            txtFullname.SendKeys("Chandrakanta");
            IWebElement txtEmail = driver.FindElement(By.Id("userEmail"));
            txtEmail.SendKeys("chanddra.k.khuntia@gmail.com");
            IWebElement txtCurrentAdress = driver.FindElement(By.Id("currentAddress"));
            txtCurrentAdress.SendKeys("Banglore");
            IWebElement txtPermeantadress = driver.FindElement(By.Id("permanentAddress"));
            txtPermeantadress.SendKeys("Odisha");
            IWebElement btnSubmit = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/form/div[5]/div/button"));
            btnSubmit.Click();
        }
        [Test]
        public void ValidateTextbox()
        {
            Utiliyes utiliyes = new Utiliyes();
            driver.Navigate().GoToUrl("https://demoqa.com/elements");
            IWebElement textbox = driver.FindElement(By.XPath("//*[@id=\"item-0\"]/span"));
            textbox.Click();
            IWebElement txtFullname = driver.FindElement(By.Id("userName"));
            txtFullname.SendKeys(utiliyes.RandomString(20));
            IWebElement txtEmail = driver.FindElement(By.Id("userEmail"));
            txtEmail.SendKeys("chanddra.k.khuntia@gmail.com");
            IWebElement txtCurrentAdress = driver.FindElement(By.Id("currentAddress"));
            txtCurrentAdress.SendKeys("Banglore");
            IWebElement txtPermeantadress = driver.FindElement(By.Id("permanentAddress"));
            txtPermeantadress.SendKeys(utiliyes.RandomString(200));
            //IWebElement btnSubmit = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/form/div[5]/div/button"));
            //btnSubmit.Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            //driver.Close();
        }
    }



}
