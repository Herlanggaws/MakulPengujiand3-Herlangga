using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProjectCalculatorFix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPenjumlahan()
        {
            MainWindow mW = new MainWindow();
            double a = 1;
            double b = 2;
            double hasil = 3;
            double actual = mW.jumlah(a, b);
            Assert.AreEqual<double>(hasil,actual,"Integer Salah");

        }

        [TestMethod]
        public void TestMethodPengurangan()
        {
            MainWindow mW = new MainWindow();
            double a = 3;
            double b = 2;
            double hasil = 1;
            double actual = mW.kurang(a, b);
            Assert.AreEqual<double>(hasil, actual, "Integer Salah");

        }

        [TestMethod]
        public void TestMethodPerkalian()
        {
            MainWindow mW = new MainWindow();
            double a = 1;
            double b = 2;
            double hasil = 2;
            double actual = mW.kali(a, b);
            Assert.AreEqual<double>(hasil, actual, "Integer Salah");

        }

        [TestMethod]
        public void TestMethodPembagian()
        {
            MainWindow mW = new MainWindow();
            double a = 4;
            double b = 2;
            double hasil = 2;
            double actual = mW.bagi(a, b);
            Assert.AreEqual<double>(hasil, actual, "Integer Salah");

        }
    }
}
