using System;
using System.Collections.Generic;

namespace Store
{
    public class Sword : Weapon
    {
        public Dictionary<string, int> weponPrice = new Dictionary<string, int>(); //Created a dictionary containing both the prices and the names of the items
        // Gör Sword som ärver från Weapon
        // Lägg till konstruktor
        // Lägg till properties
        // 
        public Sword(string name, string description) : base(name, description) {
            
        } // Constructor inheriting from base class (Item)

        public string Name { get => name; set => name = value; } //Property for encapsulation
        public string Description { get => description; set => description = value; }

        public override void displayInformation()
        {
            // Wow much information 
            System.Console.WriteLine(name);
            System.Console.WriteLine("DESCRIPTION OF SWORD");
            System.Console.WriteLine("PRICE OF SWORD");
            System.Console.WriteLine("OTHER SWORDY STUFF");
            // Such information much wow
        }

        public void AddPrice(int price)
        {
            weponPrice.Add(name, price);
        }
    }
}
