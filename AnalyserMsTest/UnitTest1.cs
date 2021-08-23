using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalyserMsTest;
namespace AnalyserMsTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GiveHappyMoodReturnHappy()
        {
            string expected = "Happy";
            string message = "I am in happy mood";
            MoodAnalyse analyse = new MoodAnalyse();

            string mood = analyse.AnalyseMood(message);

            Assert.AreEqual(expected, mood);
        }
    }
}
