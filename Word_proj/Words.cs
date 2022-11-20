using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Word_proj
{
    public class Words
    {
        public Words()
        {

        }
        public string getallWords()
        {
            string text = "";
            string path = "C:\\Users\\Cuper\\Desktop\\Cupi\\FH\\5.Sem\\fprog\\Wordcount\\Testfolder";
            foreach (string file in Directory.EnumerateFiles(path, "*.txt", SearchOption.AllDirectories))
            {
                text += File.ReadAllText(file);
                text += " ";

            }
            Console.WriteLine(text);
            return text;
        }
    }
}
