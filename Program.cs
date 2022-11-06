namespace MoodAnalyserUC2;
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
    public string AnalyseMood()
    {
        try
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
        catch
        {
            return "HAPPY";
        }
    } 
}
