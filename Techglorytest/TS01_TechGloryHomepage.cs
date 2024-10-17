using OpenQA.Selenium;
using TechGlory.Drivers;
using System.Configuration;
using System.Reflection;
using TechGlory.Factory;
namespace TechGlory

{
    [TestClass]
    public class TS01_TechGloryHomepage
    {
        public static IWebDriver driver { get; set; }
        [TestMethod]
        public void TestMethod1()
        {
            IBrowser browsertype = Browserfactory.GetBrowser("chrome");            
            driver = browsertype.createdriver();
            driver.Navigate().GoToUrl("https://techglory.godaddysites.com/");
            //driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["url"]);


        }
    }
}