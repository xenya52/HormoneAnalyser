using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HormoneAnalyser
{
    public class Value
    {
        public string valueName { get; set; }
        public string valueDescription { get; set; }
        public string unit { get; set; }
        public double userValue { get; set; }
        public double valueToLow { get; set; }
        public double valueToHigh { get; set; }
        public Value(string valueName, string valueDescription, string unit, double userValue, double valueToLow, double valueToHigh)
        {
            this.valueName = valueName;
            this.valueDescription = valueDescription;
            this.unit = unit;
            this.userValue = userValue;
            this.valueToLow = valueToLow;
            this.valueToHigh = valueToHigh;
        }
    }
}
