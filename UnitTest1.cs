using MoodAnalyserUC6;

namespace MoodAnalyserUC6Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = MoodAnalyserFacotry.SetField("HAPPY", "message");
            Assert.AreEqual("HAPPY", result);
        }
    }
}