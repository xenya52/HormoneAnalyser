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

internal class hormonAnalyser
{
    //Values
    public List<Value> valueList { get; set; } = new List<Value>(); //List goes on by 0
    public void creatingAValue(string name, string description, string unit, double userValue, double valueToLow, double valueToHigh)
    {
        valueList = ConfigReader("Hormonvalues.json").valueList;

        valueList.Add(new Value( name, description, unit, userValue, valueToLow, valueToHigh));
        JsonToFile(this, "Hormonvalues.json");

        Console.ReadKey();
        Console.Clear();
    }
    public void editASpecificValue(int valueNumberInput, string valueTypeInput, string userValueChange)
    {
        valueList = ConfigReader("Hormonvalues.json").valueList;

        valueList[valueNumberInput] = valueList.Find(valueTypeInput => valueTypeInput.valueName.Contains(userValueChange));

        JsonToFile(this, "Hormonvalues.json");

        Console.ReadKey();
        Console.Clear();
    }

    public void deleteAValue(int userInput)
    {
        valueList = ConfigReader("Hormonvalues.json").valueList;

        valueList.Remove(valueList[userInput]);
        JsonToFile(this, "Hormonvalues.json");

        Console.ReadKey();
        Console.Clear();
    }

    public void swapValues(int input1, int input2)
    {
        valueList = ConfigReader("Hormonvalues.json").valueList;

        var temp = valueList[input1];

        valueList[input1] = valueList[input2];
        valueList[input2] = temp;

        JsonToFile(this, "Hormonvalues.json");

        Console.ReadKey();
        Console.Clear();
    }

    public void ShowSpecificValue(int input1)
    {

        valueList = ConfigReader("Hormonvalues.json").valueList;

        Console.WriteLine("[" + input1 + "]");
        Console.WriteLine("<ValueName    " + valueList[input1].valueName);
        Console.WriteLine("<Description  " + valueList[input1].valueDescription);
        Console.WriteLine("<UserValue    " + valueList[input1].userValue + " " + valueList[input1].unit);
        Console.WriteLine("<To High      " + valueList[input1].valueToHigh + " " + valueList[input1].unit);
        Console.WriteLine("<To Low       " + valueList[input1].valueToLow + " " + valueList[input1].unit);
        Console.WriteLine();

        Console.ReadKey();
        Console.Clear();
    }

    public void ShowSiteOfValue(int input)
    {
        int site = input;

        input *= 5;

        int valueNumber = input;
        int check = input - 5;

        valueList = ConfigReader("Hormonvalues.json").valueList;

        do
        {
            if (valueNumber < valueList.Count)
            {
                Console.WriteLine("[" + valueNumber + "]");
                Console.WriteLine("<ValueName    " + valueList[valueNumber].valueName);
                Console.WriteLine("<Description  " + valueList[valueNumber].valueDescription);
                Console.WriteLine("<UserValue    " + valueList[valueNumber].userValue + " " + valueList[valueNumber].unit);
                Console.WriteLine();
            }

            input--;
            valueNumber++;

        } while (check < input);

        Console.WriteLine(site);

        Console.ReadKey();
        Console.Clear();
    }

    public void ShowAllValue()
    {
        int count = 0;

        valueList = ConfigReader("Hormonvalues.json").valueList;

        foreach (var list in valueList)
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
        Console.ReadKey();
        Console.Clear();
    }

    /*ToReadTHEJsonData*/
    public hormonAnalyser ConfigReader(string path) //Reads a json file
    {
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<hormonAnalyser>(json);
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

