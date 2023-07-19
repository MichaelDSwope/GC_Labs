using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exercise6_22_loops
{
    class program
    {
        class Program
        {
            public static void Main(string[] args)
            {

                Console.WriteLine("Enter a number. : \n");

                int numberInput = Convert.ToInt32(Console.ReadLine());




                var i = 0;
                int strartingNum;
                while (numberInput <= 5)
                {
                    Console.Write(++i);
                    i++;



                }
                Console.ReadLine();


            }
        }
    }
}