using MarsTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsTest.Pages
{
    public class SignIn : CommonDriver
    {
       
        IWebElement SignInButton => driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
        IWebElement UserNameTextBox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        IWebElement LoginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        IWebElement PasswordTextBox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));

        public void SignInActions()
        {
            

            try
            {
                //Identify SignIn button and open                
                SignInButton.Click();

                //Identify username text box
                UserNameTextBox.SendKeys("anjalibs@gmail.com");

                // Identify password text box 
                PasswordTextBox.SendKeys("Intern2022");

                //Identify login button and click on it
                LoginButton.Click();
                WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//div/div[1]/div[2]/div/span");
                
            }

            catch(Exception ex)
            {
                Assert.Fail("SignIn Failed", ex.Message);
            }

            
            WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//div/div[1]/div[2]/div/span");
        }

        
    }
}
