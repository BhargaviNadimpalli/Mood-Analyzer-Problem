using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalyserMsTest;
namespace AnalyserMsTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GiveSadMoodReturnSad()
        {
            string expected = "Sad";
            string message = "I am in sad mood";
            MoodAnalyse analyse = new MoodAnalyse(message);

            string mood = analyse.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }
    }
}
