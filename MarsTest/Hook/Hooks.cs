using MarsTest.Utilities;
using TechTalk.SpecFlow;

namespace MarsTest.Hook
{
    [Binding]
    public sealed class Hooks : CommonDriver 
    {
        //IWebDriver driver = new ChromeDriver();
        public Hooks()
        {
            driver = new ChromeDriver();
        }
        [BeforeScenario]
        public void BeforeScenario()
        {

            
            driver.Manage().Window.Maximize();
            driver.Url = "http://localhost:5000/Home";

        }


        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();

        }
    }
}