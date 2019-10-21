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

        [FindsBy(How = How.XPath, Using = "//*[@id='SHORTCUT_FOCUSABLE_DIV']/div[1]/header/div/div[2]/div[2]/div[1]/a[1]")]
        private IWebElement loginBtn;

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/div/form/fieldset[5]/button")]
        private IWebElement signInBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='SHORTCUT_FOCUSABLE_DIV']/div[2]/div/div/div/div[2]/div[5]/div[1]/div/div[2]")]
        private IWebElement profileMessage;

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/div/form/fieldset[2]/div")]
        private IWebElement invalidPMessage;


        


        [FindsBy(How = How.Id, Using = "loginUsername")]
        private IWebElement loginUsername;

        [FindsBy(How = How.Id, Using = "loginPassword")]
        private IWebElement loginPassword;


        


        public RedditHome(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://www.reddit.com/");
        }

        public void LoginBtn()
        {
            loginBtn.Click();
        }

        public void UsernameInput()
        {
            loginUsername.SendKeys("epSparta");
        }

        public void ValidPasswordInput()
        {
            loginPassword.SendKeys("Sparta2019!");
        }

        public void InvalidPasswordInput()
        {
            loginPassword.SendKeys("Sparta201");
        }

        public void SignIn()
        {
            signInBtn.Click();
        }


            public void ClickDropDownProfile()
            {
                IWebElement dropDown = driver.FindElement(By.XPath("/html/body/div[6]/div"));
                IList<IWebElement> dropDownList = dropDown.FindElements(By.ClassName("_1YWXCINvcuU7nk0ED-bta8"));
                dropDownList[0].Click();
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
