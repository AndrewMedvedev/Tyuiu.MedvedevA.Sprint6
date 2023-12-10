using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevA.Sprint6.Task5.V15.Lib;

namespace Tyuiu.MedvedevA.Sprint6.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask5V15.txt";
            CollectionAssert.AreEqual(new double[] { 3.36, 4.13 }, ds.LoadFromDataFile(path));
        }
    }
}
