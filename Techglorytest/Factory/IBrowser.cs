using OpenQA.Selenium;

namespace TechGlory.Factory
{
    internal interface IBrowser
    {
        IWebDriver createdriver(); //method to create driver instance 
    }
}
