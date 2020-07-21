using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;

namespace BDDTests.Steps
{
    [Binding]
    public class TravelProducts
    {
        public IWebDriver webDriver;
        public TravelProducts(ScenarioContext scenarioContext)
        {
            webDriver = scenarioContext["WEB_DRIVER"] as IWebDriver;
        }
      
        [Given(@"I have navigated to CommbankPage")]
        public void GivenIHaveNavigatedToCommbankPage()
        {
            webDriver.Url = "https://www.commbank.com.au";
        }

        [Given(@"I have clicked travel Products")]
        public void GivenIHaveClickedTravelProducts()
        {
            IReadOnlyList<IWebElement> travelProducts = webDriver.FindElements(By.ClassName("card-header"));

            for (int i = 0; i < travelProducts.Count; i++)
            {
                Console.WriteLine(travelProducts[i].Text.ToString());
                if (travelProducts[i].Text.ToString() == "Travel products")
                {
                    travelProducts[i].Click();
                    break;
                }
            }
        }
        [Given(@"I click Discover more")]
        public void GivenIClickDiscoverMore()
        {
            IWebElement discoverMore = webDriver.FindElement(By.LinkText("Discover more"));
            discoverMore.Click();
        }

        [Then(@"I can see ""(.*)""")]
        public void ThenICanSee(string subTopic)
        {
            IWebElement featuresAndBenifits = webDriver.FindElement(By.LinkText("Features & benefits"));
            Assert.IsTrue(featuresAndBenifits.Displayed);
        }

        [Then(@"I click Netbank Login")]
        public void ThenIClickNetbankLogin()
        {
            IWebElement netBankLogin = webDriver.FindElement(By.CssSelector("div[class='column-combo.standard-spacing.one-column' a]"));
           // IWebElement netBankLink = webDriver.FindElement(By.LinkText("NetBank"));
            netBankLogin.Click();
        }

        [Then(@"I see Usename and Password fields are present")]
        public void ThenISeeUsenameAndPasswordFieldsArePresent()
        {
            webDriver.SwitchTo().Window(webDriver.WindowHandles.Last());
            IWebElement userName = webDriver.FindElement(By.Id("txtMyClientNumber_field"));
            IWebElement password = webDriver.FindElement(By.Id("txtMyPassword_field"));

            Assert.IsTrue(userName.Displayed);
            Assert.IsTrue(password.Displayed);
        }

    }
}
