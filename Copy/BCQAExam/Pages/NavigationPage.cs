using BCQAExam.Core;
using OpenQA.Selenium;
using System.Configuration;
using System;

namespace BCQAExam.Pages
{
    public class NavigationPage : BasePage
    {
        private LoginPage LoginPage = new LoginPage();
        

        public void NavigateToHomePage()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
        }

        private IWebElement SignInButton => Driver.FindControl(By.XPath("//a[@class='login']"));
               
        public void NavigateToLoginPage()
        {
            SignInButton.Click();
        }

       
    }
}
