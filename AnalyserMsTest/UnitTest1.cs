using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalyserMsTest;
namespace AnalyserMsTest
{
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
     
        public void GiveEmptyMood()
        {
        try
        {
            string message = "";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            string mood = moodAnalyse.AnalyseMood();
        }
        catch (CustomAnalyse e)
        {
            Assert.AreEqual("Mood should not be empty", e.Message);
        }
        }
   
}
}
