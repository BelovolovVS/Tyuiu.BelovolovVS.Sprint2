using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelovolovVS.Sprint2.Task3.V20.Lib;

namespace Tyuiu.BelovolovVS.Sprint2.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
    }
}