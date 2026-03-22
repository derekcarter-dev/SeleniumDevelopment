using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestDevelopment.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using TestDevelopment.Pages.TheInternetHerokuApp;

namespace TestDevelopment.Tests;

public class LoginTests(WebDriverFixture fixture) : IClassFixture<WebDriverFixture>
{
    private readonly WebDriverFixture _fixture = fixture;

    [Fact]
    public void ShouldLoginWithValidCredentials()
    {
        IWebDriver driver = _fixture.Driver;
        var loginPage = new LoginPage(driver);
        loginPage.NavigateTo("/login");

        loginPage.Login("tomsmith", "SuperSecretPassword!");
        var successMessage = loginPage.GetSuccessMessage();

        Assert.Contains("You logged into a secure area!", successMessage);
    }
}
