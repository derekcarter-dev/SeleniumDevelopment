using OpenQA.Selenium;

namespace TestDevelopment.Pages.TheInternetHerokuApp
{
    public class DropdownPage(IWebDriver driver) : TheInternetBasePage(driver)
    {
        // Locators
        private IWebElement Dropdown => driver.FindElement(By.Id("dropdown"));
        
        public void SelectOptionByValue(string value)
        {
            var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(Dropdown);
            selectElement.SelectByValue(value);
        }
        
        public string GetSelectedOptionText()
        {
            var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(Dropdown);
            return selectElement.SelectedOption.Text;
        }
    }
}