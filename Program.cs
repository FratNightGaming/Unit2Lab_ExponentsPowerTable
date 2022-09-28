using System;

namespace Exponents_PowersTable
{
    class Program
    {
        public static int userNumber;

        static void Main(string[] args)
        {
            TableOfPowers();
        }

        public static void TableOfPowers()
        {
            Console.WriteLine("Please enter a number 1 - 1092:");//1092 is max value that can be cubed without surpassing limit
            string num = Console.ReadLine();

            while(true)//nested while loop controls for incorrect inputs(non-numeric values and values not within specified range)
            {
                while ((!int.TryParse(num, out userNumber)))
                {
                    Console.WriteLine("Try again. Please enter a numeric value:");
                    num = Console.ReadLine();
                }

                if (userNumber >=1 && userNumber <= 1092)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Try again. Make sure your number is between 1 and 1092.");
                    num = Console.ReadLine();
                }
            }

            DisplayTable();
        }

        public static void DisplayTable()
        {
            Console.WriteLine("\nNumber" + "\t\t" + "Squared" + "\t\t" + "Cubed");
            Console.WriteLine("======================================");

            for (int i = 1; i <= userNumber; i++)
            {
                int numberSquared = (int)MathF.Pow(i, 2);
                int numberCubed = (int)MathF.Pow(i, 3);

                //Console.WriteLine(i + "\t\t" + numberSquared + "\t\t" + numberCubed);
                Console.WriteLine(String.Format("{0, 5} | {1, 15} | {2, 10}", i, numberSquared, numberCubed));
            }

            Console.WriteLine("\nWould you like to enter a new number? 'Y/N' or 'Yes'/'No'");
            string userAnswer = Console.ReadLine().ToUpper();

            if (userAnswer == "Y" || userAnswer == "YES")
            {
                Console.WriteLine();
                TableOfPowers();
            }

            else
            {
                Console.WriteLine("\nExiting Program. Goodybye!");
            }
        }
    }
}
