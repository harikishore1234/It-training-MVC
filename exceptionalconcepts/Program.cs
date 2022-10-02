using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionalconcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter rhe first input");
                int firstvalue=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the second input");
                int secondvalue=Convert.ToInt32(Console.ReadLine());
                int resultvalue = firstvalue / secondvalue;
                Console.WriteLine("result:" + resultvalue);
            }
            catch(ArithmeticException y)
            {
                Console.WriteLine(y.Message);
            }
            finally 
            {
                Console.WriteLine("free the resources");
            }
            Console.ReadLine();
        }
    }
}
