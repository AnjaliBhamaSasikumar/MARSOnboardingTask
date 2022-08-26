using MarsTest.Pages;
using MarsTest.Utilities;
using NUnit.Framework;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace MarsTest.StepDefinition
{
    [Binding]
    public class ProjectStepDefinitions : CommonDriver
    {
        SignIn SignInObj = new SignIn();
        HomePage HomePageObj = new HomePage();
        ProfilePage ProfilePageObj = new ProfilePage();
        LanguageTab LanguageTabObj = new LanguageTab();
        SkillPage SkillPageObj = new SkillPage();

        [Given(@"I successfully SignIn to the Website")]
        public void GivenISuccessfullySignInToTheWebsite()
        {
            driver = new ChromeDriver();
            SignInObj.SignInActions(driver);
        }

        [When(@"I navigate to Profile page")]
        public void WhenINavigateToProfilePage()
        {
            HomePageObj.GoToProfile(driver);
        }

        [When(@"I create Description details to the profile")]
        public void WhenICreateDescriptionDetailsToTheProfile()
        {
            ProfilePageObj.Description(driver);
        }

        [Then(@"The record should added Description details to the profile page")]
        public void ThenTheRecordShouldAddedDescriptionDetailsToTheProfilePage()
        {
            string newDescription = ProfilePageObj.GetDescription(driver);
            Assert.That(newDescription == "I am looking for a Test Analyst Job", "Description do not created successfully");
            driver.Quit();

        }


        [When(@"I enter '([^']*)' and '([^']*)'")]
        public void WhenIEnterAnd(string p0, string p1)
        {
            LanguageTabObj.CreateLanguage(driver, p0, p1);
        }

        [Then(@"'([^']*)' and '([^']*)' should be created")]
        public void ThenAndShouldBeCreated(string p0, string p1)
        {
            string newlanguage = LanguageTabObj.createlanguages(driver);
            string newlanguagelevel = LanguageTabObj.createlanguages(driver);

            Assert.That(newlanguage.Contains(p0), "Language not created successfully");
            Assert.That(newlanguagelevel.Contains(p1), "Languagelevel not created successfully");

            driver.Close();
        }
        [When(@"I edit '([^']*)' and '([^']*)'")]
        public void WhenIEditAnd(string p0, string p1)
        {
            LanguageTabObj.EditLanguage(driver, p0, p1);
        }


        [Then(@"The record should update '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldUpdateAnd(string p0, string p1)
        {
            string firstlanguage = LanguageTabObj.GetLanguage(driver);
            string firstlanguagelevel = LanguageTabObj.GetLanguage(driver);

            Assert.That(firstlanguage.Contains(p0), "Language not edited successfully");
            Assert.That(firstlanguagelevel.Contains(p1), "Languagelevel not edited successfully");
            driver.Quit();

        }

        [When(@"I navigate to Language tab and delete language")]
        public void WhenINavigateToLanguageTabAndDeleteLanguage()
        {
            LanguageTabObj.DeleteLanguage(driver);
        }

        [Then(@"Language details should be deleted")]
        public void ThenLanguageDetailsShouldBeDeleted()
        {

            string lastlanguage = LanguageTabObj.deletelanguages(driver);
            string lastlanguagelevel = LanguageTabObj.deletelanguages(driver);
            Assert.That(lastlanguage != "p0", "Language do not deleted successfully");
            Assert.That(lastlanguagelevel != "p1", "Languagelevel do not deleted successfully");
            driver.Quit();
        }
        [When(@"I create skill details '([^']*)' and '([^']*)' to the profile")]
        public void WhenICreateSkillDetailsAndToTheProfile(string p0, string p1)
        {
            SkillPageObj.CreateSkills(driver, p0, p1);
        }

        [Then(@"The record '([^']*)' and '([^']*)' should add to the profile page")]
        public void ThenTheRecordAndShouldAddToTheProfilePage(string p0, string p1)
        {

            string newskill = SkillPageObj.createskills(driver);
            string newskilllevel = SkillPageObj.createskills(driver);

            Assert.That(newskill.Contains(p0), "Skills not created successfully");
            Assert.That(newskilllevel.Contains(p1), "Skilllevel not created successfully");

            driver.Close();
        }
        [When(@"I edit '([^']*)' and '([^']*)' to the profile")]
        public void WhenIEditAndToTheProfile(string p0, string p1)
        {
            SkillPageObj.Editskill(driver, p0, p1);
        }

        [Then(@"'([^']*)' and '([^']*)' should be updated")]
        public void ThenAndShouldBeUpdated(string p0, string p1)
        {
            string firstskill = SkillPageObj.Getskill(driver);
            string firstskilllevel = SkillPageObj.Getskill(driver);

            Assert.That(firstskill.Contains(p0), "Skills not created successfully");
            Assert.That(firstskilllevel.Contains(p1), "Skilllevel not created successfully");

            driver.Close();
        }

        [When(@"I navigate to skill tab and delete skill")]
        public void WhenINavigateToSkillTabAndDeleteSkill()
        {
            SkillPageObj.DeleteSkill(driver);
        }

        [Then(@"skill details should be deleted")]
        public void ThenSkillDetailsShouldBeDeleted()
        {
            string lastskill = SkillPageObj.deleteskills(driver);
            string lastskilllevel = SkillPageObj.deleteskills(driver);
            Assert.That(lastskill != "p0", "Language do not deleted successfully");
            Assert.That(lastskilllevel != "p1", "Languagelevel do not deleted successfully");
            driver.Quit();
        }

    }
}


