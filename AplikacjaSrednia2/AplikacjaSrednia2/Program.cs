using System;

class Program{
static void Main()
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    Console.WriteLine("Średnia: "+CalculateAverage(numbers));
    Console.WriteLine("Maksymalna wartość: "+CalculateMax(numbers));
}

private static int CalculateMax(int[] numbers)
{
    return numbers.Max();
}

static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        Console.WriteLine("Tablica nie moze byc pusta");
    }

    return numbers.Average();
}
}