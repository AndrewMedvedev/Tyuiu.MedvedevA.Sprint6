using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevA.Sprint6.Task7.V15.Lib;
using System.IO;

namespace Tyuiu.MedvedevA.Sprint6.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void File()
        {
            string openedFile = @"C:\DataSprint6\InPutFileTask7V15.csv";
            FileInfo file = new FileInfo(openedFile);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}
