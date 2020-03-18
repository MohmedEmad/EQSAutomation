using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using EQSAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectEQS
{
    [TestClass]
    public class BaseTest
    {
        [TestInitialize]
        public void Sharedsteps()

        {
            Driver.Initialize();
            EqsHomePage.GoTo();
            EqsHomePage.Login("mai.fathy@hindawi.com", "maft9384");
            
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Instance.Close();
        }
    }
}
