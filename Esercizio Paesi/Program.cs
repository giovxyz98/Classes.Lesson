using System;
using System.Security.Cryptography.X509Certificates;

namespace Esercizio_Paesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Europa PaesiEurozona = new Europa();
            Console.WriteLine($"I paesi dell'Eurozona sono:");
            PaesiEurozona.PaesiEuroZona();
            Console.WriteLine($"\n\nI paesi dell'UE sono:");
            Europa PaesiEuropei = new Europa();
            PaesiEuropei.PaesiUE();
            Console.WriteLine($"\n\nI Paesi facenti parte solo dell'ONU sono:");
            ONU paesionu = new ONU();
            paesionu.PaesiONU();
            Console.WriteLine($"\n\nI paesi facenti parte sia dell'ONU che dell UE sono:");
            paesionu.PaesiONU();
            PaesiEuropei.PaesiUE();

            Paesi Angola = new Paesi();
            Angola.Paese = "Angola";
            Angola.viola = "si";
            Paesi Arabia_Saudita = new Paesi();
            Arabia_Saudita.Paese = "Arabia Saudita";
            Arabia_Saudita.viola = "si";
            Paesi Burundi = new Paesi();
            Burundi.Paese = "Burundi";
            Burundi.viola = "si";
            Paesi Cina = new Paesi();
            Cina.Paese = "Cina";
            Cina.viola = "si";
            Paesi Egitto = new Paesi();
            Egitto.Paese = "Egitto";
            Egitto.viola = "si";
            CorteDiCassazione.check(Angola);
            CorteDiCassazione.check(Arabia_Saudita);
            CorteDiCassazione.check(Burundi);
            CorteDiCassazione.check(Cina);
            CorteDiCassazione.check(Egitto);
            PenaDiMorte penaDiMorte = new PenaDiMorte();
            penaDiMorte.Pena();
        }
    }
}
