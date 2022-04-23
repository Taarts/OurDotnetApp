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

            var numberOfCupsOfCoffee = 0;
            var fullName = "Patricia Amheiser ";
            DayOfWeek currentDay = DateTime.Today.DayOfWeek;
            Console.WriteLine("My name is " + fullName + "I have had " + numberOfCupsOfCoffee + " cups of coffee " + currentDay + ".");

            // Console.Write("What is your name? ");
            // var name = Console.ReadLine();

            // if (name == "Alice")
            // {
            //     Console.WriteLine("Hey Alice, how do you want your tofu done today? ");
            // }
            // else
            // // {
            // var greeting = $"It's a pleasure to meet you, {name}";
            // Console.WriteLine(greeting);
            // }
            // START new here ----------------//----------------
            // Console.WriteLine("Type any number between 1 and 1000. ");
            // var firstNumberAsAString = Console.ReadLine();
            // Console.WriteLine("Type a different number between 1 and 250. ");
            // var secondNumberAsAString = Console.ReadLine();

            // var firstOperand = double.Parse(firstNumberAsAString);
            // var secondOperand = double.Parse(secondNumberAsAString);


            // var sum = (firstOperand + secondOperand);
            // Console.WriteLine(sum);
            // var difference = (firstOperand - secondOperand);
            // Console.WriteLine(difference);
            // var product = (firstOperand * secondOperand);
            // Console.WriteLine(product);
            // var quotient = (firstOperand / secondOperand);
            // Console.WriteLine(quotient);
            // var remainder = (firstOperand % secondOperand);
            // Console.WriteLine(remainder);

        }

    }
}
