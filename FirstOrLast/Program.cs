using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perkonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab, kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit ja perekonnanimes on {lastName.Length}");
            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimes on rohkem sümbolit kui perekonnanimes.");
            }
            else
            {
                Console.WriteLine("Sinu perekonnanimes on rohkem sümbolit kui nimes.");
            }

        }
    }
}
