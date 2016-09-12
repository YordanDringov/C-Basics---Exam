using System;

class Company
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double possibleWorkingDays = days - days * 0.10;
        double workingHours = possibleWorkingDays * 8;

        double extraWorkingHours = workers * (2 * days);

        int totalWorkingHours = (int)(workingHours + extraWorkingHours);

        if (totalWorkingHours >= hours)
        {
            Console.WriteLine($"Yes!{totalWorkingHours - hours} hours left.");
        }
        else
        {
            Console.WriteLine($"Not enough time!{hours - totalWorkingHours} hours needed.");
        }
    }
}
