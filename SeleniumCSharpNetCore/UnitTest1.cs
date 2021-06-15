using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpNetCore
{
    public class Tests
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver(@"C:\chromedriver_win32"); 
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
            IWebElement controller = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
            controller.Clear();
            controller.SendKeys("Almond");
            Assert.Pass();
        }
    }
}