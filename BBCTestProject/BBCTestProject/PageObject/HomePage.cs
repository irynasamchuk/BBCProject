using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCTestProject.PageObject
{
    public class HomePage
    {
        public IList<IWebElement> NavigationLinksList => Browser.Get().FindElements( By.XPath( "//div[contains(@class, 'orb-nav-section') and contains(@class, 'orb-nav-links')]//li" ) );


    }
}
