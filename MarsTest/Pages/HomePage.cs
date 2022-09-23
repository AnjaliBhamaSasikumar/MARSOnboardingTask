using MarsTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace MarsTest.Pages
{
    public class HomePage : CommonDriver
    {
        IWebElement element => driver.FindElement(By.XPath("//div/div[1]/div[2]/div/span"));
        IWebElement GoToProfile => driver.FindElement(By.XPath("//div/div[1]/div[2]/div/span/div/a[1]"));

        public void GoToProfilePage()
        {
            try
            {
                //Move mouse to Hi Anjali
                WaitHelpers.WaitToExist(driver, 5, "XPath", "//div/div[1]/div[2]/div/span");
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                
                // Identify and Click GoToProfile 
                GoToProfile.Click();
                WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i");
            }
            catch(Exception ex)
            {
                Assert.Fail("Go to Profile not available", ex.Message);
            }
           
        }
    }
}
