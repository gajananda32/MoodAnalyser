using System.Globalization;

namespace MoodAnalyserUC3;
public class Mood
{
    public static void Main(string[] args)
    {

    }
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
