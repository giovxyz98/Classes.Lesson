using System;

public interface CorteDiCassazione
{
    public static void check(Paesi paesi)
    {
        Console.WriteLine($"\nIl paese {paesi.Paese} viola i diritti umani: {paesi.viola}");

    }
}
