using OpenQA.Selenium;

namespace TestDevelopment.Pages.TheInternetHerokuApp
{
    public class ContextMenuPage(IWebDriver driver) : TheInternetBasePage(driver)
    {
        // Locators
        private IWebElement ContextMenuArea => driver.FindElement(By.Id("hot-spot"));
        private IAlert Alert => driver.SwitchTo().Alert();

        public void RightClickOnContextMenuArea()
        {
            var actions = new OpenQA.Selenium.Interactions.Actions(driver);
            actions.ContextClick(ContextMenuArea).Perform();
        }
        
        public string GetAlertText()
        {
            return Alert.Text;
        }
        
        public void AcceptAlert()
        {
            Alert.Accept();
        }
    }
}