using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtensionMethods;

namespace OpenNLPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler texto a partir de página HTML. Sugiro o uso de métodos existentes na pág Web.cs
            string textFromURL = 

            string[] sentences = textFromURL.SplitTextIntoSentences1();
            string[] tokens = textFromURL.Tokenizer_RuleBased(); //Se quiser que o sistema faça split considerando hypen tenho que passar como argumento true
            string[] tokens1 = textFromURL.Tokenizer(); //ao contrário do anterior que é rule-based este é baseado num modelo. o autor diz que o outro é mais preciso
            string[] pos1 = textFromURL.PoS(); //PoS para English

            //Para o NER é necessário especificar quais as tags a considerar na marcação do texto
            string[] tags = new string[] { "date", "location", "money", "organization", "percentage", "person", "time" };
            string ner = textFromURL.NER(tags); //NER para English
        }
    }
}
