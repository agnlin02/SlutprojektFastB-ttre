using System;
using System.Collections.Generic;

namespace Store
{
    public class Food : Item
    {
        //    Store store = new Store();
        public Dictionary<string, double> foodPrice = new Dictionary<string, double>(); //Skapat en dictionery som innehåller bpde priset och namnet på föremålet som kan köpas.
        public Food(string name, string description) : base(name, description)
        {

        } //En konstruktor som ärver från basklassen weapon (se mer i weapon)

        public string Name { get => name; set => name = value; } // En property för inkapslingen (se mer i Sword)
        public string Description { get => description; set => description = value; }

        // public override void DisplayInformation()
        // {
        //     // Wow much information 
        //     System.Console.WriteLine(name);
        //     System.Console.WriteLine("DESCRIPTION OF FOOD");
        //     System.Console.WriteLine("PRICE OF FOOD");
        //     System.Console.WriteLine("ANDRA MATIGA GREJER");
        //     // Such information much wow
        // }
        public override void AddPrice(int firstPrice, Queue<double> discount) //samma som i sword.
        {

            if (discount.Contains(1))
            {
                double price = firstPrice * discount.Peek();
                discount.Dequeue();
                foodPrice.Add(name, price);
            }
            else
            {
                double price = firstPrice;
                foodPrice.Add(name, price);
            }

        }
    }
}
