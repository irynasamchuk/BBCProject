﻿using OpenQA.Selenium;
using System.Collections.Generic;

namespace BBCTestProject.PageObject
{
    public class HomePage
    {
        public IList<IWebElement> NavigationLinksList => 
            Browser.Get().FindElements( By.XPath( "//div[contains(@class, 'orb-nav-section') and contains(@class, 'orb-nav-links')]//li" ) );

        public IWebElement NavigationEnglishLists =>
            Browser.Get().FindElement(By.XPath("//div[@id='bbcle-header-nav']/div[contains(@class, 'content-no-sidebar b-g-p')]"));

        public IWebElement Header => Browser.Get().FindElement( By.XPath( "//div[@id = 'bbcle-header-masthead']/h1" ) );
    }
}
