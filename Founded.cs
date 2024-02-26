using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgOOP_Midterm_Part2_StephanieLopez
{
    public class Founded : Animal
    {
        public string _foundedin { get; set; }

        public Founded(string Name, string Area, double Age, string Foundedin) : base(Name, Area, Age)
        {
            _foundedin = Foundedin;
        }

        public override void DisplayAnimalInfo()
        {
            Console.WriteLine($"Animal: {_name}, Living Region: {_area}, Age: {_age}, Founded in: {_foundedin}");
        }
    }
}
