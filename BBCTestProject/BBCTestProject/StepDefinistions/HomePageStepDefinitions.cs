using BBCTestProject.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BBCTestProject.StepDefinistions
{
    [Binding]
   public class HomePageStepDefinitions
    {
        [Given( @"I am on the Home Page main page" )]
        public void GivenIAmOnTheHomePageMainPage()
        {
            Browser.Get().Navigate().GoToUrl( "http://www.bbc.co.uk/learningenglish/" );
         
        }

        [Given( @"I see the text" )]
        public void GivenISeeTheText()
        {
            
        }

    }
}
