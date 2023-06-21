using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HormoneAnalyser;

internal class Values
{

    public List<Value> value { get; set; } = new List<Value>(); //List goes on by 0
    public void creatingAValue(string name, string description, string unit, double userValue, double valueToLow, double valueToHigh)
    {
        value = ConfigReader("Hormonvalues.json").value;
        value.Add(new Value( name, description, unit, userValue, valueToLow, valueToHigh));
        JsonToFile(this, "Hormonvalues.json");
    }
    public void deleteAValue(int userInput)
    {
        value = ConfigReader("Hormonvalues.json").value;
        value.Remove(value[userInput]);
        JsonToFile(this, "Hormonvalues.json");
    }

    public void swapValues(int input1, int input2)
    {
        value = ConfigReader("Hormonvalues.json").value;

        var temp = value[input1];

        value[input1] = value[input2];
        value[input2] = temp;

        JsonToFile(this, "Hormonvalues.json");
    }

    public void ShowSpecificValue(int input1)
    {

        value = ConfigReader("Hormonvalues.json").value;

        Console.WriteLine("[" + input1 + "]");
        Console.WriteLine("<ValueName    " + value[input1].valueName);
        Console.WriteLine("<Description  " + value[input1].valueDescription);
        Console.WriteLine("<UserValue    " + value[input1].userValue + " " + value[input1].unit);
        Console.WriteLine("<To High      " + value[input1].valueToHigh + " " + value[input1].unit);
        Console.WriteLine("<To Low       " + value[input1].valueToLow + " " + value[input1].unit);
        Console.WriteLine();
    }

    public void ShowSiteOfValue(int input)
    {
        int valueNumber = 0;
        int site = input;

        input *= 5;
        int check = input - 5;

        value = ConfigReader("Hormonvalues.json").value;

        do
        {
            if (valueNumber < value.Count)
            {
                Console.WriteLine("[" + valueNumber + "]");
                Console.WriteLine("<ValueName    " + value[valueNumber].valueName);
                Console.WriteLine("<Description  " + value[valueNumber].valueDescription);
                Console.WriteLine("<UserValue    " + value[valueNumber].userValue + " " + value[valueNumber].unit);
                Console.WriteLine();
            }

            valueNumber++;
        } while (input < check);

        Console.WriteLine(site);
    }

    public void ShowAllValue()
    {
        int count = 0;

        value = ConfigReader("Hormonvalues.json").value;

        foreach (var list in value)
        {

            Console.WriteLine("[" + count + "]");
            Console.WriteLine("<ValueName    " + list.valueName);
            Console.WriteLine("<Description  " + list.valueDescription);
            Console.WriteLine("<UserValue    " + list.userValue + " " + list.unit);
            Console.WriteLine("<To High      " + list.valueToHigh + " " + list.unit);
            Console.WriteLine("<To Low       " + list.valueToLow + " " + list.unit);
            Console.WriteLine();

            count++;
        }
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

