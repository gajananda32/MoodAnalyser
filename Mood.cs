using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUC5
{
    public class Mood
    {
        private string message;
        public Mood(string message)
        {
            this.message = message;
        }
        public string AnalysesMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalayserException(MoodAnalayserException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalayserException(MoodAnalayserException.ExceptionType.NULL_MESSAGE, "Mood shuold not be null");
            }
        }
    }
}




