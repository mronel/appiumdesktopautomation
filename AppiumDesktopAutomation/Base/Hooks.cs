using TechTalk.SpecFlow;

namespace AppiumDesktopAutomation.Base
{
    [Binding]
    public sealed class Hooks
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            Configuration.SetCapabilities();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Configuration.GetDriver().CloseApp();
        }
    }
}
