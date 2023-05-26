using System;
using System.Data;
using System.Text.Json;//You need to add this
using System.IO; //You need to add this too
using HormoneAnalyser;
using System.Diagnostics.Metrics;

namespace main;

class program
{
    public static void Main(string[] args)
    {
        Values valuesToLowTsgMtF = new(); //ng/ml
        valuesToLowTsgMtF.TSH = 0.3;
        valuesToLowTsgMtF.FT3 = 3.3;
        valuesToLowTsgMtF.FT4 = 0.72;
        valuesToLowTsgMtF.TAK = 0;
        valuesToLowTsgMtF.TRAK = 0; //Eig. Pronzent
        valuesToLowTsgMtF.Prolaktin = 3.8;
        valuesToLowTsgMtF.LH = 0; //Testoproduktion
        valuesToLowTsgMtF.FSH = 0;
        valuesToLowTsgMtF.Estradiol = 99;
        valuesToLowTsgMtF.Testosteron = 0.14;
        valuesToLowTsgMtF.SHBG = 18; //nmol/l
        valuesToLowTsgMtF.FAI = 5.1;
        valuesToLowTsgMtF.Progesteron = 0.9;
        valuesToLowTsgMtF.Androstendion = 0.32; //µg/l
        valuesToLowTsgMtF.DTES17OH = 14; //ng/dl
        valuesToLowTsgMtF.AndroGluc = 0.21;
        valuesToLowTsgMtF.ACTH = 0.9; //Von 7-10 Uhr
        valuesToLowTsgMtF.Cortisol = 4; //µg/dL
        valuesToLowTsgMtF.DHEAS = 29; //µg/dl
        valuesToLowTsgMtF.STH = -1;
        valuesToLowTsgMtF.IGF1 = 133; //22 - 24 Jahre ng/ml
        valuesToLowTsgMtF.CPeptid = 1.4;
        valuesToLowTsgMtF.HbA1c = 0.8; //Nanogramm pro mililieter
        valuesToLowTsgMtF.BZppRgbg = 0; //????????????????
        valuesToLowTsgMtF.PTH = 1.1;
        valuesToLowTsgMtF.CRP = -1; //ml/dl
        valuesToLowTsgMtF.CALS = 2.08; //mmol
        valuesToLowTsgMtF.CKDM1 = 0; //????????????
        valuesToLowTsgMtF.KREA = 0.65;
        valuesToLowTsgMtF.GOT = -1;
        valuesToLowTsgMtF.GPT = -1;
        valuesToLowTsgMtF.GGT = -1;
        valuesToLowTsgMtF.PHOS = 8.83;
        valuesToLowTsgMtF.ERY = 0; //???
        valuesToLowTsgMtF.HB = 19.9; //g/dl
        valuesToLowTsgMtF.HBE = 1;
        valuesToLowTsgMtF.HK = 0; // ???
        valuesToLowTsgMtF.LEUK = 50000; //μl
        valuesToLowTsgMtF.MCHC = 31;
        valuesToLowTsgMtF.MCV = 80; //fl
        valuesToLowTsgMtF.RDW = 0; //fl
        valuesToLowTsgMtF.THRO = 0; //???????????

        Values valuesToHighTsgMtF = new(); //ng/ml
        valuesToHighTsgMtF.TSH = 4.1;
        valuesToHighTsgMtF.FT3 = 7.3;
        valuesToHighTsgMtF.FT4 = 1.95;
        valuesToHighTsgMtF.TAK = 100;
        valuesToHighTsgMtF.TRAK = 1.76; //Eig. Pronzent
        valuesToHighTsgMtF.Prolaktin = 23.2;
        valuesToHighTsgMtF.LH = 0.5; //Testoproduktion
        valuesToHighTsgMtF.FSH = 0.5;
        valuesToHighTsgMtF.Estradiol = 201;
        valuesToHighTsgMtF.Testosteron = 0.61;
        valuesToHighTsgMtF.SHBG = 145; //nmol/l
        valuesToHighTsgMtF.FAI = 7.3;
        valuesToHighTsgMtF.Progesteron = 11;
        valuesToHighTsgMtF.Androstendion = 2.30; //µg/l
        valuesToHighTsgMtF.DTES17OH = 71; //ng/dl
        valuesToHighTsgMtF.AndroGluc = 4.65;
        valuesToHighTsgMtF.ACTH = 61; //Von 7-10 Uhr
        valuesToHighTsgMtF.Cortisol = 26; //µg/dL
        valuesToHighTsgMtF.DHEAS = 431; //µg/dl
        valuesToHighTsgMtF.STH = 9;
        valuesToHighTsgMtF.IGF1 = 393; //22 - 24 Jahre ng/ml
        valuesToHighTsgMtF.CPeptid = 4.1;
        valuesToHighTsgMtF.HbA1c = 19.5; //Nanogramm pro mililieter
        valuesToHighTsgMtF.BZppRgbg = 0; //?????????
        valuesToHighTsgMtF.PTH = 66.1;
        valuesToHighTsgMtF.CRP = 0.5; //ml/dl
        valuesToHighTsgMtF.CALS = 2.55; //mmol
        valuesToHighTsgMtF.CKDM1 = 0; //??????????
        valuesToHighTsgMtF.KREA = 1.10;
        valuesToHighTsgMtF.GOT = 36;
        valuesToHighTsgMtF.GPT = 36;
        valuesToHighTsgMtF.GGT = 40;
        valuesToHighTsgMtF.PHOS = 1.46;
        valuesToHighTsgMtF.ERY = 0; //???
        valuesToHighTsgMtF.HB = 15.6; //g/dl
        valuesToHighTsgMtF.HBE = 1;
        valuesToHighTsgMtF.HK = 0; // ???
        valuesToHighTsgMtF.LEUK = 100000; //μl
        valuesToHighTsgMtF.MCHC = 36;
        valuesToHighTsgMtF.MCV = 96; //fl
        valuesToHighTsgMtF.RDW = 98; //fl
        valuesToHighTsgMtF.THRO = 0; //??????????

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
        testValueSave.AndroGluc = 666; //Androstandion-Glucuronid
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
        JsonToFile(testValueSave, "testHormoneValue1.json");
    }
    public static void JsonToFile(object Object, string path) //Converts into a file
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true; //made pretty printing on
        string json = JsonSerializer.Serialize(Object, typeof(Object), options);
        File.WriteAllText(path, json); // Path: C:\Users\Xenmi\Desktop\Software\C# Json\Json\Json\bin\Debug\net6.0
    }
}