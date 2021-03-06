using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserUsingReflection;
using System;
using System.Reflection;

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

        /// <summary>
        /// Using reflection to invoke method UC6.1
        /// </summary>
        [TestMethod]
        ///[TestCategory("InvokeMethodReflection")]
        public void GiveInvokeMethod()
        {

            string actual;
            string message = "I am in a Happy mood";
            string methodName = "AnalyseMood";
            string expected = "Happy";


            try
            {
                MoodAnalyser ma = new MoodAnalyser();
                actual = ma.InvokeMethod(methodName, message);
            }
            catch (CustomAnalyse e)
            {
                throw new Exception(e.Message);
            }
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Given Happy Message with improper method name UC6.2
        /// </summary>
        public void GiveInvokeMethodThrowException()
        {

            string actual;
            string message = "I am in a Happy mood";
            string methodName = "Analyse";
            string expected = "Happy";


            try
            {
                MoodAnalyser ma = new MoodAnalyser();
                actual = ma.InvokeMethod(methodName, message);
            }
            catch (CustomAnalyse e)
            {
                throw new Exception(e.Message);
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
