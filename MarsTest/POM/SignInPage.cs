using SeleniumExtras.PageObjects;

namespace MarsTest.POM
{
    public class SignInPage
    {
        IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.LinkText, Using = "Sign In")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement UserText { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement PasswordText { get; set; }

        [FindsBy(How = How.XPath, Using = "//body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[4]/button[1]")]
        public IWebElement LoginButton { get; set; }

        public void NavigateToShareSkillHomePage()
        {
            SignInButton.Click();
            UserText.SendKeys("anjalibs@gmail.com");
            PasswordText.SendKeys("Intern2022");
            LoginButton.Click();

        }
    }
}
