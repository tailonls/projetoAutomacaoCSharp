using System;
using Microsoft.Extensions.Configuration;
    using OpenQA.Selenium;
using VideoLessons.testSelenium.Utils;

namespace VideoLessons.testSelenium.Screen {
    public class BaseScreen {
        protected readonly IConfiguration _configuration;
        protected readonly Browser _browser;
        protected IWebDriver _driver;

        public BaseScreen (IConfiguration configuration, Browser browser) {
            _configuration = configuration;
            _browser = browser;
            _driver = DriverFactory.CreateWebDriver (browser, configuration.GetSection ("Selenium:Drivers:Path").Value, false);
        }

        public void LoadScreen(string url){
            _driver.LoadPage(TimeSpan.FromSeconds(15), url);
            _driver.Manage().Window.Maximize();
        }

        public void closeScreen () {
            _driver.Quit ();
            _driver = null;
        }
    }
}