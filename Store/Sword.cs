using System;
using System.Collections.Generic;

namespace Store
{
    public class Sword : Weapon
    {
        Store store = new Store();
        public Dictionary<string, double> weaponPrice = new Dictionary<string, double>(); //Skapat en dictionery som innehåller bpde priset och namnet på föremålet som kan köpas.

        public Sword(string name, string description) : base(name, description)
        {

        } // En konstruktor som ärver från basklassen weapon. Har även två parametrar: string och description. Dessa skrivs in när instansen av klassen skapas i Shop. Konstruktron heter densamma som klassen. Anroppas atomatiskt när insansen skapas.

        public string Name { get => name; set => name = value; } // En property för inkapslingen. Tar namnet som man skriver in och sätter det som värdet för properyn. Name = name och man bestämmer name i klassen Shop.
        public string Description { get => description; set => description = value; } // Samma som ovan

        // public override void displayInformation()
        // {
        //     // Wow much information 
        //     System.Console.WriteLine(name);
        //     System.Console.WriteLine(description);
        //     System.Console.WriteLine("PRICE OF SWORD");
        //     System.Console.WriteLine("OTHER SWORDY STUFF");
        //     // such information much wow
        // }


        public void AddPrice(double firstPrice, Queue<double> discount) //En metod som gör det möjligt för spelaren att köpa materialet. För att den ska kunna beräkna med discounten måste den ta in en parameter med queuen discount som föklaras i store.
        {
            if (discount.Contains(1)) // om discounten innehåller 1 kommer den räkna med discounet. Eftersom queuen innehåller 1 i slutet av kön kommer if satsen alltid vara sann så länge det finns något i queuen. När alla discounts är uppanvända kommer discountenn inte räknas med i priset. Detta i syfte att undvika det logiska felet att metoden räknar med en queueu som är tom.
            {
                double price = firstPrice * discount.Peek(); // Priset är standardpriset multiplicerat med queuen. Om nästa plats i queuen innehåller 0.8 kommer priset vara standardpriset * 20%
                discount.Dequeue(); // Tar bort den platsen i discount som kördes så att nästa plats i queuen körs.
                weaponPrice.Add(name, price); // lägger til priset i weaponprice.
            }
            else
            {
                double price = firstPrice; //Prist är standardpeiset som skickas in med en parameter
                weaponPrice.Add(name, price);
            }

        }
    }
}
