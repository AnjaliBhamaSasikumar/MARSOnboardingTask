

using NUnit.Framework;

namespace MarsTest.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://localhost:5000/Home";
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
