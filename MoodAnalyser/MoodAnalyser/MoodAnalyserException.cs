using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            INVALID_EXCEPTION
        }
        public ExceptionType Type { get; set; }
        public MoodAnalyserException(ExceptionType Type,string message) : base(message)
        {
            this.Type = Type;     
        }
    }
}
