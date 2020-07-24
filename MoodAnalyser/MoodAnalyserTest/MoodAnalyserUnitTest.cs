using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class MoodAnalyserUnitTest
    { 
        [Test]
        public void givenMood_WhenHappy_ShouldReturnHappy()
        {
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility("happy");
                string mood = moodAnalyser.analyseMood();
                Assert.AreEqual("happy", mood); 
        }

        [Test]
        public void givenMood_WhenSad_ShouldReturnHappy()
        {
            MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility("I am in sad mood");
            string mood = moodAnalyser.analyseMood();
            Assert.AreEqual("sad", mood);
        }

        [Test]
        public void givenAnyMood_shouldReturnHappy()
        {
            MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility("I am in any mood");
            string mood = moodAnalyser.analyseMood();
            Assert.AreEqual("happy", mood);
        }

       

    }
}
