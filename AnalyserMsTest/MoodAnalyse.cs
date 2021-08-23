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
                if (this.message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch
            {
                return "sad";
            }

        }
    }
}
