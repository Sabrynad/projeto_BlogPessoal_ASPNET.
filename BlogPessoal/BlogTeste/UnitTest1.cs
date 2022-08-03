using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlogTeste
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]

        public void TesteDeSomaDeDoisValores()
        {
            var result = 5 + 10;

            Assert.AreEqual(15, result);
        }
    }
}
