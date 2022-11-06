using MoodAnalayser;
using MoodAnalayserUC1;

namespace MoodAnalayserUC1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Message_AnalayserSad()
        {
            //arrange
            string expectedOutput = "SAD";
            string message = "I am in Sad Mood";
            Mood a = new Mood(message);
            //act
            string actualoutput = a.AnalyseMood();
            //assert
            Assert.AreEqual(expectedOutput, actualoutput);
        }
        [TestMethod]
        public void Message_AnalayserHappy()
        {
            //arrange
            string expectedOutput = "HAPPY";
            string message = "I am in HAPPY Mood";
            Mood a = new Mood(message);
            //act
            string actualoutput = a.AnalyseMood();
            //assert
            Assert.AreEqual(expectedOutput, actualoutput);
        }
    } 
}