using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtensionMethods;

namespace WebConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string URL = "https://pt.wikipedia.org/wiki/C_Sharp";
            string html = Web.GetHTMLContentFromURL(URL);
            string textFromURL = Web.GetTextContentFromURL(URL);
        }
    }
}
