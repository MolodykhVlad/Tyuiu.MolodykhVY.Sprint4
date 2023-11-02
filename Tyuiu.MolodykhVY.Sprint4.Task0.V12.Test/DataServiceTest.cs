using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint4.Task0.V12.Lib;

namespace Tyuiu.MolodykhVY.Sprint4.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] numArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int res = ds.GetMultEvenArrEl(numArray);
            int wait = 73728;
            Assert.AreEqual(wait, res);

        }
    }
}
