using Applitools.Selenium;
using BBCTestProject.PageObject;
using FluentAssertions;
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

        [Given( @"I see the text '(.*)'" )]
        public void GivenISeeTheText( string expectedHeaderText )
        {
            var runner = new ClassicRunner();
            var eyes = new Eyes(runner);
            var configuration = new Configuration();
            var driver = Browser.Get();
            var navigationList = new HomePage().NavigationLinksList;
            var navigationEnglishList = new HomePage().NavigationEnglishLists;
            eyes.ApiKey = "e1a30daWtG7TGDntETpQvN8WhA29muccCaXA6aFQMn8110";
            eyes.Open(driver, "Demo App", "Smoke Test");

            eyes.Check(" BBC Page", Target.Window().Ignore(navigationList).Ignore(navigationEnglishList));

            eyes.CloseAsync();

            //var currentText = new HomePage().Header.Text;
            //currentText.Should().NotBeEmpty( expectedHeaderText, "because the header text shoud be must be the same as expected" );
        }
    }
}
