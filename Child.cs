using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Child:Parent
    {
        //Method overloading
        public void Show(int num1)
        {
            Console.WriteLine("Child class show method");
        }

        //Method Overriding
        public override void Display()
        {
            Console.WriteLine("Child class Display method");
        }



        public override void PutData()
        {
            Console.WriteLine("child class Pudtada method");
        }


    }
}
