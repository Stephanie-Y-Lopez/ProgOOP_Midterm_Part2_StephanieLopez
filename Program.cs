using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgOOP_Midterm_Part2_StephanieLopez
{
    internal class Program
    {
        //Stephanie Lopez!
        static void Main(string[] args)
        {

            List<Animal> dataList = Otherdatabase.Data;

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Display All Animals");
                Console.WriteLine("2. Display Animals with known found date");
                Console.WriteLine("3. Display Terrestrial Animals");
                Console.WriteLine("4. Display Aquatic Animals");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayAllAnimals(dataList);
                        break;
                    case 2:
                        DisplayFounded(dataList);
                        break;
                    case 3:
                        Displayland(dataList);
                        break;
                    case 4:
                        Displaywater(dataList);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please reopen application.");
                        break;
                }
            }
        }
        static void DisplayAllAnimals(List<Animal> data)
        {
            foreach (Animal animal__ in data)
            {
                animal__.DisplayAnimalInfo();
            }
        }

        static void DisplayFounded(List<Animal> data)
        {
            foreach (Animal animal__ in data)
            {
                if (animal__.GetType() == typeof(Founded))
                {
                    animal__.DisplayAnimalInfo();
                }
            }

        }

        static void Displayland(List<Animal> data)
        {
            foreach (Animal animal__ in data)
            {
                if (animal__.GetType() == typeof(Terrestrial))
                {
                    animal__.DisplayAnimalInfo();
                }
            }
        }

        static void Displaywater(List<Animal> data)
        {
            foreach (Animal animal__ in data)
            {
                if (animal__.GetType() == typeof(Aquatic))
                {
                    animal__.DisplayAnimalInfo();
                }
            }
        }
    }
}
