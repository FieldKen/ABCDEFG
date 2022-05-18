Console.WriteLine("Tof!");

public static class Extensions
{
    static void Optellen(ref this int getal1, int getal2)
    {
        getal1 += getal2;
    }
} 