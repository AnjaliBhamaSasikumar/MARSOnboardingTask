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
    public class SignIn
    {
        public void SignInActions(IWebDriver driver)
        {
            // open chrome browser
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //Identify SignIn button and open
            IWebElement SignIn = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            SignIn.Click();
            try
            {
                //Identify username text box
                IWebElement UserNameTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                UserNameTextBox.SendKeys("anjalibs@gmail.com");

                // Identify password text box
                IWebElement PasswordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                PasswordTextBox.SendKeys("Intern2022");

                //Identify login button and click on it
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                LoginButton.Click();
                WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//div/div[1]/div[2]/div/span");
                //Thread.Sleep(3000);
            }

            catch(Exception ex)
            {
                Assert.Fail("SignIn Failed", ex.Message);
            }

            
            WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//div/div[1]/div[2]/div/span");
        }

        
    }
}
