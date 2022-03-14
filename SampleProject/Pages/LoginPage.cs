using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SampleProject.Pages
{
    class LoginPage
    {
        IWebDriver _driver;

        public  LoginPage(IWebDriver driver) 
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }
        [FindsBy(How = How.Id, Using = "user-name")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login-button")]
        public IWebElement Login { get; set; }


        public void MainPage(string un, string pw)
        {
            Username.SendKeys(un);
            Thread.Sleep(1000);
            Password.SendKeys(pw);
            Thread.Sleep(1000);
        }
        public void ClickLogin()
        {
            Login.Click();
            Thread.Sleep(1000);
        }

        

    }
}
