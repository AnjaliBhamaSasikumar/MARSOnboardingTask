using MarsTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MarsTest.Pages
{
    public class DescriptionPage : CommonDriver
    {
                
        IWebElement EditDescription => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        IWebElement EnterText => driver.FindElement(By.Name("value"));
        IWebElement SaveDescription => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
        IWebElement newText => driver.FindElement(By.XPath("//span[contains(text(),'I am a Test Analyst')]"));


        public void AddDescription()
        {
            WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i");
            // Identify and Click Edit Description
            EditDescription.Click();
            
            //Identify and Click Description Text Box and send keys
            EnterText.Click();
            EnterText.Clear();
            EnterText.SendKeys("I am a Test Analyst");

            // Identify and Click Save Description button
            SaveDescription.Click();
            WaitHelpers.WaitToExist(driver, 5, "XPath", "//span[contains(text(),'I am a Test Analyst')]");
        }
        public string GetDescription()
        {
            return newText.Text;
            //driver.Quit();
        }
    }
}
