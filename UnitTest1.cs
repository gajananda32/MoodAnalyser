using MoodAnalyserUC4;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MoodAnalyserClassName_ShouldReturnMoodAnalysis_Object()
        {
            string message = null;
            object expected = new Mood(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserUC4.Mood", "Mood");
            expected.Equals(obj);
        }
        [TestMethod]
        public void ImproperClassName_Should_Return()
        {
            string expected = "class not found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserUC4.Mood", "Mood");
            }
            catch (MoodAnalayserException exception)
            {

                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}