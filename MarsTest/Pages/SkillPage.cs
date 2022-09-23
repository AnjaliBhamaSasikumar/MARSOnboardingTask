using MarsTest.Utilities;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsTest.Pages
{
    public class SkillPage : CommonDriver
    {
        IWebElement Skills => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
        
        IWebElement AddNewSki => driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        IWebElement TextSkill => driver.FindElement(By.Name("name"));
        SelectElement ChooseLevelSki => new SelectElement(driver.FindElement(By.Name("level")));
        IWebElement AddSkill => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));
        IWebElement skilledit => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]"));
        IWebElement updatebutton => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
        IWebElement deletelastrow => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[3]/span[2]/i[1]"));
        IWebElement deletethirdrow => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[3]/tr[1]/td[3]/span[2]/i[1]"));
        IWebElement deletesecondrow => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[3]/span[2]/i[1]"));
        
        IWebElement deletefirstrow => driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));

        public void CreateSkills(string Skill, string Level)
        {
            //Identify and click Skills tab
            Skills.Click();
            //Identify and click new skills add button            
            AddNewSki.Click();
            //Identify and click skill textbox
            TextSkill.SendKeys(Skill);
            //Identify and choose skill level
            ChooseLevelSki.SelectByValue(Level);
            //Identify and click add skill button
            AddSkill.Click();
        }

        public string createskills()
        {
            Thread.Sleep(3000);
            
            IWebElement newskill = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]"));
            return newskill.GetAttribute("outerText").ToString();

        }
        public void Editskill(string Skill, string Level)
        {
            Skills.Click();

            //Click Edit Skill button
            
            skilledit.Click();

            //Edit Language textbox
            TextSkill.Clear();
            TextSkill.SendKeys(Skill);

            //Edit Language Level
            ChooseLevelSki.SelectByValue(Level);

            //Click Update button
            //Thread.Sleep(3000);
            updatebutton.Click();

        }
        public string Getskill()
        {
            Thread.Sleep(3000);
            
            IWebElement firstskill = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]"));
            return firstskill.GetAttribute("outerText").ToString();
        }

        public void DeleteSkill()
        {
            Skills.Click();
            deletelastrow.Click();
            deletethirdrow.Click();
            
            WaitHelpers.WaitToBeClickable(driver, 10, "XPath", "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[3]/span[2]/i[1]");
            deletesecondrow.Click();
            deletefirstrow.Click();

        }

        public string deleteskills()
        {
            Thread.Sleep(3000);
            
            IWebElement lastskill = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]"));
            return lastskill.GetAttribute("outerText").ToString();

        }
    }
}
