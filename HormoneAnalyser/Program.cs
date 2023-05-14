using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text.Json;//You need to add this
using System.IO; //You need to add this too
using ServiceStack.Text;
using HormoneAnalyser;

namespace main;

class program
{
    public static void Main(string[] args)
    {

        public static void JsonToFile(object Object, string path)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string json = JsonSerializer.Serialize(Object, typeof(Object), options);
            File.WriteAllText(path, json); // Path: C:\Users\Xenmi\Desktop\Software\C# Json\Json\Json\bin\Debug\net6.0
        }
    }
}