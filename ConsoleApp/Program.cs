using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 10, 15, 20 };
        Console.WriteLine("Średnia: " + ObliczSrednia(numbers));
        Console.WriteLine("Maksymalna wartość: " + ZnajdzMaksimum(numbers));
    }

    public static double ObliczSrednia(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica nie może być pusta.");

        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return (double)sum / numbers.Length;
    }
    public static int ZnajdzMaksimum(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica nie może być pusta.");

        int max = numbers[0];
        foreach (var number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }
}
