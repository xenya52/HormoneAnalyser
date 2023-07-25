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


        /*<==Test==>*/

        //ShowSiteOfValue
        Console.WriteLine("Type in what site do you want to see");
        int siteNumber = Convert.ToInt32(Console.ReadLine());
        values.ShowSiteOfValue(siteNumber);
    }
}