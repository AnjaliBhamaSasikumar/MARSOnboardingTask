using MarsTest.Utilities;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsTest.Pages
{
    public class SkillPage
    {
        public void CreateSkills(IWebDriver driver, string Skill, string Level)
        {
            //Add Skills
            IWebElement Skills = driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
            Skills.Click();
            IWebElement AddNewSki = driver.FindElement(By.XPath("//thead/tr[1]/th[3]/div[1]"));
            AddNewSki.Click();
            IWebElement TextSkill = driver.FindElement(By.Name("name"));
            TextSkill.SendKeys(Skill);
            SelectElement ChooseLevelSki = new SelectElement(driver.FindElement(By.Name("level")));
            ChooseLevelSki.SelectByValue(Level);
            IWebElement AddSkill = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));
            AddSkill.Click();
        }
        public string createskills(IWebDriver driver)
        {
            Thread.Sleep(3000);
            //WaitHelpers.WaitToExist(driver, 3, "XPath", "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]");
            IWebElement newskill = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]"));
            return newskill.GetAttribute("outerText").ToString();

        }
        public void Editskill(IWebDriver driver, string Skill, string Level)
        {
            IWebElement LanguageTab = driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
            LanguageTab.Click();
            //Click Edit language button
            Thread.Sleep(3000);
            IWebElement Languageedit = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]"));
            Languageedit.Click();
            //Edit Language textbox
            IWebElement Langugetextbox = driver.FindElement(By.Name("name"));
            Langugetextbox.Clear();
            Langugetextbox.SendKeys(Skill);
            //Edit Language Level
            SelectElement Languageleveledit = new SelectElement(driver.FindElement(By.Name("level")));
            Languageleveledit.SelectByValue(Level);
            //Click Update button
            Thread.Sleep(3000);
            IWebElement updatebutton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            updatebutton.Click();

        }
        public string Getskill(IWebDriver driver)
        {
            Thread.Sleep(3000);
            //WaitHelpers.WaitToExist(driver, 5, "XPath", "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]");
            IWebElement firstskill = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]"));
            return firstskill.GetAttribute("outerText").ToString();
        }

        public void DeleteSkill(IWebDriver driver)
        {
            IWebElement LanguageTab = driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
            LanguageTab.Click();
            IWebElement deletelastrow = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[3]/span[2]/i[1]"));
            deletelastrow.Click();
            IWebElement deletethirdrow = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[3]/tr[1]/td[3]/span[2]/i[1]"));
            deletethirdrow.Click();
            //driver.Navigate().Refresh();
            WaitHelpers.WaitToBeClickable(driver, 10, "XPath", "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[3]/span[2]/i[1]");
            IWebElement deletesecondrow = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[3]/span[2]/i[1]"));
            deletesecondrow.Click();
            IWebElement deletefirstrow = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            deletefirstrow.Click();

        }

        public string deleteskills(IWebDriver driver)
        {
            Thread.Sleep(3000);
            //WaitHelpers.WaitToExist(driver, 5, "XPath", "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]");
            IWebElement lastskill = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]"));
            return lastskill.GetAttribute("outerText").ToString();

        }
    }
}
