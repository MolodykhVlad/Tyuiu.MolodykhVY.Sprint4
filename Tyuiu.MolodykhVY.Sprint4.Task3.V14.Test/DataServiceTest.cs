using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint4.Task3.V14.Lib;
namespace Tyuiu.MolodykhVY.Sprint4.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 0, 55, 6, 7, 55 },
                            { 9, 5, 4446, 7, 7 },
                            { 7, 4, 9, 3, 2145 },
                            { 33, 4, -7, 2445, 4 },
                            { 4, 6009, 8, 666, 7 } };
            int res = ds.Calculate(matrix);
            int wait = 2445;
            Assert.AreEqual(wait, res);
        }
    }
}
