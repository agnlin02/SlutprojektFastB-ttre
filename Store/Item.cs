using System;
using System.Collections;
using System.Linq;
using System.Threading;

namespace Store {
    public abstract class Item {
        protected string name;
        protected string description;

        protected Item(string name, string description) {
            this.name = name;
            this.description = description;
        }
        public abstract void displayInformation();
    }
}