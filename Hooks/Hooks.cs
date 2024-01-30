using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowCrashCourse.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        //This is the variable that catches the instance of the WebDriver and shares it between hooks;
        private readonly IObjectContainer _container;
        public Hooks(IObjectContainer container) {
            _container = container;
        }

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.demoblaze.com/";
            //Assigns instance to _container object
            _container.RegisterInstanceAs<IWebDriver>(driver);

        }

        [AfterScenario]
        public void AfterScenario()
        {
          //Resolve gets the instance from _container Assigened via RegisterInstanceAs<driverType>(driver)
          var driver = _container.Resolve<IWebDriver>();
            if(driver != null)
            {
                driver.Quit();
            }
        }
    }
}