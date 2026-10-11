using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelovolovVS.Sprint2.Task6.V13.Lib;

namespace Tyuiu.BelovolovVS.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDayRegularDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("15.05.2024", ds.FindDateOfNextDay(2024, 5, 14));
        }

        [TestMethod]
        public void ValidFindDateOfNextDayLeapFebruary()
        {
            DataService ds = new DataService();
            Assert.AreEqual("29.02.2024", ds.FindDateOfNextDay(2024, 2, 28));
            Assert.AreEqual("01.03.2024", ds.FindDateOfNextDay(2024, 2, 29));
        }

        [TestMethod]
        public void ValidFindDateOfNextDayNewYear()
        {
            DataService ds = new DataService();
            Assert.AreEqual("01.01.2025", ds.FindDateOfNextDay(2024, 12, 31));
        }
    }
}