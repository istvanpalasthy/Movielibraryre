using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movielibrary
{
    class Movies
    {
         
        static void Main(string[] args)
        {
        }
    }

    class FileHandler
    {
        public Dictionary<string, Dictionary<string, string>> IniConvertToDict(string filename)
        {
            Dictionary<string, Dictionary<string, string>> sectionContainer = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> properties = new Dictionary<string, string>();
            StreamReader sr = new StreamReader(filename);
            string line = sr.ReadLine();
            while (line != null)
            {
                if (line.Contains("[") && line.Contains("]"))
                {
                    properties = new Dictionary<string, string>();
                    sectionContainer.Add(line, properties);
                }
                else if (line.Contains("="))
                {
                    string[] propertyList = line.Split("=");
                    properties.Add(propertyList[0], propertyList[1]);
                }
                line = sr.ReadLine();
            }
            Console.WriteLine(sectionContainer);
            return sectionContainer;
        
    }
    }
}
