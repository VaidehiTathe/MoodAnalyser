using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserUtility
    {
        public string analyseMood(String message)
        {
            try
            {
                if(message.Equals("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyserException("Please enter correct message");
            }
        }
    }
}
