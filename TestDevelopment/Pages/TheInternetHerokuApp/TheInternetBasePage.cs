using OpenQA.Selenium;
using TestDevelopment.Framework;

namespace TestDevelopment.Pages.TheInternetHerokuApp
{
    public class TheInternetBasePage : BasePage
    {
        private const string BaseUrl = "https://the-internet.herokuapp.com";

        protected TheInternetBasePage(IWebDriver driver) : base(driver)
        {
        }
        
        public void NavigateTo(string relativeUrl)
        {
            Driver.Navigate().GoToUrl($"{BaseUrl}{relativeUrl}");
        }
    }
}