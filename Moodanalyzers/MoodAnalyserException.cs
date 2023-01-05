using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodanalyzers
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            NULL, EMPTY, NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        public ExceptionType type;
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
