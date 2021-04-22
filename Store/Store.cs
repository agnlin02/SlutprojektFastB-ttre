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
        int money = 20;
        List<Weapon> weapons = new List<Weapon>(); // All swords in the shelves
        List<Food> food = new List<Food>(); // All food in the shelves

        Dictionary<Item, int> itemPrices = new Dictionary<Item, int>(); // list for all items
        List<string> shelves = new List<string>() { "Food", "Weapons" }; // list for all items

        public void BeginGame() //  < alt + 60        > alt + 62         | alt + 124
        {
            Console.WriteLine("This is a store. Here you can buy food. On your 5th, 8th and 10th purchase you'll get a discount.");
            Console.WriteLine("These are the shelves you can choose between:");

            for (int i = 0; i < shelves.Count; i++)
            {
                System.Console.WriteLine((i + 1) + ". " + shelves[i]);
            }

            Console.WriteLine("Which shelf do you want to look at?");
            string svar = Console.ReadLine();


            if (svar.ToLower() == "food" || svar.ToLower() == "1")
            {
                Food tomato = new Food("Green Tomato", "This is a Tomato...but it is green"); //Skapar en ny instans av Food som heter tomato. Den anroppar konstruktorn Food i klassen Food, men den konstruktorn behöver ta in två parametrar. Dessa två parameterar är namnet, i det här fallet, green tomato, och en beskrivning.
                System.Console.WriteLine(tomato.Name + ": " + tomato.Description);
                  tomato.AddPrice(15); 
               
                System.Console.WriteLine("Price: " + tomato.foodPrice["Excalibur"]);
                // Call display information for every food item
                 System.Console.WriteLine("Do you want to buy?");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    money -= tomato.foodPrice["Green Tomato"]; //money must be on the right side of the equation...because not math
                    System.Console.WriteLine("You now have " + money + "$ left");
                }
                Console.ReadLine();

            }

            else if (svar.ToLower() == "weapons" || svar.ToLower() == "2")
            {
                Sword sword = new Sword("Excalibur", "This legendary sword from myth makes you the rightful ruler of Great Britain and all her provinces");
                sword.AddPrice(10);
                System.Console.WriteLine(sword.Name + ": " + sword.Description);
                System.Console.WriteLine("Price: " + sword.weponPrice["Excalibur"]);

                System.Console.WriteLine("Do you want to buy?");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    money -= sword.weponPrice["Excalibur"]; //money must be on the right side of the equation...because not math
                    System.Console.WriteLine("You now have " + money + "$ left");
                }
                Console.ReadLine();
                // Call display information for every sword

            }
        }

    }
}

// shift alt F