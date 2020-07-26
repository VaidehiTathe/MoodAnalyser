using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{ 
    public class MoodAnalyserUtility
    {
        private string message;

        public MoodAnalyserUtility()
        {

        }

        public MoodAnalyserUtility(string message)
        {
            this.message = message;
        }
         public string analyseMood(string message)
         {
             try
             {
                 if (message == null)
                 {
                     return "happy";
                 }

                 if (message.Equals("happy") || message.Equals("I am in any mood"))
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
                 throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.INVALID_EXCEPTION, "Please Entered Proper Mood");
             }
         }
    }
}
