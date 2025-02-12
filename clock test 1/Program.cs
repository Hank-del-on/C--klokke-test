using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Definerer en ordbok for hilsener basert på tid på døgnet
        Dictionary<string, string> greetings = new Dictionary<string, string>
        {
            { "Morning", "God morgen!" },
            { "Afternoon", "God ettermiddag!" },
            { "Evening", "God kveld!" },
            { "Night", "God natt!" }
        };

        // Ber brukeren om å skrive inn navnet sitt
        Console.WriteLine("Skriv inn klokkeslettet:");
        string userName = Console.ReadLine();

        // Henter gjeldende tid
        DateTime currentTime = DateTime.Now;

        // Bestemmer hvilken hilsen som skal returneres
        string greeting;
        if (currentTime.Hour >= 6 && currentTime.Hour < 12)
        {
            greeting = greetings["Morning"];
        }
        else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
        {
            greeting = greetings["Afternoon"];
        }
        else if (currentTime.Hour >= 18 && currentTime.Hour < 24)
        {
            greeting = greetings["Evening"];
        }
        else
        {
            greeting = greetings["Night"];
        }

        // Viser hilsenen til brukeren
        Console.WriteLine($"{greeting} {userName}!");

        // Venter på at brukeren skal trykke en tast før programmet avsluttes
        Console.ReadKey();
    }
}
