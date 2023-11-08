using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BogdanovaSA.Sprint4.Task4.V6.Lib;

namespace Tyuiu.BogdanovaSA.Sprint4.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var name = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            string[] res = ds.Calculate(name);
            string[] wait = { "Борис", "Ирина" };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
