using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint4.Task1.V18.Lib;

namespace Tyuiu.MolodykhVY.Sprint4.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[] numArray = { 6, 7, 6, 7, 5, 7, 6, 7, 9, 4, 6, 5, 8, 5 };
            int res = ds.Calculate(numArray);
            Assert.AreEqual(52, res);
        }
    }
}
