using System;
using OpenQA.Selenium;

namespace VideoLessons.testSelenium.Utils {
    public static class driverExtensions {
        public static void LoadPage (this IWebDriver webDriver, TimeSpan timeToWait, string url) {
            webDriver.Manage().Timeouts().PageLoad = timeToWait;
            webDriver.Navigate().GoToUrl(url);
        }
    }
}