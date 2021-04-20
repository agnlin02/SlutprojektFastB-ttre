using System.ComponentModel;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Store
{
    public class Store
    {

        

        //new Food("Apple", 150, "A granny smith apple"), new Sword("Excalibur", 149, "This legendary sword from myth makes you the rightful ruler of Great Britain and all her provinces.")
        List<Weapon> weapons = new List<Weapon>(); // All swords in the shelves
        List<Food> food = new List<Food>(); // All food in the shelves

        Dictionary<Item, int> itemPrices = new Dictionary<Item, int>(); // list for all items
        List<string> shelves = new List<string>() {"Food", "Weapons"}; // list for all items

        public void BeginGame() //  < alt + 60        > alt + 62         | alt + 124
        {
            Console.WriteLine("This is a store. Here you can buy food. On your 5th, 8th and 10th purchase you'll get a discount.");
            Console.WriteLine("These are the shelves you can choose between:");
        
            for (int i = 0; i < shelves.Count; i++)
            {
                System.Console.WriteLine((i+1) + ". " + shelves[i]);
            }

            Console.WriteLine("Which shelf do you want to look at?");
            string svar = Console.ReadLine();


            if (svar.ToLower() == "weapons" || svar.ToLower() == "1")
            {
                // Call display information for every sword

            }

            else if (svar.ToLower() == "food" || svar.ToLower() == "2")
            {
                // Call display information for every food item
            }
        }
    }
}

// shift alt F