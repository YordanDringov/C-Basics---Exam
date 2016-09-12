using System;

class CalculateDailyProfit
{
    static void Main()
    {

        int workingDays = int.Parse(Console.ReadLine());
        double earnMoneyPerDay = double.Parse(Console.ReadLine());
        double dollarCourse = double.Parse(Console.ReadLine());

        double sallary = workingDays * earnMoneyPerDay;
        double sallaryPerYear = sallary * 12 + 2.5 * sallary;

        double resultMoney = sallaryPerYear - 0.25 * sallaryPerYear;

        double resultLeva = resultMoney * dollarCourse;
        double averegeEarn = resultLeva / 365;

        Console.WriteLine($"{averegeEarn:f2}");

    }
}
