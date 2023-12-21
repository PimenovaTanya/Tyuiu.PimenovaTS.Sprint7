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

            string row = "Магнит";
            int column = 1;
            string res = ds.CollectTextFromFile(row, column);

            string wait = "тел.:8 (800) 200-90-02, почта: info@magnit.ru, головной офис: 350072, Россия, Краснодар, ул. Солнечная, 15/5";
            Assert.AreEqual(wait, res);
        }
    }
}
