using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Animal
    {
        public virtual void Eat()   //We declare teh method with keyword virtual, then we can override it
        {
            Console.WriteLine("eating…");
        }
    }
}
