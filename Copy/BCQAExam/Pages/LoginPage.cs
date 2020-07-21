using BCQAExam.Core;
using OpenQA.Selenium;

namespace BCQAExam.Pages
{
    public class LoginPage : BasePage
    {
        private IWebElement Email => Driver.FindControl(By.Id("email"), true);

        private IWebElement NewEmail => Driver.FindControl(By.Id("email_create"));

        private IWebElement Password => Driver.FindControl(By.Id("passwd"));

        private IWebElement LoginButton => Driver.FindControl(By.Id("SubmitLogin"));

        private IWebElement CreateAnAccountButton => Driver.FindControl(By.Id("SubmitCreate"));

        public void Login(string email = null, string password = null)
        {
            Email.Clear();
            Email.SendKeys(email);
            Password.Clear();
            Password.SendKeys(password);
            LoginButton.Click();
        }

        public void CreateAccount(string email = null)
        {
            NewEmail.Clear();
            NewEmail.SendKeys(email);
            CreateAnAccountButton.Click();
        }
    }
}
