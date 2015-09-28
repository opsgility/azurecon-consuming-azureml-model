using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

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