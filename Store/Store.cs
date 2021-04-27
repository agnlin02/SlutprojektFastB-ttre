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
        double money = 100;
        List<Weapon> weapons = new List<Weapon>(); // All swords in the shelves
        List<Food> food = new List<Food>(); // All food in the shelves

        Dictionary<Item, int> itemPrices = new Dictionary<Item, int>(); // list for all items
        List<string> shelves = new List<string>() { "Food", "Weapons" }; // list for all items

        Queue<double> discount = new Queue<double>();
        public void Discound()
        {

            for (int i = 0; i < 2; i++)
            {
                discount.Enqueue(1);
            }
            discount.Enqueue(0.8);
            for (int i = 0; i < 2; i++)
            {
                discount.Enqueue(1);
            }
            discount.Enqueue(0.5);

            for (int i = 0; i < 4; i++)
            {
                discount.Enqueue(1);
            }
            discount.Enqueue(0.2);
            discount.Enqueue(1);

        }


        public void BeginGame() //  < alt + 60        > alt + 62         | alt + 124
        {
            Discound();


            while (money > 1)
            {
                Console.WriteLine("This is a store. Here you can buy food. On your 2ond, 5th and 10th purchase you'll get a discount.");

                System.Console.WriteLine("Your current money: " + money);
                Console.ReadLine();
                Console.WriteLine("These are the shelves you can choose between:");
                for (int i = 0; i < shelves.Count; i++)
                {
                    System.Console.WriteLine((i + 1) + ". " + shelves[i]);
                }

                Console.WriteLine("Which shelf do you want to look at?");
                string svar = Console.ReadLine();

                while (svar.ToLower() != "1" && svar.ToLower() != "2")
                {
                    System.Console.WriteLine("You have to answer ether 1 or 2");
                    svar = Console.ReadLine();
                }
                if (svar.ToLower() == "food" || svar.ToLower() == "1")
                {
                    BuyFood();
                }

                else if (svar.ToLower() == "weapons" || svar.ToLower() == "2")
                {
                    BuyWeapon();
                }


                System.Console.WriteLine("Do you want to buy something else?");
                svar = Console.ReadLine();

                while (svar.ToLower() != "y" && svar.ToLower() != "n")
                {
                    Console.WriteLine("You got to answer y/n");
                    svar = Console.ReadLine();

                }

                if (svar.ToLower() == "n")
                {
                    System.Console.WriteLine("Alright. Bye!");
                    break;
                }
                Console.Clear();


            }

            if (money < 1)
            {
                System.Console.WriteLine(@"You had to little money, so you got kicked out of the shop. Sorry ¯\_(ツ)_/¯");
            }

            Console.ReadLine();


        }

        private void BuyFood()
        {
            Food tomato = new Food("Green Tomato", "This is a Tomato...but it is green"); //Skapar en ny instans av Food som heter tomato. Den anroppar konstruktorn Food i klassen Food, men den konstruktorn behöver ta in två parametrar. Dessa två parameterar är namnet, i det här fallet, green tomato, och en beskrivning.
            System.Console.WriteLine(tomato.Name + ": " + tomato.Description);
            tomato.AddPrice(15, discount);

            System.Console.WriteLine("Price: " + tomato.foodPrice["Green Tomato"]);
            // Call display information for every food item
            System.Console.WriteLine("Do you want to buy? [y/n]");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                money -= tomato.foodPrice["Green Tomato"]; //money must be on the right side of the equation...because not math
                System.Console.WriteLine("You now have " + money + "$ left");
            }
            Console.ReadLine();

        }

        private void BuyWeapon()
        {

            Sword sword = new Sword("Excalibur", "This legendary sword from myth makes you the rightful ruler of Great Britain and all her provinces");
            sword.AddPrice(10, discount);
            System.Console.WriteLine(sword.Name + ": " + sword.Description);
            System.Console.WriteLine("Price: " + sword.weaponPrice["Excalibur"]);

            System.Console.WriteLine("Do you want to buy?");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                money -= sword.weaponPrice["Excalibur"]; //money must be on the right side of the equation...because not math
                System.Console.WriteLine("You now have " + money + "$ left");
            }
            Console.ReadLine();
            // Call display information for every sword

        }




    }
}

// shift alt F