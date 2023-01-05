using System;
namespace Moodanalyzers
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string analyzeMood(string message)
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY, "Mood is Empty");
                }
                if (this.message.ToLower().Contains("sad"))
                    return "Sad";
                return "Happy";
            }
            catch (NullReferenceException)
            {
                return "Happy";
            }
        }
    }
}
           