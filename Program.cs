using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1 og 2

            // Here we instantiate a new dictionary
            Dictionary<string, int> nameAge = new Dictionary<string, int>();

            // We add a key represented by a string, and afterwards a value represented by a int
            nameAge.Add("Mikkel", 28);

            // We add another key and value, but this time we let the dictionary check
            // if a key with the given name already exists, if it doesn't, it adds it 
            // to the dictionary, if it already exists, it changes the value associated
            // with the key
            nameAge["Hans"] = 53;
            nameAge["Kim"] = 42;
            nameAge["Bo"] = 69;

            // ElementAt(Current place in the index).Key writes the key string to our console
            // ElementAt().Value writes the value associated with that index spot
            Console.WriteLine(nameAge.ElementAt(0).Key + " " + nameAge.ElementAt(0).Value);


            // Opgave 3

            // Removes the key "Hans" and the value associated with that key
            nameAge.Remove("Hans");


            // Opgave 4

            // Loops through each element in the dictionary, and writes the key and value
            // to the console
            foreach (var pair in nameAge)
            {
                Console.WriteLine(pair);
            }
            Console.ReadLine();
        }
    }
}
