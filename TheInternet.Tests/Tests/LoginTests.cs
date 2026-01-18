using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TheInternet.Tests.Framework;

namespace TheInternet.Tests;

public class LoginTests : IClassFixture<WebDriverFixture>
{
    private readonly WebDriverFixture _fixture;

    public LoginTests(WebDriverFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void ShouldLoginWithValidCredentials()
    {
        IWebDriver driver = _fixture.Driver;
        try
        {
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");

            IWebElement usernameInput = driver.FindElement(By.Id("username"));
           usernameInput.SendKeys("tomsmith");

            IWebElement passwordInput = driver.FindElement(By.Id("password"));
            passwordInput.SendKeys("SuperSecretPassword!");

            IWebElement loginButton = driver.FindElement(By.CssSelector("button[type='submit']"));
            loginButton.Click();

            IWebElement successMessage = driver.FindElement(By.Id("flash"));
            Assert.Contains("You logged into a secure area!", successMessage.Text);
        }
        finally
        {
            driver.Quit();
        }
    }
}
