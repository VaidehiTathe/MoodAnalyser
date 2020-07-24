using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class MoodAnalyserUnitTest
    { 
        [Test]
        public void givenMood_WhenHappy_ShouldReturnHappy()
        {
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
                string mood = moodAnalyser.analyseMood("happy");
                Assert.AreEqual("happy", mood); 
        }

        [Test]
        public void givenMood_WhenSad_ShouldReturnHappy()
        {
            MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
            string mood = moodAnalyser.analyseMood("I am in sad mood");
            Assert.AreEqual("sad", mood);
        }

    }
}
