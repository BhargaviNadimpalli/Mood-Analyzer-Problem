using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalyserMsTest;
namespace AnalyserMsTest
{
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
     
       

    public void GiveNullMood()
    {
        try
        {
            string message = "Null";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            string mood = moodAnalyse.AnalyseMood();
        }
        catch (CustomAnalyse e)
        {
            Assert.AreEqual("Mood should not be null", e.Message);
        }
    }
}
}
