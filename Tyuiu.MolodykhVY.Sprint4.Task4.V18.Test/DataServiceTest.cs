using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint4.Task4.V18.Lib;

namespace Tyuiu.MolodykhVY.Sprint4.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] { { 4, 7, 4, 5, 4 },
                                         { 4, 4, 5, 6, 7 },
                                         { 7, 5, 6, 6, 6 },
                                         { 6, 7, 6, 6, 4 },
                                         { 5, 6, 6, 6, 5 } };
            int[,] res = ds.Calculate(mas);
            int[,] wait = new int[5, 5] { { 4, 0, 4, 0, 4 },
                                          { 4, 4, 0, 6, 0 },
                                          { 0, 0, 6, 6, 6 },
                                          { 6, 0, 6, 6, 4 },
                                          { 0, 6, 6, 6, 0 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
