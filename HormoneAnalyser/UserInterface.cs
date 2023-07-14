using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HormoneAnalyser
{
    internal class UserInterface : hormonAnalyser
    {
        public void showAllOptionsPage1(int input)
        {
            switch(input)
            {
                case 1:
                    Console.WriteLine(">Type the valueName");
                    string valueName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine(">Type the valueDescription");
                    string valueDescription = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Type in, the unit from the value");
                    string valueUnit = Convert.ToString(Console.ReadLine());
                    Console.WriteLine(">Type you value");
                    double youValue = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(">Type the highest value that is ok");
                    double highestValue = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(">Type the lowest value that is ok");
                    double lowestValue = Convert.ToDouble(Console.ReadLine());
                    creatingAValue(valueName,valueDescription,valueUnit,youValue,lowestValue,highestValue); 
                    break;
                case 2:
                    Console.WriteLine("Form what value number do you want to make you change?");
                    Console.WriteLine("What value do you want to edit?");
                    Console.WriteLine("What is the new value?");
                    editASpecificValue(); 
                    break;
                case 3: deleteAValue(); 
                    break;
                case 4: swapValues(); 
                    break;
                case 5: ShowSpecificValue();
                    break;
                case 6: ShowSpecificValue();
                    break;
                case 7: ShowSiteOfValue();
                    break;
                case 8: ShowAllValue();
                    break;
            }
        }
    }
}
