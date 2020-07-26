using MoodAnalyser;
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

        [Test]
        public void givenAnyMood_shouldReturnHappy()
        {
            MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
            string mood = moodAnalyser.analyseMood("I am in any mood");
            Assert.AreEqual("happy", mood);
        }

        [Test]
        public void givenNullMood_WhenAnalyse_shouldReturnInvalid()
        {
            try
            {
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
                string mood = moodAnalyser.analyseMood(null);
            }
            catch(MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_EXCEPTION, e.Type);
            }
            
        }

        [Test]
        public void givenEmptyMood_WhenAnalyse_shouldReturnInvalid()
        {
            try
            {
                MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
                string mood = moodAnalyser.analyseMood("");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_EXCEPTION, e.Type);
            }
            
        }



    }
}
