using AppiumDesktopAutomation.Base;
using TechTalk.SpecFlow;
using NUnit.Framework;


namespace AppiumDesktopAutomation.Steps_Definition
{
    [Binding]
    public class NotepadSteps
    {

        [Given(@"I have opened the notepad")]
        public void GivenIHaveOpenedTheNotepad()
        {
            
        }
        
        [Given(@"I type the text ""(.*)""")]
        public void GivenITypeTheText(string p0)
        {
            Configuration.GetDriver().FindElementByClassName("Edit").SendKeys(p0);            
        }
        
        [When(@"I press File and Save")]
        public void WhenIPressFileAndSave()
        {
            Configuration.GetDriver().FindElementByName("Arquivo").Click();
            Configuration.GetDriver().FindElementByAccessibilityId("4").Click();
        }
        
        [Then(@"should to show the Save Dialog window")]
        public void ThenShouldToShowTheSaveDialogWindow()
        {
             //Assert.IsTrue(Configuration.GetDriver().FindElementByName("Salvar como").Displayed,"[Error] Salvar Como não exibido");
             Configuration.GetDriver().FindElementByName("Documentos").Click();
             Configuration.GetDriver().FindElementByName("Nome:").SendKeys("AutomationFile");


        }
    }
}
