using System;

class Program
{
    // Універсальний метод для пошуку мінімального і максимального елементів
    static (T min, T max) FindMinMax<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.");

        T min = array[0];
        T max = array[0];

        foreach (T item in array)
        {
            if (item.CompareTo(min) < 0) min = item;
            if (item.CompareTo(max) > 0) max = item;
        }

        return (min, max);
    }

    static void Main(string[] args)
    {
        // Масив цілих чисел
        int[] intArray = { 1, 2, 3, 4, 5 };
        var (intMin, intMax) = FindMinMax(intArray);
        Console.WriteLine($"Int Array: Min={intMin}, Max={intMax}");

        // Масив дійсних чисел
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        var (doubleMin, doubleMax) = FindMinMax(doubleArray);
        Console.WriteLine($"Double Array: Min={doubleMin}, Max={doubleMax}");

        Console.ReadKey();
    }
}

