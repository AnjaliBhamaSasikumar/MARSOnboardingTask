using MarsTest.Hook;
using MarsTest.Pages;
using MarsTest.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsTest.StepDefinition
{
    [Binding]
    public class ProjectStepDefinitions : CommonDriver
    {
        SignIn SignInObj;
        HomePage HomePageObj;
        DescriptionPage DescriptionPageObj;
        LanguagePage LanguagePageObj;
        SkillPage SkillPageObj;
        private readonly Hooks _Hooks;

        public ProjectStepDefinitions(Hooks Hooks)
        {
            this._Hooks = Hooks;
            SignInObj = new SignIn();
            HomePageObj = new HomePage();
            DescriptionPageObj = new DescriptionPage();
            LanguagePageObj = new LanguagePage();
            SkillPageObj = new SkillPage();
            //driver = new ChromeDriver();
        }

        [Given(@"I successfully SignIn to the Website")]
        public void GivenISuccessfullySignInToTheWebsite()
        {
            
            SignInObj.SignInActions();
        }
        
        [Given(@"I navigate to Profile page")]
        public void GivenINavigateToProfilePage()
        {
            HomePageObj.GoToProfilePage();
        }

        [When(@"I create description details to the profile")]
        public void WhenICreateDescriptionDetailsToTheProfile()
        {
            DescriptionPageObj.AddDescription();
        }

        [Then(@"I am able to see my Description details in the profile page")]
        public void ThenIAmAbleToSeeMyDescriptionDetailsInTheProfilePage()
        {
            string newDescription = DescriptionPageObj.GetDescription();
            Assert.That(newDescription == "I am a Test Analyst", "Actual description and expected decription do not match");
        }

        [When(@"I add Language including '([^']*)' and '([^']*)'")]
        public void WhenIAddLanguageIncludingAnd(string p0, string p1)
        {
            LanguagePageObj.CreateLanguage(p0, p1);
        }

        [Then(@"I am able to see Language details including '([^']*)' and '([^']*)'")]
        public void ThenIAmAbleToSeeLanguageDetailsIncludingAnd(string p0, string p1)
        {
            string newlanguage = LanguagePageObj.createlanguages();
            string newlanguagelevel = LanguagePageObj.createlanguages();

            Assert.That(newlanguage.Contains(p0), "Actual language and expected language do not match");
            Assert.That(newlanguagelevel.Contains(p1), "Actual languagelevel and expected language level do not match");
            
        }

        [When(@"I edit language including'([^']*)' and '([^']*)'")]
        public void WhenIEditLanguageIncludingAnd(string p0, string p1)
        {
            LanguagePageObj.EditLanguage(p0, p1);
        }

        [Then(@"I am able to see edited language details including '([^']*)' and '([^']*)'")]
        public void ThenIAmAbleToSeeEditedLanguageDetailsIncludingAnd(string p0, string p1)
        {
            string firstlanguage = LanguagePageObj.GetLanguage();
            string firstlanguagelevel = LanguagePageObj.GetLanguage();

            Assert.That(firstlanguage.Contains(p0), "Actual language and expected language do not match");
            Assert.That(firstlanguagelevel.Contains(p1), "Actual languagelevel and expected language level do not match");
            
        }

        [When(@"I navigate to Language tab and delete language")]
        public void WhenINavigateToLanguageTabAndDeleteLanguage()
        {
            LanguagePageObj.DeleteLanguage();
        }

        [Then(@"I am able to delete languages details from the profile page")]
        public void ThenIAmAbleToDeleteLanguagesDetailsFromTheProfilePage()
        {
           string lastlanguage = LanguagePageObj.deletelanguages();
           string lastlanguagelevel = LanguagePageObj.deletelanguages();
           Assert.That(lastlanguage != "p0", "Language do not deleted successfully");
           Assert.That(lastlanguagelevel != "p1", "Language do not deleted successfully");
           
        }

        [When(@"I add skill details including '([^']*)' and '([^']*)' to the profile")]
        public void WhenIAddSkillDetailsIncludingAndToTheProfile(string p0, string p1)
        {
            SkillPageObj.CreateSkills(p0, p1);
        }

        [Then(@"I am able to see skill details including '([^']*)' and '([^']*)'")]
        public void ThenIAmAbleToSeeSkillDetailsIncludingAnd(string p0, string p1)
        {
            string newskill = SkillPageObj.createskills();
            string newskilllevel = SkillPageObj.createskills();

            Assert.That(newskill.Contains(p0), "Actual skills and expected skills do not match");
            Assert.That(newskilllevel.Contains(p1), "Actual skilllevel and expected skill level do not match");

            driver.Close();
        }

        [When(@"I edit skill details including '([^']*)' and '([^']*)' to the profile")]
        public void WhenIEditSkillDetailsIncludingAndToTheProfile(string p0, string p1)
        {
            SkillPageObj.Editskill(p0, p1);
        }

        [Then(@"I am ble to see edited skill details including '([^']*)' and '([^']*)'")]
        public void ThenIAmBleToSeeEditedSkillDetailsIncludingAnd(string p0, string p1)
        {
            string firstskill = SkillPageObj.Getskill();
            string firstskilllevel = SkillPageObj.Getskill();

            Assert.That(firstskill.Contains(p0), "Actaul skills and expected skills do not match");
            Assert.That(firstskilllevel.Contains(p1), "Actual skilllevel and expected skill level do not match");

            driver.Close();
        }

        [When(@"I navigate to skill tab and delete skill details")]
        public void WhenINavigateToSkillTabAndDeleteSkillDetails()
        {
            SkillPageObj.DeleteSkill();
        }

        [Then(@"I am able to delete skill details from the profile page")]
        public void ThenIAmAbleToDeleteSkillDetailsFromTheProfilePage()
        {
            string lastskill = SkillPageObj.deleteskills();
            string lastskilllevel = SkillPageObj.deleteskills();
            Assert.That(lastskill != "p0", "Skills do not deleted successfully");
            Assert.That(lastskilllevel != "p1", "Skills do not deleted successfully");
            driver.Quit();
        }


    }
}
