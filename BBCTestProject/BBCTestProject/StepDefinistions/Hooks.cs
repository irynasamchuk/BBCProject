using BBCTestProject.PageObject;
using TechTalk.SpecFlow;

namespace BBCTestProject.StepDefinistions
{
    [Binding]
    public class Hooks
    {
        [AfterScenario]
        public void CloseBrowser()
        {
            Browser.Close();
        }
    }
}
