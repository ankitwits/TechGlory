using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechGlory.Drivers;
using TechGlory.Factory;

namespace TechGlory.Drivers
{
    internal class ChromeBrowser : IBrowser
    {
        public IWebDriver createdriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--starts");
            return new ChromeDriver(options);
        }
    }
}
