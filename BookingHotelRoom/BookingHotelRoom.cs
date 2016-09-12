
using System;

class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        Console.WriteLine($"Apartment: {CheckPriceForApartament(month, nights):f2} lv.");
        Console.WriteLine($"Studio: {CheckPriceForStudio(month, nights):f2} lv.");
    }

    private static double CheckPriceForStudio(string month, int nights)
    {
        double totalSum = 0;
        if (month == "May" || month == "October")
        {
            double studioPrice = 50;
            totalSum = studioPrice * nights;
            if (nights > 7 && nights <= 14)
            {
                totalSum = totalSum - totalSum * 0.05;
            }
            else if (nights > 14)
            {
                totalSum = totalSum - totalSum * 0.3;
            }
        }
        else if (month == "June" || month == "September")
        {
            double studioPrice = 75.20;
            totalSum = studioPrice * nights;
            if (nights > 14)
            {
                totalSum = totalSum - totalSum * 0.2;
            }
        }
        else if (month == "July" || month == "August")
        {
            double studioPrice = 76;
            totalSum = studioPrice * nights;
        }
        return totalSum;
    }

    private static double CheckPriceForApartament(string month, int nights)
    {
        double totalSum = 0;
        if (month == "May" || month == "October")
        {
            double priceForApartament = 65;
            totalSum = priceForApartament * nights;
        }
        else if (month == "June" || month == "September")
        {
            double priceForApartament = 68.70;
            totalSum = priceForApartament * nights;
        }
        else if (month == "July" || month == "August")
        {
            double priceForApartament = 77;
            totalSum = priceForApartament * nights;
        }
        if (nights > 14)
        {
            totalSum = totalSum - totalSum * 0.1;
        }
        return totalSum;
    }
}