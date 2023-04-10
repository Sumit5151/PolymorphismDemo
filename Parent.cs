using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Parent
    {
        //Method overloading
        public void Show()
        {
            Console.WriteLine("Parent class show method");
        }

        //Method overriding
        public virtual void Display()
        {
            Console.WriteLine("Parent class Display method");
        }


        public virtual void PutData()
        {
            Console.WriteLine("Parent class Pudtada method");
        }
    }
}
