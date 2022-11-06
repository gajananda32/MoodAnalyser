using MoodAnalyserUC3;

namespace MoodAnalyserUC3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Empty_Mood_Throw_MoodAnalysesException()
        {
            try
            {
                string message = "";
                Mood m = new Mood(message);
                string actual = m.AnalysesMood();
            }
            catch (MoodAnalayserException e)
            {
                Assert.AreEqual("Mood should not be empty",e.Message);
            }
        }
        [TestMethod]
       // [DataRow (null)]
        public void Given_Null_Mood_Throw_MoodAnalysesException()
        {
            try
            {
                string excepted = null ;
                Mood m = new Mood(excepted);
                string actual =m.AnalysesMood();
            }
            catch (MoodAnalayserException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
    }
}