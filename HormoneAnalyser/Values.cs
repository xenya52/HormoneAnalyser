using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HormoneAnalyser;

internal class Values
{

    public List<Value> value { get; set; } = new List<Value>();
    public void creatingAValue(string name, string description, double userValue, double valueToHigh, double valueToLow)
    {
        value = ConfigReader("Hormonvalues.json").value;
        value.Add(new Value(name, description, userValue, valueToHigh, valueToLow));
        JsonToFile(this, "Hormonvalues.json");
    }
    public void deleteAValue(int userInput)
    {
        value = ConfigReader("Hormonvalues.json").value;
        value.Remove(value[userInput]);
        JsonToFile(this, "Hormonvalues.json");
    }
        
    /*ToReadTHEJsonData*/
    public Values ConfigReader(string path) //Reads a json file
    {
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<Values>(json);
    }

    /*ToSaveTheJsonData*/
    public void JsonToFile(object Object, string path) //Converts into a file
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true; //made pretty printing on
        string json = JsonSerializer.Serialize(Object, typeof(Object), options);
        File.WriteAllText(path, json); // Path: C:\Users\Xenmi\Desktop\Software\C# Json\Json\Json\bin\Debug\net6.0
    }

}

