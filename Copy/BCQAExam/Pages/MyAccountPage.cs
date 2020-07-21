using BCQAExam.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BCQAExam.Pages
{
    public class MyAccountPage:BasePage
    {
        private IWebElement AccountName => Driver.FindControl(By.XPath("//a[@title='View my customer account']"));
        private IWebElement MyAccountTab => Driver.FindControl(By.XPath("//span[@class='navigation_page']"));

        private IWebElement SignOutLink => Driver.FindControl(By.LinkText("Sign out"));

        public void AssertAccountName(string userName)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(userName, AccountName.Text);
                Assert.AreEqual("My account", MyAccountTab.Text);
            });
        }

        public void SignOut()
        {
            SignOutLink.Click();
        }
    }
}
