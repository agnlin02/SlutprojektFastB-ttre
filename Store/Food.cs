using System;
using System.Collections.Generic;

namespace Store
{
    public class Food : Item
    {
        public Dictionary<string, int> foodPrice = new Dictionary<string, int>(); //Created a dictionary containing both the prices and the names of the items
        public Food(string name, string description) : base(name, description) {
            
        } // Constructor inheriting from base class (Item)

        public string Name { get => name; set => name = value; } //Property for encapsulation
        public string Description { get => description; set => description = value; }

        public override void displayInformation()
        {
            // Wow much information 
            System.Console.WriteLine(name);
            System.Console.WriteLine("DESCRIPTION OF FOOD");
            System.Console.WriteLine("PRICE OF FOOD");
            System.Console.WriteLine("ANDRA MATIGA GREJER");
            System.Console.WriteLine("DU KAN ÄVEN SKRIVA DET HÄR MER FINT ÄN VAD JAG GJORT HÄR");
            // Such information much wow
        }
         public void AddPrice(int price)
        {
            foodPrice.Add(name, price);
        }
    }
}
