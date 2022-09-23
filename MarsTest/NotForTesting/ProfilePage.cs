using MarsTest.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace MarsTest.NotForTesting
{
    public class ProfilePage
    {

        //public void Description(IWebDriver driver)
        //{
        //    //Click Description Text
        //    IWebElement EditDescription = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        //    EditDescription.Click();
        //    //Enter Description details
        //    IWebElement EnterText = driver.FindElement(By.Name("value"));
        //    EnterText.Click();
        //    EnterText.Clear();
        //    EnterText.SendKeys("I am looking for a Test Analyst Job");
        //    //Save Description button
        //    IWebElement SaveDescription = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
        //    SaveDescription.Click();
        //    Thread.Sleep(3000);
        //    WaitHelpers.WaitToExist(driver, 5, "XPath", "//span[contains(text(),'I am looking for a Test Analyst Job')]");
        //}
        //public string GetDescription(IWebDriver driver)
        //{
        //    IWebElement newText = driver.FindElement(By.XPath("//span[contains(text(),'I am looking for a Test Analyst Job')]"));
        //    return newText.Text;
        //}


        public void Education(IWebDriver driver)
        {
            IWebElement Education = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            Education.Click();
            IWebElement AddNewEd = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            AddNewEd.Click();
            IWebElement CollegeName = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            CollegeName.SendKeys("Amrita School of Engineering");
            IWebElement CountryofCollege = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            CountryofCollege.Click();
            IWebElement SelectCountry = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
            SelectCountry.Click();
            IWebElement Title = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            Title.Click();
            IWebElement SelectTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[8]"));
            SelectTitle.Click();
            IWebElement Degree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            Degree.SendKeys("Power Electronics");
            IWebElement YearofGraduation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            YearofGraduation.Click();
            IWebElement SelectYoG = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[12]"));
            SelectYoG.Click();
            IWebElement AddCollege = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddCollege.Click();
        }
        public void Certifications(IWebDriver driver)
        {
            IWebElement Certification = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            Certification.Click();
            IWebElement AddNewCer = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            AddNewCer.Click();
            IWebElement Certificate = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            Certificate.SendKeys("Test Analyst");
            IWebElement CertifiedFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            CertifiedFrom.SendKeys("Industry Connect");
            IWebElement Year = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            Year.Click();
            IWebElement SelectYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));
            SelectYear.Click();
            IWebElement AddCertification = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            AddCertification.Click();
        }
        public void Profile(IWebDriver driver)
        {
            IWebElement ViewProfile = driver.FindElement(By.XPath("//div/section[1]/div/a[2]"));
            ViewProfile.Click();
        }
    }
}
