using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace TestDevelopment.Pages.TheInternetHerokuApp
{
    public class LoginPage(IWebDriver driver) : TheInternetBasePage(driver)
    {
        // Locators
        private IWebElement UsernameInput => driver.FindElement(By.Id("username"));
        private IWebElement PasswordInput => driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => driver.FindElement(By.CssSelector("button[type='submit']"));
        private IWebElement SuccessMessage => driver.FindElement(By.Id("flash"));

        public void Login(string username, string password)
        {
            UsernameInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            LoginButton.Click();
        }
        
        public string GetSuccessMessage()
        {
            return Wait.Until(d => SuccessMessage).Text;
        }
    }
}