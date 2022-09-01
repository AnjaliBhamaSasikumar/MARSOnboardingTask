using MarsTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace MarsTest.Pages
{
    public class HomePage
    {
        public void GoToProfile(IWebDriver driver)
        {
            try
            {
                //Move mouse to Hi Anjali
                Actions action = new Actions(driver);
                IWebElement element = driver.FindElement(By.XPath("//div/div[1]/div[2]/div/span"));
                action.MoveToElement(element).Perform();
                ////a.MoveToElement(driver.FindElement(By.XPath("//div/div[1]/div[2]/div/span")));
                //action.MoveToElement(driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/span")));
                //action.Click();
                //action.Perform();
                IWebElement GoToProfile = driver.FindElement(By.XPath("//div/div[1]/div[2]/div/span/div/a[1]"));
                GoToProfile.Click();
                //Thread.Sleep(3000);
                WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i");
            }
            catch(Exception ex)
            {
                Assert.Fail("Go to Profile not available", ex.Message);
            }
           
        }
    }
}
