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

static double CalculateAverage(int[] numbersTable)
{
    if (numbersTable == null || numbersTable.Length == 0)
    {
        Console.WriteLine("Tablica nie moze byc pusta");
    }

    return numbersTable.Average();
}
}