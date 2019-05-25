using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using VideoLessons.testSelenium.Utils;

namespace VideoLessons.testSelenium.Screen {
    public class BaseScreen {
        protected readonly IConfiguration _configuration;
        protected readonly Browsers _browser;
        protected IWebDriver _driver;
    }
}