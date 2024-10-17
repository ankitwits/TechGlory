using TechGlory.Factory;

namespace TechGlory.Drivers
{
    internal class Browserfactory
    {
        public static IBrowser GetBrowser(string browserType) 
        {
            switch (browserType.ToLower()) 
            {
                case "chrome":
                    return new ChromeBrowser();

                case "Edge":
                    return new EdgeBrowser();
                default:
                    throw new ArgumentException();           
            
            
            }
        
        
        
        }

    }
}
