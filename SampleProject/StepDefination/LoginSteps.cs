using OpenQA.Selenium;
using SampleProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SampleProject.StepDefination
{
    [Binding]
    public  class LoginSteps
    {

        private readonly IWebDriver _driver;

        [Obsolete]
        public LoginSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
        }

        [Given(@": User Should Launch Valid URL")]
        public void GivenUserShouldLaunchValidURL()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@": User Should Enter Valid Login Details")]
        public void WhenUserShouldEnterValidLoginDetails(Table table)
        {
            LoginPage page1 = new LoginPage(_driver);
            foreach (var row in table.Rows)
            {
                page1.MainPage(row[0], row[1]);
            }

        }

        [When(@": User Click on Login Button")]
        public void WhenUserClickOnLoginButton()
        {
            LoginPage page1 = new LoginPage(_driver);
            page1.ClickLogin();
        }

        [Then(@": User Able to See HomePage")]
        public void ThenUserAbleToSeeHomePage()
        {
            Console.WriteLine("HomePage Is Displayed");

        }

        [When(@": User able to see Homepage and Clicks on Add to cart button")]
        public void WhenUserAbleToSeeHomepageAndClicksOnAddToCartButton()
        {
            Console.WriteLine("HomePage Is Displayed");
            HomePage page2 = new HomePage(_driver);
            page2.Homepage();
        }

        [When(@": User Clicks on Cart Icon and User able to see Cart Page")]
        public void WhenUserClicksOnCartIconAndUserAbleToSeeCartPage()
        {
            HomePage page2 = new HomePage(_driver);
            page2.CartPage();
        }

        [When(@": User Clicks on Checkout button and User able to see Checkout Page")]
        public void WhenUserClicksOnCheckoutButtonAndUserAbleToSeeCheckoutPage()
        {
            HomePage page3 = new HomePage(_driver);
            page3.checkout();
            Console.WriteLine("User Able To See CheckOutPage");
        }

        [When(@": User enter the vaild information in the page")]
        public void WhenUserEnterTheVaildInformationInThePage(Table table)
        {
            HomePage page4 = new HomePage(_driver);
            foreach (var row in table.Rows)
            {
                page4.CheckoutPage(row[0], row[1], row[2]);
            }
        }

        [Then(@": User Click on Finish button and Places an order")]
        public void ThenUserClickOnFinishButtonAndPlacesAnOrder()
        {
            HomePage page4 = new HomePage(_driver);
            page4.Overview();
        }

        [When(@": User should be able to see HomePage and Click on Filter Icon")]
        public void WhenUserShouldBeAbleToSeeHomePageAndClickOnFilterIcon()
        {
            Console.WriteLine("HomePage Is Displayed");
            HomePage page4 = new HomePage(_driver);
            page4.filter();
        }

        [When(@": User click on Price\(Low To High\) One")]
        public void WhenUserClickOnPriceLowToHighOne()
        {
            HomePage page4 = new HomePage(_driver);
            page4.filterPrice();
        }

        [When(@": User Select the Particular Iteam or Iteams they need by clicking on Add to cart button")]
        public void WhenUserSelectTheParticularIteamOrIteamsTheyNeedByClickingOnAddToCartButton()
        {
            HomePage page2 = new HomePage(_driver);
            page2.Homepage();
        }

        [When(@": User click on CartIcon")]
        public void WhenUserClickOnCartIcon()
        {
            HomePage page2 = new HomePage(_driver);
            page2.CartPage();
        }

        [When(@": User Clicks on Checkout button")]
        public void WhenUserClicksOnCheckoutButton()
        {
            HomePage page3 = new HomePage(_driver);
            page3.checkout();
            Console.WriteLine("User Able To See CheckOutPage");
        }

        [Then(@": User click on Finish button and Order is Placed\.")]
        public void ThenUserClickOnFinishButtonAndOrderIsPlaced_()
        {
            HomePage page4 = new HomePage(_driver);
            page4.Overview();
        }

        [When(@": User Removes an Iteam from the list")]
        public void WhenUserRemovesAnIteamFromTheList()
        {
            HomePage page5 = new HomePage(_driver);
            page5.RemoveIteam();
        }
        [When(@": Customer able to see homepage and clicks on Add to Cart Button")]
        public void WhenCustomerAbleToSeeHomepageAndClicksOnAddToCartButton()
        {
            Console.WriteLine("HomePage Is Displayed");
            HomePage home = new HomePage(_driver);
            home.Homepage();
        }

        [When(@":  Customer Clicks On Cart Icon and They able to see Cart page")]
        public void WhenCustomerClicksOnCartIconAndTheyAbleToSeeCartPage()
        {
            HomePage cart = new HomePage(_driver);
            cart.CartPage();
        }

        [When(@":  Customer Clicks on Checkout Button and able to see Checkout Page")]
        public void WhenCustomerClicksOnCheckoutButtonAndAbleToSeeCheckoutPage()
        {
            HomePage check = new HomePage(_driver);
            check.checkout();
            Console.WriteLine("User Able To See CheckOutPage");
        }

        [When(@": User enter the information in the page")]
        public void WhenUserEnterTheInformationInThePage(Table table)
        {
            HomePage page8 = new HomePage(_driver);
            foreach (var row in table.Rows)
            {
                page8.CheckoutPage(row[0], row[1], row[2]);
            }
        }

        [Then(@": User Clicks On Cancel Button")]
        public void ThenUserClicksOnCancelButton()
        {
            HomePage page9 = new HomePage(_driver);
            page9.Cancellation();
        }

        [When(@": User Click on Finish button and Places an order")]
        public void WhenUserClickOnFinishButtonAndPlacesAnOrder()
        {
            HomePage page4 = new HomePage(_driver);
            page4.Overview();
        }

        [When(@": User Clicks on Back-to-Home button")]
        public void WhenUserClicksOnBack_To_HomeButton()
        {
            HomePage page10 = new HomePage(_driver);
            page10.back();
        }

        [When(@": User able to see Homepage and Clicks on Menu button")]
        public void WhenUserAbleToSeeHomepageAndClicksOnMenuButton()
        {
            HomePage page11 = new HomePage(_driver);
            page11.menu();

        }

        [Then(@": User Clicks on Logout button and able to see Loginpage\.")]
        public void ThenUserClicksOnLogoutButtonAndAbleToSeeLoginpage_()
        {
            HomePage page12 = new HomePage(_driver);
            page12.logout();
        }










    }
}
