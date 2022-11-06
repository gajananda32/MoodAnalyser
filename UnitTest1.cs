using MoodAnalyserUC5;

namespace MoodAnalyserUC5Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            object expected = new Mood ("HAPPY");
            object obj = MoodAnalyserFactory.MoodAnalyserUsing_Parameterised_Constructor("MoodAnalyserUC5.Mood","Mood");
            expected.Equals(obj);
        }
    }
}