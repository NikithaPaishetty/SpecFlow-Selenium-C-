using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SampleProject.Pages
{
    class HomePage
    {

        IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }
        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-backpack")]
        public IWebElement AddToCart2 { get; set; }

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-onesie")]
        public IWebElement AddToCart1 { get; set; }

        [FindsBy(How = How.Id, Using = "add-to-cart-test.allthethings()-t-shirt-(red)")]
        public IWebElement AddToCart3 { get; set; }

        [FindsBy(How = How.ClassName,Using = "shopping_cart_link")]
        public IWebElement CartIcon { get; set; }

        [FindsBy(How = How.Id, Using = "checkout")]
        public IWebElement Checkout { get; set; }

        [FindsBy(How = How.Id, Using = "first-name")]
        public IWebElement Firstname { get; set; }

        [FindsBy(How = How.Id, Using = "last-name")]
        public IWebElement Lastname { get; set; }

        [FindsBy(How = How.Id, Using = "postal-code")]
        public IWebElement Postalcode { get; set; }

        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement Continue { get; set; }

        [FindsBy(How = How.Id, Using = "finish")]
        public IWebElement Finish { get; set; }

        [FindsBy(How = How.ClassName, Using = "product_sort_container")]
        public IWebElement Filter { get; set; }

        [FindsBy(How = How.Id, Using = "remove-test.allthethings()-t-shirt-(red)")]
        public IWebElement Remove { get; set; }

        [FindsBy(How = How.Id, Using = "continue-shopping")]
        public IWebElement ContinueShopping { get; set; }

        [FindsBy(How = How.Id, Using = "cancel")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.Id, Using = "back-to-products")]
        public IWebElement Back { get; set; }

        [FindsBy(How = How.Id, Using = "react-burger-menu-btn")]
        public IWebElement Menubutton { get; set; }

        [FindsBy(How = How.Id, Using = "logout_sidebar_link")]
        public IWebElement Logout { get; set; }





        public void Homepage()
        {
            AddToCart1.Click();
            Thread.Sleep(2000);
            AddToCart2.Click();
            Thread.Sleep(2000);
            AddToCart3.Click();
            Thread.Sleep(2000);

        }

        public void CartPage()
        {
            CartIcon.Click();
            Thread.Sleep(2000);
        }

        public void RemoveIteam()
        {
            Remove.Click();
            Thread.Sleep(5000);
            ContinueShopping.Click();
            Thread.Sleep(20000);
            CartIcon.Click();
            Thread.Sleep(20000);
        }
        public void checkout()
        {
            Checkout.Click();
            Thread.Sleep(2000);
        }

        public void CheckoutPage(string Fn, string Ln, string Pc)
        {
            Firstname.SendKeys(Fn);
            Thread.Sleep(2000);
            Lastname.SendKeys(Ln);
            Thread.Sleep(2000);
            Postalcode.SendKeys(Pc);
            Thread.Sleep(2000);
            Continue.Click();
            Thread.Sleep(2000);
        }
         public void Overview()
         {
            Finish.Click();
            Thread.Sleep(2000);
         }
        public void filter()
        {
            Filter.Click();
            Thread.Sleep(1000);
        }
        public void filterPrice()
        {
            SelectElement st = new SelectElement(Filter);
            st.SelectByValue("lohi");
            Thread.Sleep(1000);
        }

        public void Cancellation()
        {
            Cancel.Click();
            Thread.Sleep(2000);
        }

        public void back()
        {
            Back.Click();
            Thread.Sleep(2000);
        }

        public void menu()
        {
            Menubutton.Click();
            Thread.Sleep(2000);
        }

        public void logout()
        {
            Logout.Click();
            Thread.Sleep(2000);
        }









    }
}
