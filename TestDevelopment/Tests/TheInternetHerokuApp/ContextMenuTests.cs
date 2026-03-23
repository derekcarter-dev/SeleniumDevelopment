using Xunit;
using OpenQA.Selenium;
using TestDevelopment.Framework;
using TestDevelopment.Pages.TheInternetHerokuApp;

namespace TestDevelopment.Tests;

public class ContextMenuTests(WebDriverFixture fixture) : IClassFixture<WebDriverFixture>
{
    private readonly WebDriverFixture _fixture = fixture;

    [Fact]
    public void ShouldDisplayContextMenuOnRightClick()
    {
        IWebDriver driver = _fixture.Driver;
        var contextMenuPage = new ContextMenuPage(driver);
        contextMenuPage.NavigateTo("/context_menu");

        contextMenuPage.RightClickOnContextMenuArea();
        var alertText = contextMenuPage.GetAlertText();

        Assert.Contains("You selected a context menu", alertText);
        contextMenuPage.AcceptAlert();
    }
}
