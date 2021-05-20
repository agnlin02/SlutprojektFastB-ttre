using System.ComponentModel;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Store
{
    public class Store
    {
        double money = 100;
        //  List<Weapon> weapons = new List<Weapon>(); // All swords in the shelves
        //  List<Food> food = new List<Food>(); // All food in the shelves, 

        List<string> shelves = new List<string>() { "Food", "Weapons" }; // list för alla items

        Queue<double> discount = new Queue<double>();
        Player player = new Player();

        public void Discound() // En metod som gör att man kan få rea efter ett specefikt antal köp.
        {

            for (int i = 0; i < 2; i++) //metoden körs 2 gånger och stoppar då in "1" två gånger i queueu:en discount. Anledningen till att den är 1 är eftersom priset blir densamma när det multipliceras med 1. Det är altså ingen rea på de första två köpen.
            {
                discount.Enqueue(1);
            }
            discount.Enqueue(0.8); // På den tredje platsen i queuen läggs 0,8 in. Detta är för att det ska mulipliceras med priset och på så sätt skapa det nya priset. Det blir på så sätt en 20% minkning på grundpriset. 
            for (int i = 0; i < 2; i++) //Likt ovan forsättet detta fram till det 10onde köpet
            {
                discount.Enqueue(1);
            }
            discount.Enqueue(0.5);

            for (int i = 0; i < 3; i++)
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
                Console.WriteLine("This is a store. Here you can buy food. On your 3rd, 6th and 10th purchase you'll get a discount.");

                System.Console.WriteLine("Money: " + money);
                System.Console.WriteLine("Inventory: "); player.InventoryItems();
                System.Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
                Console.WriteLine("These are the shelves you can choose between:");
                for (int i = 0; i < shelves.Count; i++)
                {
                    System.Console.WriteLine((i + 1) + ". " + shelves[i]);
                }

                Console.WriteLine("Which shelf do you want to look at?");
                string svar = Console.ReadLine();

                while (svar.ToLower() != "1" && svar.ToLower() != "2" && svar.ToLower() != "food" && svar.ToLower() != "weapons")
                {
                    System.Console.WriteLine("You have to answer either 1 or 2");
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



                svar = Console.ReadLine();

                while (svar.ToLower() != "y" && svar.ToLower() != "n")
                {
                    Console.WriteLine("You have to answer either y or n");
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

        private void BuyFood()//En metod för att köpa vapnet. I en separat metod för att det inte ska vara för mycket kod i store metoden
        {
            Food tomato = new Food("Green Tomato", "This is a Tomato...but it is green"); //Skapar en ny instans av Food som heter tomato. Den anroppar konstruktorn Food i klassen Food, men den konstruktorn behöver ta in två parametrar. Dessa två parameterar är namnet, i det här fallet, green tomato, och en beskrivning.
            System.Console.WriteLine(tomato.Name + ": " + tomato.Description); //Skriver ut både namnet och description av instansen som skapades. I det här fallet green tomato. Hämtar namnet från propertin av inkapslingen i arvet Food (get => name, set =>name). 
            tomato.AddPrice(15, discount); //Jag anroppar metoden addPrice som at in två parametrar, en för föremålets pris och en för queue som jag skapat.

            System.Console.WriteLine("Price: " + tomato.foodPrice["Green Tomato"]); //Skriv ut det priset i dictionaty foodprice.


            System.Console.WriteLine("Do you want to buy? [y/n]");
            string answer = Console.ReadLine();
            while (answer.ToLower() != "y" && answer.ToLower() != "n") //Säkerställer så att användaren inte är dum eller elak eller bådeock.
            {
                System.Console.WriteLine("You have to answer etheir y or n");
                answer = Console.ReadLine();
            }
            if (answer.ToLower() == "y")
            {
                money -= tomato.foodPrice["Green Tomato"]; //money must be on the right side of the equation...because not math
                System.Console.WriteLine("You now have " + money + "$ left");
                player.inventory.Add(tomato); //Två instanser som reagerar med varandra
                System.Console.WriteLine("Do you want to buy something else? [y/n]");

            }
            else if (answer.ToLower() == "n")
            {
                System.Console.WriteLine("Alright, do you want to continue shopping? [y/n]");
            }

        }

        private void BuyWeapon() //En metod för att köpa vapnet. I en separat metod för att det inte ska vara för mycket kod i store metoden
        {

            Sword sword = new Sword("Excalibur", "This legendary sword from myth makes you the rightful ruler of Great Britain and all her provinces"); //Samma som i buyFood method
            sword.AddPrice(10, discount);
            System.Console.WriteLine(sword.Name + ": " + sword.Description);
            System.Console.WriteLine("Price: " + sword.weaponPrice["Excalibur"]);

            System.Console.WriteLine("Do you want to buy? [y/n]");
            string answer = Console.ReadLine();
            while (answer.ToLower() != "y" && answer.ToLower() != "n")
            {
                System.Console.WriteLine("You have to answer etheir y or n");
                answer = Console.ReadLine();
            }
            if (answer.ToLower() == "y")
            {
                money -= sword.weaponPrice["Excalibur"]; //money must be on the right side of the equation...because not math
                System.Console.WriteLine("You now have " + money + "$ left");
                player.inventory.Add(sword); //två instanser som interagerar med varandra. Sword som finns i klassen sword läggs till i inventoryt som finns i klassen player.
                System.Console.WriteLine("Do you want to buy something else? [y/n]");

            }
            else if (answer.ToLower() == "n")
            {
                System.Console.WriteLine("Alright, do you want to continue shopping?[y/n]");
            }


        }

        // private void Buy(Dictionary<string, int> prices, Item origItem)
        // {

        //     //Sword sword = new Sword("Excalibur", "This legendary sword from myth makes you the rightful ruler of Great Britain and all her provinces");
        //     //sword.AddPrice(10, discount);


        //     if (origItem is Sword) //control shift Z så att man får tillbaka det man tog bort med ctrl + z
        //     {
        //         Sword sword = (origItem as Sword);
        //     }

        //     else if (origItem is Food)
        //     {
        //         Food food = (origItem as Food);
        //     }


        //     origItem.displayInformation();

        //     //System.Console.WriteLine(sword.Name + ": " + sword.Description);

        //     System.Console.WriteLine("Price: " + prices[origItem.Name]);

        //     System.Console.WriteLine("Do you want to buy " + sword.Name + "? [y/n]");
        //     string answer = Console.ReadLine();
        //     if (answer.ToLower() == "y")
        //     {


        //         money -= sword.weaponPrice["Excalibur"]; //money must be on the left side of the equation...because not math
        //         System.Console.WriteLine("You now have $" + money + " left");
        //     }
        //     Console.ReadLine();

        //     // Call display information for every Asword
        // } //A nother (smarter) way of writing. Sense this method is mutch alike the "buyFood" method can this method
        //inhariete from the method above. However it was Sebbe who showed me this and I am not sure how it works, so
        //I'll write my code as it is now and look thorugh this later on.
    }
}

// shift alt F