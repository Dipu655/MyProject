using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMEA_GOP
{
    internal class DELLDOTCOM
    {
        IWebDriver Driver;
        [SetUp]
        public void Verify_Eleminets()
        {
            Driver = new ChromeDriver("C:\\Users\\chand\\source\\repos\\EMEA_GOP\\EMEA_GOP\\Driver");
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void Verify_CheckBox()
        {
            Driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            IWebElement element = Driver.FindElement(By.XPath("//*[@id=\"tree-node\"]/ol/li/span/label/span[1]"));
            element.Click();
            IWebElement Show = Driver.FindElement(By.XPath("//*[@id=\"result\"]"));
            Assert.IsTrue(Show.Displayed);
        }
        [Test]
        public void Verify_RedioButten()
        {
            Driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
            IWebElement btnRedio = Driver.FindElement(By.XPath("//*[@id=\"item-2\"]/span"));
            btnRedio.Click();
            IWebElement yesRedio = Driver.FindElement(By.Id("yesRadio"));
            yesRedio.Click();
            Assert.IsTrue(yesRedio.Selected);
            IWebElement btnImpressive = Driver.FindElement(By.Id("impressiveRadio"));
            Assert.IsTrue(btnImpressive.Selected);

        }
        [Test]
        public void To_Verify_WebTable()

        {
            Driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            IWebElement btnWebTable = Driver.FindElement(By.XPath("//span[contains(text(),'Web Tables')]"));
            btnWebTable.Click();
        }
        [Test]
        public void To_Verify_Buttons()
        {

            Driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            Actions action = new Actions(Driver);
            IWebElement btnDoubleClickMe = Driver.FindElement(By.Id("doubleClickBtn"));
            action.DoubleClick(btnDoubleClickMe).Perform();
            IWebElement text = Driver.FindElement(By.Id("doubleClickMessage"));
            Assert.IsTrue(text.Displayed);
            IWebElement btnRightClickMe = Driver.FindElement(By.Id("rightClickBtn"));
            action.ContextClick(btnRightClickMe).Perform();
            IWebElement lblRightClicl = Driver.FindElement(By.Id("rightClickMessage"));
            Assert.IsTrue(lblRightClicl.Displayed);
            IWebElement btnClickMe = Driver.FindElement(By.XPath("(//button[contains(text(),'Click Me')])[3]"));
            action.Click(btnClickMe).Perform();
            IWebElement lblClick = Driver.FindElement(By.Id("dynamicClickMessage"));
            Assert.IsTrue(lblClick.Displayed);



        }
        [Test]
        public void To_verify_Link()
        {
            Driver.Navigate().GoToUrl("https://demoqa.com/links");
            IWebElement lblHome = Driver.FindElement(By.Id("simpleLink"));
            lblHome.Click();
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            Driver.Close();
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            IWebElement lblHomelkZud = Driver.FindElement(By.Id("dynamicLink"));
            lblHomelkZud.Click();
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            Driver.Close();
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            IWebElement btnCreated = Driver.FindElement(By.Id("created"));
            btnCreated.Click();
            IWebElement btn = Driver.FindElement(By.Id("linkResponse"));
            Assert.IsTrue(btn.Displayed);
            IWebElement btnNo_Content = Driver.FindElement(By.Id("no-content"));
            btnNo_Content.Click();
            IWebElement Text = Driver.FindElement(By.Id("linkResponse"));
            Assert.IsTrue(Text.Displayed);
            IWebElement btnMoved = Driver.FindElement(By.Id("moved"));
            btnMoved.Click();
            IWebElement Text1 = Driver.FindElement(By.Id("linkResponse"));
            Assert.IsTrue(Text1.Displayed);
            IWebElement btnBad_Request = Driver.FindElement(By.Id("bad-request"));
            btnBad_Request.Click();
            IWebElement Text2 = Driver.FindElement(By.Id("linkResponse"));
            Assert.IsTrue(Text2.Displayed);
            IWebElement btnUnauthorized = Driver.FindElement(By.Id("unauthorized"));
            btnUnauthorized.Click();
            IWebElement Text3 = Driver.FindElement(By.Id("linkResponse"));
            Assert.IsTrue(Text3.Displayed);
            IWebElement btnForbidden = Driver.FindElement(By.Id("forbidden"));
            btnForbidden.Click();
            IWebElement Text4 = Driver.FindElement(By.Id("linkResponse"));
            Assert.IsTrue(Text4.Displayed);
            IWebElement btnNot_Found = Driver.FindElement(By.Id("invalid-url"));
            btnNot_Found.Click();
            IWebElement Text5 = Driver.FindElement(By.Id("linkResponse"));
            Assert.IsTrue(Text.Displayed);
        }
        [Test]
        public void To_Verify_BrokenLinls_And_Image()
        {
            Driver.Navigate().GoToUrl("https://demoqa.com/broken");
            IWebElement btnBrokenImage = Driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[2]/div[2]/p[2]"));
           Assert.IsTrue(btnBrokenImage.Displayed);
            IWebElement btnValid_link = Driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[2]/div[2]/p[3]"));
            Assert.IsTrue(btnValid_link.Displayed);
            IWebElement btnClick_Here_For_valid_Link = Driver.FindElement(By.XPath(""));
            btnClick_Here_For_valid_Link.Click();
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);

        }
        [Test]
        public void To_Verify_Up_Load_And_Down_Load()
        {
            Driver.Navigate().GoToUrl("https://demoqa.com/upload-download");

        }
        [Test]
        public void To_Verify_Dynamic_Properties()
        {
            Driver.Navigate().GoToUrl("https://demoqa.com/dynamic-properties");

        }
    }
}
