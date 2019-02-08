using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DatoConsoleSimpleAfprovning;
using DateClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Year()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.AreEqual(2019, aDate.GetYear());
        }
        [TestMethod]
        public void Test_Month()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.AreEqual(2, aDate.GetMonth());
        }
        [TestMethod]
        public void Test_Day()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.AreEqual(6, aDate.GetDay());
        }
        [TestMethod]
        public void Test_set()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            aDate.SetDay(92);
            Assert.AreEqual(92, aDate.GetDay());
        }
        [TestMethod]
        public void Test_setMonth()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            aDate.SetMonth(15);
            Assert.AreEqual(15, aDate.GetMonth());
        }
        [TestMethod]
        public void Test_setDay()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            aDate.SetYear(2015);
            Assert.AreEqual(2015, aDate.GetYear());
        }
        [TestMethod]
        public void Test_format()
        {
            UclDate aDate = new UclDate(2019, 4, 600000000);
            Assert.AreEqual("2019,2,6", aDate.GetDatoStringYMD());
        }
        [TestMethod]
        public void Test_ugedag()
        {
            UclDate aDate = new UclDate(2019, 15, 90945);
            Assert.AreEqual(1, aDate.GetWeekDay());
        }
    }
}
