using System;
namespace Moodanalyzers
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string analyzeMood(string message)
        {
            if (this.message.ToLower().Contains("sad"))
                return "Sad";
            return "Happy";
        }
    }
}
           