using System;
using System.Collections.Generic;

namespace Store
{
    public abstract class Weapon : Item //En abstract klass (abstrat eftersom en det aldrig skapas en instans av den, utan bara ärvs ifrån) Den ärver också från Item.
    {
        // protected string sharpness; //Jag la aldrig till sharpness, men anledningen varför jag skapade en separat klass var för att kunna lägga till kod som var specefika för wepon.
        protected Weapon(string name, string description) : base(name, description)
        {
            this.name = name; // Den gör att namnet som läggs in i den skapade isnatnsen aw weapon i store bli samma som "name"
            this.description = description;
        } //skapas för att konstruktorn i subklassen sword ska kunna ärva från denna klass. 

    }
}
