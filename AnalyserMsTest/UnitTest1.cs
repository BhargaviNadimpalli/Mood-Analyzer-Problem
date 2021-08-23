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
            MoodAnalyse analyse = new MoodAnalyse();

            string mood = analyse.AnalyseMood(message);

            Assert.AreEqual(expected, mood);
        }
    }
}
