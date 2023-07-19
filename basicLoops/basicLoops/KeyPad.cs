using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6_22_loops
{
    class Program
    {

        //Lab Loops part 3
        public static void Main(string[] args)
        {


            int inputNumber;
            int correctPassword = 13579;

            for (int i = 1; i <= 5; i++)
            {

                Console.Write("Enter Guess {0}:", i);

                inputNumber = Convert.ToInt32(Console.ReadLine());
                if (i >= 5)
                {

                    if (inputNumber != correctPassword)
                    {
                        Console.WriteLine("Password Invalid!");
                    }
                    Console.WriteLine(".....Access Denied.....");
                }
                else
                {
                    if (inputNumber == correctPassword)
                    {

                        Console.WriteLine("Welcome! The corresponding number" + correctPassword + "is correct");
                        break;

                    }



                    //part1 of keypad description add 5 attempts
                }








                //part2 of keypad description do while loop

                Console.WriteLine("Please Enter Password: ");

                int numberInput1 = Convert.ToInt32(Console.ReadLine());
                int correctPassword1 = 13579;

                do
                {
                    Console.WriteLine("Password Invalid!");
                }
                while (inputNumber == correctPassword);
                {
                    Console.WriteLine("Welcome!");
                }




            }

        }
    }
}//continue