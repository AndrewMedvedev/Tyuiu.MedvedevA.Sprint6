using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevA.Sprint6.Task3.V28.Lib;

namespace Tyuiu.MedvedevA.Sprint6.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] numsMat = new int[5, 5] { { -9, 8, 9, 16, -18,},
                                          {  -13, -11, -20, -15, 9,},
                                          {  18, 13, -12, -15, -11,},
                                          {   10, -2, 19, -4, -10,},
                                          {   6, -20, -4, 13, -14,}, };

            int[,] res = ds.Calculate(numsMat);
            int[,] numsWait = new int[5, 5] { { -9, 8, 9, 16, -18,},
                                          {  -13, -11, -20, -15, 9,},
                                          {  18, 13, -12, -15, -11,},
                                          {   10, -2, 19, -4, -10,},
                                          {   6, -20, -4, 13, -14,}, };
            CollectionAssert.AreEqual(numsWait, res);
        }
    }
}
