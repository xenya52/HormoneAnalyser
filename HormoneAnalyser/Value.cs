﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HormoneAnalyser
{
    internal class Value
    {
        public string valueName { get; set; }
        public string valueDescription { get; set; }
        public double userValue { get; set; }
        public double valueToLow { get; set; }
        public double valueToHigh { get; set; }
        public Value(string valueName, string valueDescription, double userValue, double valueToLow, double valueToHigh)
        {
            this.valueName = valueName;
            this.valueDescription = valueDescription;
            this.userValue = userValue;
            this.valueToLow = valueToLow;
            this.valueToHigh = valueToHigh;
        }
    }
}