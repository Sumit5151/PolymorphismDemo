using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Arithmetic
    {
        public void Add()
        {
            Console.WriteLine("method with 0 arugument");
        }

        public void Add(int num1)
        {
            Console.WriteLine("Method with 1 parameter");
        }
        public void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition of two integer type values = " + result);
        }


        public void Add(float num1, float num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Addition of two Float type values = " + result);
        }
        public void Add(float num1, int num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Addition of one float and one interger type values = " + result);
        }
        public void Add(int num1, float num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Addition of one integer and one float type values = " + result);
        }


        public void sub(int num1, float num2, int num3)
        {
            Console.WriteLine();
        }

        public void sub(float num2, int num1, int num3)
        {

        }







        






    }
}
