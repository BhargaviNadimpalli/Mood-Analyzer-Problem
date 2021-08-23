using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalyserMsTest;
namespace AnalyserMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(null)]
        public void GiveHappyMoodReturnhappy(string message)
        {
            string expected = "Happy";
            
            MoodAnalyse analyse = new MoodAnalyse(message);

            string mood = analyse.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }
    }


}
