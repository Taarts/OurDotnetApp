using System;

namespace OurDotnetApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // implicit
            // var personName = "Samantha";
            // var score = 98;

            // // explicit
            // string otherScore = "100";
            // int price = 50;

            // var sentence = "The quick brown fox jumped over the lazy dog";
            // var howLong = sentence.Length;

            // var rightNow = DateTime.Now;
            // var currentMonth = rightNow.Month;



            /* 
            VARIABLES

            how many cups of coffee do I drink a day? = numberOfCupsOfCoffee
            identify my name = fullName
            capture the date = today
            use all three bits of information to write out a line
            */

            // BELOW WORKS

            // var numberOfCupsOfCoffee = 0;
            // var fullName = "Patricia Amheiser";
            // DayOfWeek currentDay = DateTime.Today.DayOfWeek;
            // Console.WriteLine("My name is " + fullName + "I have had " + numberOfCupsOfCoffee + "cups of coffee " + currentDay + ".");

            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            var greeting = $"It's a pleasure to meet you, {name}";
            Console.WriteLine(greeting);

            Console.Write("What color is your hair? ");
            var hairColor = Console.ReadLine();
            var compliment = $"That's a pretty shade of {hairColor}, {name}, it suits you!";
            Console.WriteLine(compliment);

            // START new here ----------------//----------------

        }

    }
}
