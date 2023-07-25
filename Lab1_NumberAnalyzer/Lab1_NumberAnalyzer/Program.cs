using System;

namespace odd_even
{

    class Program
    {
        static void Main(string[] args)
        {
            string yes;
            string no;

            string userName;
            Console.WriteLine("Hello user. What is your name?");
            userName = Console.ReadLine();

            int userNumber, remainder;

            Console.WriteLine($"Hello {userName}. Please enter a number between 1 - 100. \n");

            userNumber = Convert.ToInt32(Console.ReadLine());

            remainder = userNumber % 2;

            if (remainder == 0)
            {
                Console.WriteLine("{0} is Even number", userNumber);
            }
            if (userNumber < 60 && userNumber != 0)
            {
                Console.WriteLine(userNumber + " Odd and less than 60.");
            }
            if (userNumber > 1 && userNumber < 25 )
            {
                Console.WriteLine("Even and less than 25.");
            
            }
            if (userNumber > 1 && userNumber < 35 && userNumber % 2 == 0)              
            {
                Console.WriteLine("Even and less than 25.");
            }
            if (userNumber >= 26 && userNumber <= 60 && userNumber % 2 != 0)
            {
                Console.WriteLine("Even and between 26 and 60 inclusive");
            }
            if (userNumber >= 60 && userNumber == 0 )
            {
                Console.WriteLine(userNumber + "Even and greater than 60.");
            }

            if (userNumber >= 61 && userNumber == 0)
            {
                Console.WriteLine(userNumber + " Odd and greater than 60.");
            }
            else

                Console.WriteLine($" Excuse me : {userName} Would you like to stop?  ( yes/no ) \n");
            string answer;
            {
                string line = Console.ReadLine();
                if (line.Equals("yes") | line.Equals("no"))
                {
                    if (line == "yes") ;
                    answer = Console.ReadLine();

                }
                else      
                    Console.ReadKey();
            }

        }

    }
}

//if (i % 2 == 0)
//    if (userInput == 2 && userInput <= 24)
//    {
//        Console.WriteLine($"{userInput} The number is odd and less than 60");
//    }
//if (userInput == 2 && userInput < 25)
//{
//    Console.WriteLine($"{userInput}Even and less than 25");
//}
//if (userInput == 26 && userInput > 60)
//{
//    Console.WriteLine($"{userInput}Even and greater than 60");
//}
//if (userInput == 26 && 60)
