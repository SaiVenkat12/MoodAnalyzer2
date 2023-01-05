using Moodanalyzers;

namespace MoodAnalyseTest
{
    public class Tests
    {

        [Test]
        public void GivenSadMessage_WhenAnalyzingMood_ShouldReturnSad()
        {
            //Arrange
            string message = "I am in sad mood";
            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.analyzeMood(message);
            //Assert
            Assert.AreEqual("Sad", actual);
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyzingMood_ShouldReturnHappy()
        {
            //Arrange
            string message = "I am in any mood";
            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.analyzeMood(message);
            //Assert
            Assert.AreEqual("Happy", actual);
        }
        [Test]
        public void GivenNullMood_ShouldReturnHappy()
        {
            string message = null;
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.analyzeMood(message);
            Assert.AreEqual(actual, "Happy");
        }
        [Test]
        public void GivenEmptyMessage_ShouldThrowException()
        {
            string message = " ";
            string actual = "Mood is Empty";
            try
            {
                MoodAnalyser analyser = new MoodAnalyser(message);
                analyser.analyzeMood(message);
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(actual, message);
            }
        }
    }
}