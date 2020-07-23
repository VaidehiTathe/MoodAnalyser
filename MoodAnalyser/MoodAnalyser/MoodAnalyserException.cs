using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    [Serializable]
    public class MoodAnalyserException : Exception
    {
        public MoodAnalyserException(string message) : base(message)
        {

        }
    }
}
