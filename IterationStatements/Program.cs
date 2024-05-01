using System;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void NumbersThousandToNegativeThousand()
        {
            int i = 1000;
            while ( i > -1001) {
                Console.WriteLine(i);
                i--;
            } 
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ThreeByThree()
        {
            int threes = 3;
            while (threes < 999)
            {
                Console.WriteLine(threes);
                threes = threes + 3;
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void GetTwo()
        {
            Console.WriteLine("Please enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal.");
            }
            else { Console.WriteLine($"{num1} and {num2} are not equal"); }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());
            int givenNumber = x;
            Console.WriteLine(givenNumber % 2 == 0 ? "Even" : "Odd");
        }

        //Write a method to check whether a given number is positive or negative

        public static void PosOrNeg(int a)
        {
            Console.WriteLine(a >= 0 ? "Positive" : "Negative");
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge

        public static void OldEnoughToVote(int age)
        {
            //Parse()
            //TryParse()
            Console.WriteLine(age >= 18 ? "You can vote" : "You're too young");
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void FromNTenToPTen()
        {
            Console.WriteLine("Enter a number");
            int isBetween = int.Parse(Console.ReadLine());
            if (isBetween >= -10 && isBetween <= 10)
            {
                Console.WriteLine("Yor number is between -10 and 10.");
            } else

                Console.WriteLine("You're number is not between -10 and 10.");
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiplicationTable(int t)
        {

            int s = 1;
            while (s < 13)
            {
                int u = t * s++;
                Console.WriteLine(u);
            }
        }
        //Call the methods to test them in the Main method below

        static void Main(string[] args)
        {
            NumbersThousandToNegativeThousand();
            ThreeByThree();
            GetTwo();
            EvenOrOdd();
            PosOrNeg(4);
            OldEnoughToVote(24);
            FromNTenToPTen();
            MultiplicationTable(2);
        }
    }
}
