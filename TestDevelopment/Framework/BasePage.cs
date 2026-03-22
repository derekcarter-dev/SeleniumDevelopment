using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestDevelopment.Framework
{
    public abstract class BasePage(IWebDriver driver)
    {
        protected IWebDriver Driver { get; } = driver;
        protected WebDriverWait Wait { get; } = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }
}