using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint5.TaskReview.V18.Lib;
using System.IO;

namespace Tyuiu.IvanovJD.Sprint5.TaskReview.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test7()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V18.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileEx = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileEx);
        }
    }
}