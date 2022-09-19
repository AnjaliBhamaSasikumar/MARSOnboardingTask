//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.PageObjects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MarsTest.POM
//{
//    public class ShareSkillPage
//    {
//        IWebDriver driver;
//        public ShareSkillPage(IWebDriver driver)
//        {
//            this.driver = driver;
//            PageFactory.InitElements(driver, this);
//        }  
//        [FindsBy(How = How.LinkText, Using = "Share Skill")]
//        public IWebElement ShareSkillButton { get; set; }

//        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/div[1]/input[1]")]
//        public IWebElement TitleText { get; set; }

//        [FindsBy(How = How.TagName, Using = "textarea")]
//        public IWebElement DescriptionText { get; set; }

//        [FindsBy(How = How.TagName, Using = "select")]
//        public SelectElement Category { get; set; }

//        [FindsBy(How = How.Name, Using = "subcategoryId")]
//        public SelectElement SubCategory { get; set; }

//        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]")]
//        public IWebElement TagsText { get; set; }

//        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[5]/div[2]/div[1]/div[1]/div[1]")]
//        public IWebElement ServiceType { get; set; }

//        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[6]/div[2]/div[1]/div[1]/div[1]/input[1]")]
//        public IWebElement LocationType { get; set; }

//        public void NavigateToShareSkillPage()
//        {
//            ShareSkillButton.Click();
//            TitleText.SendKeys("I provide Test Analyst Service");
//            DescriptionText.SendKeys("Ensures the functional readiness of computer software and hardware products before they go to market");
//            Category.SelectByValue("Programming & Tech");
//            SubCategory.SelectByValue("QA");
//            TagsText.Click();
//            TagsText.SendKeys("#TestAnalyst");
//            TagsText.SendKeys(Keys.Enter);
//            TagsText.SendKeys("#Automation");
//            ServiceType.Click();
//            LocationType.Click();


        
        
//        }
//    }
//}
