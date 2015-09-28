using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using AzureMLSample.Helpers;
using System.Configuration;

namespace AzureMLSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PerformAnalysis(String inputText)
        {
            AzureMLSample.Helpers.Analyzer.TextAnalysisResult myTAR;
            myTAR = AzureMLSample.Helpers.Analyzer.AnalyzeText(inputText, ConfigurationManager.AppSettings["AccountKey"]);
            ViewBag.SentimentIndex = myTAR.SentimentIndex;
            ViewBag.KeyPhrases = myTAR.KeyPhrases;
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}