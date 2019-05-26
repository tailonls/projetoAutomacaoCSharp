using VideoLessons.testSelenium.Screen;
using VideoLessons.testSelenium.Utils;
using Xunit;

namespace VideoLessons.testSelenium.Testes {
    public class HomeTest : BaseTest {

        [Theory]
        [InlineData (Browser.Chrome)]
        public void DeveCarregaTelaComSucesso (Browser browser) {
            HomeScreen homeScreen = new HomeScreen (_configuration, browser);
            homeScreen.LoadScreen (_configuration.GetSection ("Selenium:Urls:Home").Value);
            homeScreen.closeScreen();
        }
    }
}