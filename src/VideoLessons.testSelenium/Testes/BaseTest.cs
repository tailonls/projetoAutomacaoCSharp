using System.IO;
using Microsoft.Extensions.Configuration;

namespace VideoLessons.testSelenium.Testes
{
    public class BaseTest {
        private IConfiguration _configuration;
        public BaseTest(){
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            _configuration = builder.Build();
        }
    }
}