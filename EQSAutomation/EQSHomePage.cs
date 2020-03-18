using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace EQSAutomation
{
    public class EqsHomePage
    {
        public static void GoTo()
        {
            
            Driver.Initialize();
            Driver.Instance.Navigate().GoToUrl("http://beta.eqs.hindawi.com/");


        }

        public static void Login(string username, string password)
        {
            Driver.Instance.FindElement(By.Id("Email")).SendKeys(username);
            Driver.Instance.FindElement(By.Id("next")).Click();
           
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Passwd")));
            
            Driver.Instance.FindElement(By.Id("Passwd")).SendKeys(password);
            Driver.Instance.FindElement(By.Id("signIn")).Click();

        }

        public static void OpenMaunscritPag()
        {
            Driver.Instance.FindElement(By.LinkText("Manuscripts")).Click();
                                                 
        }

        public static string GetTitle()
        {
            return Driver.Instance.FindElement(By.CssSelector("h1")).Text;




        }
    }
}
