using System;
using Microsoft.Extensions.Configuration;
using VideoLessons.testSelenium.Utils;

namespace VideoLessons.testSelenium.Screen {
    public class HomeScreen : BaseScreen{

        public HomeScreen (IConfiguration configuration, Browser browser) : base(configuration, browser){}

    }
}