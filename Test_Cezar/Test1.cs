using Microsoft.VisualStudio.TestPlatform.TestHost;
using Testy;

namespace Test_Cezar
{
    [TestClass]
    public sealed class ProgramTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string wynik = Testy.Program.Szyfrowanie("abc", 3);

            Assert.AreEqual("def", wynik);
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            string wynik = Testy.Program.Szyfrowanie("xyz", 3);

            Assert.AreEqual("abc", wynik);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string wynik = Testy.Program.Szyfrowanie("def", -3);

            Assert.AreEqual("abc", wynik);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string wynik = Testy.Program.Szyfrowanie("abc", 29);

            Assert.AreEqual("def", wynik);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string wynik = Testy.Program.Szyfrowanie("ab cd", 2);

            Assert.AreEqual("cd ef", wynik);
        }
    }
}
