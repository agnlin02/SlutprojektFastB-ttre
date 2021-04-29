using System;
using System.Collections;
using System.Linq;
using System.Threading;

namespace Store
{
    public abstract class Item //En abstract klass som bara låter andra klasser ärva från den. Den kan altså inte displaya
    {
        protected string name; //En protceted string som bara kan användas i klasser som ärver
        protected string description;

        protected Item(string name, string description) //En konstruktor som tar emot två stycken parametrar. Den ena parametern tar emot namnet på maten, medan andra tar emot en description på den.  Detta gör det möjligt att lägga in namnet och description på ett nytt föremålet. 
        {
            this.name = name;
            this.description = description;
        }
        //public abstract void DisplayInformation();
        //public abstract void Buy();
    }

}