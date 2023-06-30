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
        public void showAllOptionsPage(int input)
        {
            switch(input)
            {
                case 1:
                    creatingAValue(); 
                    break;
                case 2: editASpecificValue(); 
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
