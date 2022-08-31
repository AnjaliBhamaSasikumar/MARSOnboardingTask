
using MarsTest.POM;
using MarsTest.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsTest.Test
{
    [TestFixture]
    public class ShareSkill : CommonDriver
    {
        [Test]
        public void TestShareSkill()
        {
            var SignInPage = new SignInPage(driver);
            SignInPage.NavigateToShareSkillHomePage();
        }
    }
}
