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
        hormonAnalyser values = new hormonAnalyser();

        Console.WriteLine("Write input1");
        int input = Convert.ToInt32(Console.ReadLine());
        values.ShowSiteOfValue(input);

        /* Console.WriteLine("All values");
        values.ShowAllValue(); */

        /*Console.WriteLine("Input1");
        int input1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input2");
        int input2 = Convert.ToInt32(Console.ReadLine());
        values.swapValues(input1, input2); */

        /* values.ShowAllValue();  */

        /*Console.WriteLine("Write the number");
        int input = Convert.ToInt32(Console.ReadLine());
        values.deleteAValue(input); */



        /*Console.WriteLine("Valuename");
        string Name = Convert.ToString(Console.ReadLine());
        Console.WriteLine("ValueDescription");
        string Description = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Unit");
        string unit = Convert.ToString(Console.ReadLine());
        Console.WriteLine("UserValue");
        double UserValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ValueToHigh");
        double ValueToHigh = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ValueToLow");
        double ValueToLow = Convert.ToDouble(Console.ReadLine());

        values.creatingAValue(Name, Description, unit, UserValue, ValueToLow, ValueToHigh);*/
    }
}