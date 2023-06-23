using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HormoneAnalyser
{
    public class Category
    {
        public string name { get; set; }
        public string description { get; set; }

        public Value (string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}