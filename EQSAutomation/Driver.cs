using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace EQSAutomation
{
    public class Driver
    {

        public static IWebDriver Instance;

        public static void Initialize()
        {
            Instance = new FirefoxDriver();
        }
    }
}
