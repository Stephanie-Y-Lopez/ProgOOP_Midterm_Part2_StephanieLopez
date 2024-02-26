using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_StephanieLopez
{
    public class Terrestrial : Animal
    {
        public string _land { get; set; }

        public Terrestrial(string Name, string Area, double Age, string Land) : base(Name, Area, Age)
        {
            _land = Land;
        }

        public override void DisplayAnimalInfo()
        {
            Console.WriteLine($"Animal: {_name}, Living Region: {_area}, Age: {_age}, Terrestrial?: {_land}");
        }
    }
}
