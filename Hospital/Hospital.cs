using System;

class Hospital
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int doctors = 7;
        int treatedPatients = 0;
        int untreatedPatients = 0;
        for (int i = 1; i <= days; i++)
        {
            int patients = int.Parse(Console.ReadLine());

            if (i % 3 == 0 && untreatedPatients > treatedPatients)
            {
                doctors += 1;
            }

            if (patients - doctors <= 0)
            {
                treatedPatients += patients;
            }
            else
            {
                untreatedPatients += patients - doctors;
                treatedPatients += doctors;
            }
        }
        Console.WriteLine("Treated patients: {0}.", treatedPatients);
        Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
    }
}

