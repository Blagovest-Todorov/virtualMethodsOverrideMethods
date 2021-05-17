using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Dog : Animal
    {
        public void Bark() 
        {
            Console.WriteLine("barking…");
            
        }

        public override void Eat() //here the virtual method can be overriden, rewritten, to do else
        {
            Console.WriteLine("i am eating very slowly");
        }
    }
}
