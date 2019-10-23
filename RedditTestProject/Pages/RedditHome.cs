using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditTestProject.Pages
{
    class RedditHome
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/form/div[4]/button")]
        private IWebElement loginBtn;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/span[1]/a")]
        private IWebElement profileMessage;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/form/div[2]")]
        private IWebElement invalidPMessage;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/form/input[2]")]
        private IWebElement loginUsername;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/form/input[3]")]
        private IWebElement loginPassword;


        public RedditHome(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://www.old.reddit.com/");
        }

        public void LoginBtn()
        {
            loginBtn.Click();
        }

        public void ValidUsernameInput()
        {
            loginUsername.SendKeys("epSparta");
        }

        public void InvalidUsernameInput()
        {
            loginUsername.SendKeys("epSpart");
        }

        public void ValidPasswordInput()
        {
            loginPassword.SendKeys("Sparta2019!");
        }

        public void InvalidPasswordInput()
        {
            loginPassword.SendKeys("Sparta201");
        }

        public string ProfileMessage()
        {
            return profileMessage.Text;
        }

        public string InvalidPassword()
        {
            return invalidPMessage.Text;
        }
    }
}
