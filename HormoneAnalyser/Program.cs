using System;
using System.Data;
using System.Text.Json;//You need to add this
using System.IO; //You need to add this too
using HormoneAnalyser;

namespace main;

class program
{
    public static void Main(string[] args)
    {
        Values testValueSave = new();
        testValueSave.TSH = 666;
        testValueSave.FT3 = 666;
        testValueSave.FT4 = 666;
        testValueSave.TAK = 666;
        testValueSave.TRAK = 666;
        testValueSave.Prolaktin = 666;
        testValueSave.LH = 666;
        testValueSave.FSH = 666;
        testValueSave.Estradiol = 666;
        testValueSave.Testosteron = 666;
        testValueSave.SHBG = 666;
        testValueSave.FAI = 666;
        testValueSave.Progesteron = 666;
        testValueSave.Androstendion = 666;
        testValueSave.DTES17OH = 666;
        testValueSave.Progesteron = 666;
        testValueSave.AndroGluc = 666;
        testValueSave.ACTH = 666;
        testValueSave.Cortisol = 666;
        testValueSave.DHEAS = 666;
        testValueSave.STH = 666;
        testValueSave.IGF1 = 666;
        testValueSave.CPeptid = 666;
        testValueSave.HbA1c = 666;
        testValueSave.BZppRgbg = 666;
        testValueSave.PTH = 666;
        testValueSave.CRP = 666;
        testValueSave.CALS = 666;
        testValueSave.CAPH = 666;
        testValueSave.CKDM1 = 666;
        testValueSave.KREA = 666;
        testValueSave.GOT = 666;
        testValueSave.GPT = 666;
        testValueSave.GGT = 666;
        testValueSave.PHOS = 666;
        testValueSave.ERY = 666;
        testValueSave.HB = 666;
        testValueSave.HBE = 666;
        testValueSave.HK = 666;
        testValueSave.LEUK = 666;
        testValueSave.MCHC = 666;
        testValueSave.MCV = 666;
        testValueSave.RDW = 666;
        testValueSave.THRO = 666;



    }
    public static void JsonToFile(object Object, string path)
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true;
        string json = JsonSerializer.Serialize(Object, typeof(Object), options);
        File.WriteAllText(path, json); // Path: C:\Users\Xenmi\Desktop\Software\C# Json\Json\Json\bin\Debug\net6.0
    }
}