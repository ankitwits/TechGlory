using OpenQA.Selenium;

namespace Techglorytest.Factory
{
    internal interface IBrowser
    {
        IWebDriver createdriver(); //method to create driver instance 
    }
}
