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
                    Console.WriteLine(">Form what value number do you want to make you change?");
                    int numberWhatIWantToChange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(">What value do you want to edit?");
                    int valueWhatIWantToChange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(">What is the new value?");
                    char theNewValue = Convert.ToChar(Console.ReadLine());
                    editASpecificValue(numberWhatIWantToChange,valueWhatIWantToChange,theNewValue); 
                    break;
                case 3:
                    ShowAllValue();
                    Console.WriteLine(">Write in the value number what you want to delete");
                    int deleteValue = Convert.ToInt32(Console.ReadLine());
                    deleteAValue(deleteValue); 
                    break;
                case 4:
                    Console.WriteLine(">Write the first valueNumber what you want to swap");
                    int valueNumberA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(">Now write the second valueNumber");
                    int valueNumberB = Convert.ToInt32(Console.ReadLine());
                    swapValues(valueNumberA,valueNumberB); 
                    break;
                case 5:
                    Console.WriteLine(">Type in the valueNumber, what you want to see");
                    int valueNumber = Convert.ToInt32(Console.ReadLine());
                    ShowSpecificValue(valueNumber);
                    break;
                case 6:
                    int siteInput = 0;
                    while (Console.ReadKey().Key != ConsoleKey.Enter) 
                    {
                        ShowSiteOfValue(siteInput);
                        Console.WriteLine("[<-] Backwards    Forward [->]");

                        Console.WriteLine("Write a specific siteNumber and press <Enter> to search");
                        Console.WriteLine("Press only <Enter> to quit");
                    }
                    break;
                case 7: ShowAllValue();
                    break;
            }
        }
    }
}
