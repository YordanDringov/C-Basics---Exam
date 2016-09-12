using System;

class ManipulatingNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int firstNumber = number;

        int firstDigit = number / 100;
        int secondDigits = number / 10;
        int secondDigit = secondDigits % 10;
        int thirdDigit = number % 10;

        for (int i = 0; i < firstDigit + secondDigit; i++)
        {
            for (int j = 0; j < firstDigit + thirdDigit; j++)
            {
                if (number % 5 == 0)
                {
                    number = number - (firstNumber / 100);
                }
                else if (number % 3 == 0)
                {
                    number = number - secondDigit;
                }
                else
                {
                    number = number + (firstNumber % 10);
                }
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}