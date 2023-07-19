using System;


namespace forLoops
{

    class Program
    {

        static void Main(string[] args)
        {

            bool theyWantToContinue = true;


            while (theyWantToContinue)
            {

                Console.WriteLine("Hello World! ");
                Console.WriteLine("Would you like to continue?. y / n");

                

                if (Console.ReadLine().Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    
                    
                    Console.WriteLine("Good Bye!");
                }

            }
        }










    }

}
//int num, sum = 0;
//num = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i < num; i++)
//{
//    sum += num;
//}


//onsole.WriteLine(sum);


//if (num % 10 != 0)
//{
//    Console.WriteLine("      ");
//    Console.WriteLine("\n Continue...");

//}
//var keyInfo = Console.ReadKey();
//keyInfo.KeyChar.ToString();


//for (int i = 1; i < 10; i++)
//{
//    int num, sum = 0;
//    Console.WriteLine(" >> Enter a number: ");
//    num = Convert.ToInt32(Console.ReadLine());

//    while (num != 0)
//    {

//        sum += num % 10;
//        num = num / 10;