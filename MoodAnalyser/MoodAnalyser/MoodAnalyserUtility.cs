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
                if(message.Equals("happy") || message.Equals("I am in any mood"))
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
