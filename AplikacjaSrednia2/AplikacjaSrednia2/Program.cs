using System;

class Program{
static void Main()
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    Console.WriteLine("Średnia: "+CalculateAverage(numbers));
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