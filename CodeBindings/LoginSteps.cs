using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace specflow_csharp.CodeBindings
{
    [Binding]
    public class LoginSteps
    {
        private const string base_url = "https://preview.netdimensions.com/preview/servlet/ekp/login?target=%2Fpreview%2Fservlet%2Fekp%2FpageLayout";
        private IWebDriver driver;

        [Given(@"the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            driver = new ChromeDriver
            {
                Url = base_url
            };
        }
        
        [When(@"they enter valid admin credentials add")]
        public void WhenTheyEnterValidAdminCredentialsAdd()
        {
            driver.FindElement(By.Id("UID")).SendKeys("netd_lee");
            driver.FindElement(By.Id("PWD")).SendKeys("12345678");
            driver.FindElement(By.Name("login")).Click();
        }
        
        [Then(@"they should be taken to the home page")]
        public void ThenTheyShouldBeTakenToTheHomePage()
        {
            Assert.That(driver.FindElement(By.CssSelector("#column_0 > div > div.widget-header.row_0 > span")).Text.Equals("RECENT ACTIVITY"));
        }
    }
}
