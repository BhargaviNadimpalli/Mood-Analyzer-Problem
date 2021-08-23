using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalyserMsTest;
namespace AnalyserMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(null)]
        public void GiveSadMoodReturnSad(string message)
        {
            string expected = "sad";
            
            MoodAnalyse analyse = new MoodAnalyse(message);

            string mood = analyse.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }
    }


}
