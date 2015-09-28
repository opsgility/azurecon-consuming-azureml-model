using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AzureMLSample.Helpers
{
    class Analyzer
    {
        public struct TextAnalysisResult
        {
            public List<string> KeyPhrases { get; set; }
            public double SentimentIndex;
        }
        public static TextAnalysisResult AnalyzeText(string inputText, string accountkey)
        {
            TextAnalysisResult result = new TextAnalysisResult();
            // start code

            // end code
            return result;
        }

    }

}