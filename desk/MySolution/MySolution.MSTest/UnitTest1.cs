using mySolution.WinForms.Models;

namespace MySolution.MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10;
            int b = 5;
            int expected = 5;
            int actual = Nwd.FindNwd(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 10;
            int b = 0;
            int expected = 10;
            int actual = Nwd.FindNwd(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int a = 0;
            int b = 10;
            int expected = 10;
            int actual = Nwd.FindNwd(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int a = 0;
            int b = 0;
            int expected = 0;
            int actual = Nwd.FindNwd(a, b);
            Assert.AreEqual(expected, actual);
        }
    }

}