using System;
using System.Collections.Generic;

namespace Store
{
    public abstract class Weapon {
        
        
        protected string name;
        protected string description;

        protected Weapon(string name, string description) {
            this.name = name;
            this.description = description;
        }
        public abstract void displayInformation();
    
    }
}
