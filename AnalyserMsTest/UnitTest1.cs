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
            MoodAnalyse analyse = new MoodAnalyse(message);

            string mood = analyse.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }
    }
}
