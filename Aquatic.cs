using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_StephanieLopez
{
    public class Aquatic : Animal
    {
        public string _aqua { get; set; }

        public Aquatic(string Name, string Area, double Age, string Aqua) : base(Name, Area, Age)
        {
            _aqua = Aqua;
        }

        public override void DisplayAnimalInfo()
        {
            Console.WriteLine($"Animal: {_name}, Living Region: {_area}, Age: {_age}, Aquatic?: {_aqua}");
        }
    }
}
