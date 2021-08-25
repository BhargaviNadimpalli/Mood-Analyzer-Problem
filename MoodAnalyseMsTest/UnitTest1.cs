using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserUsingReflection;

namespace MoodAnalyseMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GiveClassNameAndReturnObject()
        {
            string message = null;
            object expected = new Mood(message);
            object obj = MoodAnalyser.CreateMoodAnalyse("MoodAnalyserUsingReflection.Mood", "Mood");
            expected.Equals(obj);
           //Assert.Equals(expected, obj);
        }
    }
}
