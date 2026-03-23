using TestDevelopment.Framework;
using TestDevelopment.Pages.TheInternetHerokuApp;
using Xunit;

namespace TestDevelopment.Tests;

public class DropdownTests(WebDriverFixture fixture) : IClassFixture<WebDriverFixture>
{
    private readonly WebDriverFixture _fixture = fixture;

    [Fact]
    public void ShouldSelectOptionFromDropdown()
    {
        var driver = _fixture.Driver;
        var dropdownPage = new DropdownPage(driver);
        dropdownPage.NavigateTo("/dropdown");

        dropdownPage.SelectOptionByValue("2");
        var selectedOptionText = dropdownPage.GetSelectedOptionText();

        Assert.Equal("Option 2", selectedOptionText);
    }
}