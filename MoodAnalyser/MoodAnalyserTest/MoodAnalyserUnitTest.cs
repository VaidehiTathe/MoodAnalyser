using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class MoodAnalyserUnitTest
    { 
        [Test]
        public void givenMood_WhenHappy_ShouldReturnHappy()
        {
            try
            {
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
                string mood = moodAnalyser.analyseMood("happy");
                Assert.AreEqual("happy", mood);
            }
            catch (MoodAnalyser.MoodAnalyserException e)
            {
                Assert.AreEqual("please enter proper message", e.Message);
            }
        }
    }
}