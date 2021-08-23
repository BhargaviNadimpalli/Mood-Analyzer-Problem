using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyserMsTest
{
    public class MoodAnalyse
    {
        private string message;
        
        public string AnalyseMood(string message)
        {
            if (message.Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
