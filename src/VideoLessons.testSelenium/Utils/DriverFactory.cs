 namespace VideoLessons.testSelenium.Utils {
     public static class DriverFactory {
         public static IWebDriver CreateWebDriver (Browser browser, string pathDriver, bool headless) {
             IWebDriver webDriver = null;

             switch (browser) {
                 case Browsers.Chrome:
                     ChromeOptions chromeOptions = new ChromeOptions ();
                     if (headless) {
                         chromeOptions.addArgument ("--headless");
                     }
                     webDriver = new ChromeDriver (pathDriver, chromeOptions);
                     break;

                 case Browsers.Firefox:
                     FireFoxOptions fireFoxOptions = new FireFoxOptions ();
                     if (headless) {
                         fireFoxOptions.addArgument ("--headless");
                     }
                     webDriver = new FireFoxOptionsDriver (pathDriver, fireFoxOptions);
                     break;
                 case Browsers.Edge:

                 default:
             }
             return webDriver;
         }
     }
 }