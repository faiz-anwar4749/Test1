using System;
using System.ComponentModel.DataAnnotations;

namespace tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //ADDING COMMENT FOR UC2


            //int a = Math.Max(3, 42);
            //Console.WriteLine(a);
            // o/p = 42

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("How many candies do you want?");
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Hi, {name}. You will get {candies} candies.");
            // o/p = Hi, Faiz. You will get "x" candies.

            /*Console.WriteLine("This \nis \nsempiternal.");
            
             o/p -
             This
             is 
             sempiternal.
             */

            //Console.WriteLine("brooo. this \"shit\" is crazy.");
            //o/p = brooo. this "shit" is crazy.

            //Console.WriteLine("Please enter your age");
            //string agestr = Console.ReadLine();
            //int age = Convert.ToInt32(agestr);

            //if (age < 2)
            //{
            //    Console.WriteLine("Bsdk");
            //}
            //else if (age < 10)
            //{
            //    Console.WriteLine("School jaao be");
            //}
            //else if(age < 18)
            //{
            //    Console.WriteLine("You are below 18");
            //}
            //else if(age > 18 && age < 75)
            //{
            //    Console.WriteLine("You are eligible to drive.");
            //}
            //else if(age > 75)
            //{
            //    Console.WriteLine("you are ineligible");
            //}

            // C# program to illustrate the  
            // Random.Next() Method
            // The Next() Method of System.Random class in C# is used to get a random integer number.
            //This method can be overloaded by passing different parameters to it as follows:
            
            
            //Instatiate random number generator
            Random rand = new Random();

            // Print 10 random numbers 

            /*Console.WriteLine("Print 10 random numbers");
            for(int i=1; i<=10; i++)
                Console.WriteLine("{0} -> {1}", i, rand.Next());
            */

            // this will print 10 random numbers 
            // if we want the random numbers to be less than a certain specified value, we can put that number inside the 
            // rand.next() bracket. for eg if we want to print numbers less than 10000, we will simply write rand.next(10000)
            // instead of the above code.

            //Also, to print the random numbers within a certain range, we can write rand.next(Minvalue, MaxValue).

            //Console.WriteLine("Print 10 random numbers");
            //for (int i = 1; i <= 10; i++)
            //    Console.WriteLine("{0} -> {1}", i, rand.Next(50,100));











        }
    }
}
