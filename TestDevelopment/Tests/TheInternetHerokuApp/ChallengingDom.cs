using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestDevelopment.Framework;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestDevelopment.Tests;

public class ChallengingDom(WebDriverFixture fixture) : IClassFixture<WebDriverFixture>
{
    private readonly WebDriverFixture _fixture = fixture;
}
