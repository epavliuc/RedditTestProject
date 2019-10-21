using System;
using TechTalk.SpecFlow;
using RedditTestProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace RedditTestProject.Pages
{
    [Binding]
    public class LoginSteps
    {
        IWebDriver driver;
        RedditHome page;

        [Scope(Feature = "Login")]
        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
            page = new RedditHome(driver);
        }


        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            page.GoToPage();
        }
        
        [Given(@"I click on the login button")]
        public void GivenIClickOnTheLoginButton()
        {
            page.LoginBtn();
        }
        
        [Given(@"Input valid details")]
        public void GivenInputValidDetails()
        {
            page.UsernameInput();
            page.ValidPasswordInput();
        }
        
        [Given(@"I click on the sign in button")]
        public void GivenIClickOnTheSignInButton()
        {
            page.SignIn();
        }
        
        [Given(@"Input invalid password")]
        public void GivenInputInvalidPassword()
        {
            page.InvalidPasswordInput();
        }
        
        [Then(@"I should see the username on the homepage")]
        public void ThenIShouldSeeTheUsernameOnTheHomepage()
        {
            page.ClickDropDownProfile();
            Assert.IsTrue(page.ProfileMessage().Contains("epSparta"));
           
        }
        
        [Then(@"I should see the correct error message")]
        public void ThenIShouldSeeTheCorrectErrorMessage()
        {
            Assert.AreEqual("Incorrect password", page.ProfileMessage());
        }

        [Scope(Feature = "Login")]
        [AfterScenario]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
