using System;
using System.Windows;
using System.Windows.Forms;
using JournalLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{
    [TestClass]
    public class TestJournal
    {
        [TestMethod]
        public void TestAvotizTrue()
        {
            Assert.IsTrue(Avtoriz.ValidLogin("azAZ09"));
        }

        [TestMethod]
        public void TestAvotizFalse()
        {
            Assert.IsFalse(Avtoriz.ValidLogin("@Кот!*"));
        }
    }
}
