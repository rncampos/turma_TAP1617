using RestSharp;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IBM
            #region NLU
            /*
            // url da api
            string API = "https://watson-api-explorer.mybluemix.net/natural-language-understanding/api/v1/analyze?";
            // Public webpage to analyze
            string url = "https%3A%2F%2Fwww.thetimes.co.uk%2Fedition%2Fnews%2Feurope-fears-turkey-will-renege-on-migrant-deal-m3tgm550l&version=2017-02-27";
            // Set this to false to disable document level sentiment analysis
            Boolean documentSentiment = true;
            // Set this to true to return keyword information for subjects and objects
            Boolean semanticKeywords = false;
            // Set this to true to return entity information for subjects and objects
            Boolean semanticEntities = false;
            // Maximum number of semantic_roles results to return
            int semanticLimit = 50;
            //Enter a custom model ID to override the default en-news relations model
            string relationModel = "en-news";
            // Set this to true to return sentiment information for detected keywords
            Boolean keywordSentiment = true;
            // Set this to true to return emotion information for detected keywords
            Boolean keywordEmotion = true;
            // Maximum number of keywords to return
            int keywordLimit = 50;
            // Set this to true to return sentiment information for detected entities
            Boolean entitiesSentiment = true;
            // Set this to true to return emotion information for detected entities
            Boolean entitiesEmotion = true;
            // Maximum number of entities to return
            int entitiesLimit = 50;
            // Set this to false to hide document - level emotion results
            Boolean emotionDocument = true;
            // Maximum number of concepts to return
            int conceptsLimit = 8;
            // Whether to use raw HTML content if text cleaning fails
            Boolean fallbackToRaw = true;
            // Set to false to disable text cleaning
            Boolean clean = true;
            // Set this to true to show the analyzed text in the response
            Boolean returnAnalyzedText = false;
            // Comma separated list of analysis features 
            //(concepts, entities, keywords, categories, emotion, sentiment, metadata, relations, semantic_roles)
            string features = "keywords";


            var client = new RestClient(API +
                "sentiment.document=" + documentSentiment +
                "&semantic_roles.keywords=" + semanticKeywords +
                "&semantic_roles.entities=" + semanticEntities +
                "&semantic_roles.limit=" + semanticLimit +
                "&relations.model=" + relationModel +
                "&keywords.sentiment=" + keywordSentiment +
                "&keywords.emotion=" + keywordEmotion +
                "&keywords.limit=" + keywordLimit +
                "&entities.sentiment=" + entitiesSentiment +
                "&entities.emotion=" + entitiesEmotion +
                "&entities.limit=" + entitiesLimit +
                "&emotion.document=" + emotionDocument +
                "&concepts.limit="+ conceptsLimit + 
                "&fallback_to_raw="+ fallbackToRaw + 
                "&clean="+ clean + 
                "&return_analyzed_text="+ returnAnalyzedText + 
                "&features="+ features + 
                "&url=" + url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "application/json");
            IRestResponse response = client.Execute(request);
            JObject o = JObject.Parse(response.Content);
            foreach (var results in o["keywords"])
            {
                string text = (string)results["text"];
                string relevance = (string)results["relevance"];
                Console.WriteLine("text: {0}; relevance: {1}", text, relevance);
            }  
            */
            #endregion
            #region LT
            /*
            string API = "https://watson-api-explorer.mybluemix.net/language-translator/api/v2/translate?";
            // Texto a ser traduzido
            string text = "Como estás?";
            // Lingua Destino
            string target = "EN";
            // Lingua Origem
            string source = "PT";
            var client = new RestClient(API + "text="+ text + "&target="+ target + "&source="+ source );
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "text/plain");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            IRestResponse response = client.Execute(request);
            JObject o = JObject.Parse(response.Content);

            Console.WriteLine(o["translations"][0]["translation"]);
            */
            #endregion
            #region GT
            string API = "https://watson-api-explorer.mybluemix.net/tone-analyzer/api/v3/tone?";
            string text = "FUCK!";
            string version = "2016-05-19";
            Boolean sentences = false;
            var client = new RestClient(API + "text="+ text + "&version="+ version +"&sentences=" + sentences);
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "application/json");
            IRestResponse response = client.Execute(request);
            JObject o = JObject.Parse(response.Content);
            foreach(var result in o["document_tone"]["tone_categories"])
            {
                Console.WriteLine(result["category_name"]);
                foreach (var result1 in result["tones"]) {
                    if ((double)result1["score"] != 0.0)
                    {
                        string tones = (string)result1["tone_name"];
                        double score = (double)result1["score"];
                        Console.WriteLine("Tone Name: {0}; Score: {1}", tones, score);
                    }
                }
            }
            #endregion
            #endregion
            Console.ReadLine();


            
            
            
        }
    }
}
