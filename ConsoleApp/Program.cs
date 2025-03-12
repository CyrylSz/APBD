using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 10, 15, 20 };
        Console.WriteLine("Średnia: " + ObliczSrednia(numbers));
    }

    public static double ObliczSrednia(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica nie może być pusta.");

        int suma = 0;
        foreach (var number in numbers)
        {
            suma += number;
        }
        return (double)suma / numbers.Length;
    }
}
