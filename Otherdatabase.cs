using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_StephanieLopez
{
    public static class Otherdatabase
    {
        private static List<Animal> data;

        static Otherdatabase()
        {
            Founded hammerheadshark = new Founded("Hammer Head Shark", "Tropical Waters", 8, "1837");
            Aquatic blobfish = new Aquatic("Blob Fish", "Deep sea", 10, "yes");
            Terrestrial cow = new Terrestrial("Highland Cow", "Scottish Highlands", 5, "yes");
                    
            data = new List<Animal>();

            data.Add(hammerheadshark);
            data.Add(blobfish);
            data.Add(cow);

        }

        public static List<Animal> Data
        {
            get { return data; }
        }
    }   //This is more sample code for me to keep track of what format should look like.
}
