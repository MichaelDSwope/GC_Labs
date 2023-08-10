using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment2
{



    class program

    //method named CreateStringArray()... takes 3 strings as parameters..method should make new string[] ..next method should add
    //each string into ist own spot in the string[] and finally return the string[].


    static void CreateStringArray()
    {
        string[] strings = new string[] { "1", "2", "3" };


        List<int> numList = new List<int>();
        return numList.Add(1);
        return numList.Add(2);
        return numList.Add(3);



        //create static method named SumArray(int[]). method should add all the values in array together and return the sum
        static string SumArray(int[] )
        {

            int[] arr = new int[] { 1, 2, 3 };
            int sum = arr.Sum();
            Console.WriteLine(sum);
        }
        // create the static method named RemoveNum(int List, int num)..check list Contains number parameter passed into method. if so remove
        //In this example, the RemoveNum method takes a List<int> named list and an integer named num as parameters.


        static void RemoveNum(List<int> list, int num)
        {
            if (list.Contains(num))
            {
                list.Remove(num);
            }
            //by removing a specific number from the list and then printing the updated list.
            Console.WriteLine(list);
        }
    }
    
    
    

    //Value from the List passed in return void
    //return (void);

        List<string> AddToList = new List<string>();
        AddToList.Add("grapes");
        AddToList.Add("oranges");
        AddToList.Add("cherries");
        //create static method AddToList() takes in a string into parameter. method should add the strings grapes,oranges,and string
        //parameter to a list of strings  example cherries passed on to parameters.. method will return list grapes,oranges,cherries 
       
        public static string AddToList() { return AddToList; }
        //create static method TryMe(int, int,)takes in 2 numbers..method should devide first parameter by the second parameter and return 9
        //if there is a Arithmatic exception if no error return correct result from opperation.
        public static int TryMe(int numerator, int denominator)
        {
            try
            {
                int result = numerator / denominator;
                return result;
            }
            catch (ArithmeticException)
            {
                return 9;
            }
        }


    


}
