using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AzureMLSample.Helpers
{
    public class Analyzer
    {
        public struct TextAnalysisResult
        {
            public List<string> KeyPhrases { get; set; }
            public double SentimentIndex;
        }


    }

}