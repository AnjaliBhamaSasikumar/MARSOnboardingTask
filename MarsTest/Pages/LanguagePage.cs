﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsTest.Utilities;
using OpenQA.Selenium.Support.UI;

namespace MarsTest.Pages
{
    public class LanguagePage : CommonDriver
    {
        IWebElement LanguageTab => driver.FindElement(By.LinkText("Languages"));
        IWebElement AddNewLan => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        IWebElement TextLanguage => driver.FindElement(By.Name("name"));
        SelectElement LanguageLevel => new SelectElement(driver.FindElement(By.Name("level")));
        IWebElement AddLanguage => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        IWebElement Languageedit => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]"));
        //IWebElement Langugetextbox = driver.FindElement(By.Name("name"));
        //SelectElement Languageleveledit = new SelectElement(driver.FindElement(By.Name("level")));
        IWebElement updatebutton => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));
        IWebElement deletelastrow => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[3]/span[2]"));
        IWebElement deletethirdrow => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[3]/tr[1]/td[3]/span[2]"));
        IWebElement deletesecondrow => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[3]/span[2]"));
        IWebElement deletefirstrow => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]"));

        public void CreateLanguage(string Language, string Level)
        {
            //Click Language Tab
            WaitHelpers.WaitToBeClickable(driver, 5, "LinkText", "Languages");
            LanguageTab.Click();

            // Add NewLanguage
            WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
            AddNewLan.Click();

            //Add Text to NewLanguage
            TextLanguage.SendKeys(Language);
            WaitHelpers.WaitToBeClickable(driver, 5, "Name", "level");

            //Select LanguageLevel
            LanguageLevel.SelectByValue(Level);

            //Click Add Language Button
            AddLanguage.Click();

        }
        
        public string createlanguages()
        {
            //Thread.Sleep(3000);
            WaitHelpers.WaitToBeVisible(driver, 20, "CssSelector", "div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper > table.ui.fixed.table");
            IWebElement newlanguage = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]"));
            return newlanguage.GetAttribute("outerText").ToString();

            
        }

        public void EditLanguage(string Language, string Level)
        {
            //IWebElement LanguageTab = driver.FindElement(By.LinkText("Languages"));
            LanguageTab.Click();

            //Click Edit language button
            //Thread.Sleep(3000);
            Languageedit.Click();

            //Edit Language textbox
            TextLanguage.Clear();
            TextLanguage.SendKeys(Language);
            //Langugetextbox.Clear();
            //Langugetextbox.SendKeys(Language);

            //Edit Language Level
            LanguageLevel.SelectByValue(Level);
            //Languageleveledit.SelectByValue(Level);

            //Click Update button
            //Thread.Sleep(3000);
            updatebutton.Click();

        }
        public string GetLanguage()
        {
            //Thread.Sleep(3000);
            WaitHelpers.WaitToBeVisible(driver, 10, "CssSelector", "div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper > table.ui.fixed.table");
            driver.Navigate().Refresh();
            IWebElement firstlanguage = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]"));
            return firstlanguage.GetAttribute("outerText").ToString();
        }

        public void DeleteLanguage()
        {
            //IWebElement LanguageTab = driver.FindElement(By.LinkText("Languages"));
            LanguageTab.Click();
            //Delete last row
            deletelastrow.Click();
            //Delete third row
            deletethirdrow.Click();
            //driver.Navigate().Refresh();
            WaitHelpers.WaitToBeClickable(driver, 15, "XPath", "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[3]/span[2]/i[1]");
            //Delete second row
            deletesecondrow.Click();
            //Delete first row
            deletefirstrow.Click();

        }

        public string deletelanguages()
        {
            //Thread.Sleep(3000);
            WaitHelpers.WaitToBeVisible(driver, 10, "CssSelector", "div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper > table.ui.fixed.table");
            IWebElement lastlanguage = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]"));
            return lastlanguage.GetAttribute("outerText").ToString();

        }


    }
}























































































































































































































































































































































































































































































































































































































































































































































































































































































































