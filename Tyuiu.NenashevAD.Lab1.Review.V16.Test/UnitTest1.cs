using Tyuiu.NenashevAD.Lab1.Review.V16.Lib;

namespace Tyuiu.NenashevAD.Lab1.Review.V16.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 z1 = new Class1();
            Class2 z2 = new Class2();
            int x = -2;
            int y = 2;
            int a = 3;
            double zf1 = z1.Zfunc1(x, y, a);
            double zf2 = z2.Zfunc2(x, y, a);
            Assert.AreEqual(2.39, zf1);
            Assert.AreEqual(-28.0, zf2);
        }
    }
}