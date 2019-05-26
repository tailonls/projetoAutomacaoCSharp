using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace VideoLessons.testSelenium.Utils {
    public static class DriverFactory {
        public static IWebDriver CreateWebDriver (Browser browser, string pathDriver, bool headless) {
            IWebDriver webDriver = null;

            switch (browser) {
                case Browser.Chrome:
                    ChromeOptions chromeOptions = new ChromeOptions ();
                    if (headless) {
                        chromeOptions.AddArgument ("--headless");
                    }
                    webDriver = new ChromeDriver (pathDriver, chromeOptions);
                    break;

                case Browser.Firefox:
                    FirefoxOptions fireFoxOptions = new FirefoxOptions ();
                    if (headless) {
                        fireFoxOptions.AddArgument("--headless");
                    }
                    webDriver = new FirefoxDriver (pathDriver, fireFoxOptions);
                    break;
            }
            return webDriver;
        }
    }
}