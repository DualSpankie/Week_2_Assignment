using System;

namespace BenWeek2Assignment
{
    class program
    {
        static void Main(string[] args)

        {
            int myVar = 7; //Setting my variable to 7

            Console.WriteLine(-1 + 4 * myVar); //Displays to user the first equation.

            {

                Console.WriteLine((35 + 5) % myVar); //Displays to user the second equation.

            }
            {

                Console.WriteLine(14 + -4 * 6 / 12); //Displays to user the third equation.

            }

            {

                Console.WriteLine(2 + 12 / 6 * 1 - myVar % 2); //Displays to user the fourth equation.

            }

            if (myVar * myVar < 10)
            {
                Console.WriteLine("myVar is less than 4"); //Displays to user if the variables multipled to each other is less than 4.
            }
            else
            {
                Console.WriteLine("myVar is greater than 4"); //Displays to user if the variables multipled to each other is greater than 4.
            }
        }
    }
}