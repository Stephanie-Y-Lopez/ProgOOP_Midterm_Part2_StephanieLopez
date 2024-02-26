using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_StephanieLopez
{
    public abstract class Animal
    {
        //Default fields for all animals 
        public string _name { get; set; }
        public string _area { get; set; }
        public double _age { get; set; }

        //Constructor
        protected Animal(string Name, string Area, double Age)
        {
            _name = Name;
            _area = Area;
            _age = Age;
        }
        //I chose to do age because that is the only idea I could think about to incorporate numbers into the default category because I wanted to include numbers in an idea that wouldn't seem crazy.

        public virtual void DisplayAnimalInfo()
        {
            Console.WriteLine("Animal Information:");
            Console.WriteLine($"Animal: {_name}");
            Console.WriteLine($"Living Region: {_area}");
            Console.WriteLine($"Current Age: {_age}");
        }
    }
}
