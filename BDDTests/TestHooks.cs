using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDDTests
{
    [Binding]
    public class TestHooks
    {
        [BeforeScenario]
        public void CreateWebDriver(ScenarioContext context)
        {
            // We are using Chrome, but you can use any driver
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-notifications");

            IWebDriver webDriver = new ChromeDriver(options);
            context["WEB_DRIVER"] = webDriver;
        }

        [AfterScenario]
        public void CloseWebDriver(ScenarioContext context)
        {
            var driver = context["WEB_DRIVER"] as IWebDriver;
            driver.Quit();
        }
    }
}
