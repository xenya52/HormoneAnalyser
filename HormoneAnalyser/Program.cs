using System;
using System.Data;
using System.Text.Json;//You need to add this
using System.IO; //You need to add this too
using HormoneAnalyser;
using System.Diagnostics.Metrics;

namespace main;

class program
{
    //https://hlcc.haj.gf/ converter
    public static void Main(string[] args)
    {
        
        Values values = new Values();
        int userInput = Convert.ToInt32(Console.ReadLine());
        values.deleteAValue(userInput);
        /* Console.WriteLine("Valuename");
        string Name = Convert.ToString(Console.ReadLine());
        Console.WriteLine("ValueDescription");
        string Description = Convert.ToString(Console.ReadLine());
        Console.WriteLine("UserValue");
        double UserValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ValueToHigh");
        double ValueToHigh = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ValueToLow");
        double ValueToLow = Convert.ToDouble(Console.ReadLine());

        values.creatingAValue(Name, Description, UserValue, ValueToHigh, ValueToLow); */
    }
}