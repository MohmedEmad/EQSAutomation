using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using EQSAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;

namespace TestProjectEQS
{
    [TestClass]
    public class ManuscriptPageTest  : BaseTest
    {


        [TestMethod]    
        public void GoToManuscripts()
        {
           
            EqsHomePage.OpenMaunscritPag();
            Assert.AreEqual("Manuscripts", EqsHomePage.GetTitle());
            Console.WriteLine(EqsHomePage.GetTitle());
        }
    }
}
