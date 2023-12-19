using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint7.Project.V2.Lib;

namespace Tyuiu.PimenovaTS.Sprint7.Project.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = @"C:\Sprint7\InPutDataFile.csv";

            int row = 1;
            int column = 1;
            string res = ds.CollectTextFromFile(path, row, column);

            string wait = "";
            Assert.AreEqual(wait, res);
        }
    }
}
