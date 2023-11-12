using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint4.Task7.V2.Lib;

namespace Tyuiu.MolodykhVY.Sprint4.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "597643158942";

            int res = ds.Calculate(3, 4, value);

            int wait = 39;

            Assert.AreEqual(wait, res);
        }
    }
}
