using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //lists
            //similar to array. they are muteable which means changeable. data structure. data has to have a relationship and commonality
            //methods are used to manipulate 

            //List<string> FavFoods = new List<string>() { "Pizza", "Alfredo", "Chicken", "Sushi", "Broccoli" };
            //Console.WriteLine(FavFoods[0]);

            //List<string> LeastFavFoods = new List<string>();
            //LeastFavFoods[0] = "Onions";
            //LeastFavFoods[1] = "Mushrooms";
            //LeastFavFoods[2] = "Liver";
            //LeastFavFoods[3] = "Pig Feet";
            //LeastFavFoods.Add("Tootsie Rolls");

            //List<int> LuckyNumbers = new List<int>();
            //LuckyNumbers.Add(15);
            //LuckyNumbers.Add(07);
            //LuckyNumbers.Add(03);
            //LuckyNumbers.Add(23);

            List<string> favMovies = new List<string>() { "Training Day", "The Matrix", "Blade" };
            favMovies.Insert(0, "Inception");
            //for loop
            //for (int counter = 0; counter < favMovies.Count; counter++)
            //{
            //    Console.WriteLine(favMovies[counter]);
            //}
            //foreach loop
            //foreach (string film in favMovies)
            //{
            //    Console.WriteLine(film);
            //}

            //favMovies.Remove("Blade");
            //favMovies.Remove("The Matrix");

            //foreach (string movie in favMovies)
            //{
            //    Console.WriteLine(movie);
            //}

            //List<string> favAnimals = new List<string>();
            //favAnimals.Add("Lion");
            //favAnimals.Add("Eagle");
            //favAnimals.Add("Shark");
            //favAnimals.Add("Scorpion");
            //favAnimals.Add("Dragon");

            //foreach (string animal in favAnimals)
            //{
            //    Console.WriteLine(animal);
            //}

            //List<bool> trueOrFalse = new List<bool>() { true, false, false, true, false };
            //foreach (bool rain in trueOrFalse)
            //{
            //    if (rain == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella");
            //    }

            //    else
            //    {
            //        Console.WriteLine("No rain today, enjoy the sun!");
            //    }
            //    Console.WriteLine(rain);

            //List<int> numberList = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //Console.WriteLine(numberList.Contains(23));
            //Console.WriteLine(numberList.Contains(77));
            //Console.WriteLine(numberList.Contains(15));

            //numberList.Remove(77);
            //numberList.Remove(32);
            //numberList.Remove(6);

            //Console.WriteLine(numberList.Contains(23));
            //Console.WriteLine(numberList.Contains(77));
            //Console.WriteLine(numberList.Contains(15));
            //removeAt
            //Insert

            numberList.RemoveAt(0);
            for (int number = 0; number < numberList.Count; number++)
            {
                Console.WriteLine(numberList[number]);
            }
            numberList.Insert(0, 63);
            for (int number = 0; number < numberList.Count; number++)
            {
                Console.WriteLine(numberList[number]);
            }
                    

            }
        }
    }
    

