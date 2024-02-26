using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgOOP_Midterm_Part2_StephanieLopez
{
    internal class AnimalDatabase
    {
        List<Animal> amimaldata = new List<Animal>();

        static AnimalDatabase _animalDatabase = null;

        private void AllData()
        {
            {
                amimaldata = new List<Animal>
                {
                    new Founded("Lion", "Africa", 8, "1760"),
                    new Aquatic("Dolphin", "Pacific Ocean", 18, "yes"),
                    new Terrestrial("Rabbit", "North America", 5, "yes"),
                    new Founded("Elephant", "Africa", 25, "1637"),
                    new Terrestrial("Fox", "North America", 8, "yes"),
                    new Founded("Giraffe", "Africa", 12, "1779"),
                    new Founded("Kangaroo", "Australia", 15, "1770"),
                    new Aquatic("Shark", "Atlantic Ocean", 25, "yes"),
                    new Terrestrial("Deer", "North America", 10, "yes"),
                    new Founded("Tiger", "Asia", 10, "1758"),
                    new Aquatic("Whale", "Atlantic Ocean", 30, "yes"),
                    new Terrestrial("Bear", "North America", 12, "yes"),
                    new Founded("Polar Bear", "Arctic", 20, "1758"),
                    new Terrestrial("Wolverine", "North America", 7, "yes"),
                    new Founded("Grizzly Bear", "North America", 18, "1800"),
                    new Aquatic("Seal", "Arctic Ocean", 12, "yes"),
                    new Founded("Hippopotamus", "Africa", 30, "1758"),
                    new Terrestrial("Moose", "North America", 15, "yes"),
                    new Founded("Leopard", "Africa", 14, "1758"),
                    new Founded("Gorilla", "Africa", 35, "1760"),
                    new Terrestrial("Bobcat", "North America", 9, "yes"),
                    new Aquatic("Walrus", "Arctic Ocean", 20, "yes"),
                    new Founded("Zebra", "Africa", 25, "1766"),
                    new Aquatic("Penguin", "Antarctica", 15, "yes"),
                    new Terrestrial("Raccoon", "North America", 6, "yes"),
                    new Founded("Panda", "China", 15, "1869"),
                    new Founded("Rhinoceros", "Africa", 20, "1758"),
                    new Terrestrial("Coyote", "North America", 10, "yes"),
                    new Founded("Cheetah", "Africa", 12, "1758"),
                    new Aquatic("Turtle", "Indian Ocean", 40, "yes"),
                    new Founded("Wolf", "Europe", 10, "1758"),
                    new Aquatic("Octopus", "Atlantic Ocean", 3, "yes"),
                    new Terrestrial("Squirrel", "North America", 3, "yes"),
                    new Founded("Horse", "Europe", 20, "1766"),
                    new Aquatic("Crab", "Pacific Ocean", 5, "yes"),
                    new Terrestrial("Skunk", "North America", 5, "yes"),
                    new Founded("Bison", "North America", 25, "1758"),
                    new Aquatic("Lobster", "Atlantic Ocean", 7, "yes"),
                    new Founded("Coyote", "North America", 15, "1758"),
                    new Terrestrial("Chipmunk", "North America", 2, "yes"),
                    new Aquatic("Squid", "Pacific Ocean", 2, "yes"),
                    new Founded("Lynx", "Europe", 10, "1758"),
                    new Aquatic("Starfish", "Atlantic Ocean", 8, "yes"),
                    new Founded("Puma", "North America", 18, "1758"),
                    new Aquatic("Jellyfish", "Pacific Ocean", 1, "yes"),
                    new Terrestrial("Opossum", "North America", 4, "yes"),
                    new Founded("Horse", "Europe", 20, "1766"),
                    new Aquatic("Sea Otter", "Pacific Ocean", 10, "yes"),
                    new Founded("Bison", "North America", 25, "1758"),
                    new Terrestrial("Groundhog", "North America", 7, "yes"),
                    new Aquatic("Manatee", "Atlantic Ocean", 18, "yes"),
                    new Founded("Lynx", "Europe", 10, "1758"),
                    new Terrestrial("Badger", "North America", 8, "yes"),
                    new Aquatic("Eel", "Atlantic Ocean", 6, "yes"),
                    new Founded("Puma", "North America", 18, "1758"),
                    new Terrestrial("Porcupine", "North America", 6, "yes"),
                    new Aquatic("Seahorse", "Indian Ocean", 4, "yes"),
                    new Founded("Lion", "Africa", 8, "1760"),
                    new Aquatic("Stingray", "Pacific Ocean", 7, "yes"),
                    new Terrestrial("Cottontail", "North America", 3, "yes"),
                    new Founded("Elephant", "Africa", 25, "1637"),
                    new Terrestrial("Marmot", "North America", 10, "yes"),
                    new Aquatic("Angelfish", "Atlantic Ocean", 3, "yes")
                };
            }
        }

        public List<Animal> Data()
        {
            return amimaldata;
        }
    }
}
