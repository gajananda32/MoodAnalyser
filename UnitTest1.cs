using MoodAnalyserUC2;

namespace MoodAnalyserUC2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow (null)]
        public void ReturnHAppyMood(string message)
        {
            //Arrange
            string expected = "HAPPY";
            Mood m = new Mood(message);
            //Act
            string actual = m.AnalyseMood();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}