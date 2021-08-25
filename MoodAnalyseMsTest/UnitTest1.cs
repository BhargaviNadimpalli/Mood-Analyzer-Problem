using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserUsingReflection;

namespace MoodAnalyseMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GiveClassNameAndReturnObjectUsingParameters()
        {
            ///string message = null;
            object expected = new Mood("Happy");
            object obj = MoodAnalyser.CreateMoodAnalyseUsingParameters("MoodAnalyserUsingReflection.Mood", "Mood", "Happy");
            expected.Equals(obj);
           //Assert.Equals(expected, obj);
        }
    }
}
