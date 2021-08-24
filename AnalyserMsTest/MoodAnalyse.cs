using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyserMsTest
{
    public class MoodAnalyse
    {
        private string message;
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomAnalyse(CustomAnalyse.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomAnalyse(CustomAnalyse.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }

        }
    }
}




