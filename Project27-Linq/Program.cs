using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Rastgele 10 sayıdan oluşan bir liste oluşturuyoruz
        Random random = new Random();
        List<int> numbers = Enumerable.Range(1, 10).Select(_ => random.Next(-30, 30)).ToList();

        Console.WriteLine("Orijinal Liste:");
        numbers.ForEach(n => Console.Write(n + " "));
        Console.WriteLine("\n");

        // Çift olan sayılar
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Çift Sayılar:");
        foreach (var num in evenNumbers)
            Console.Write(num + " ");
        Console.WriteLine("\n");

        // Tek olan sayılar
        var oddNumbers = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("Tek Sayılar:");
        foreach (var num in oddNumbers)
            Console.Write(num + " ");
        Console.WriteLine("\n");

        // Negatif sayılar
        var negativeNumbers = numbers.Where(n => n < 0);
        Console.WriteLine("Negatif Sayılar:");
        foreach (var num in negativeNumbers)
            Console.Write(num + " ");
        Console.WriteLine("\n");

        // Pozitif sayılar
        var positiveNumbers = numbers.Where(n => n > 0);
        Console.WriteLine("Pozitif Sayılar:");
        foreach (var num in positiveNumbers)
            Console.Write(num + " ");
        Console.WriteLine("\n");

        // 15'ten büyük ve 22'den küçük sayılar
        var rangeNumbers = numbers.Where(n => n > 15 && n < 22);
        Console.WriteLine("15'ten büyük ve 22'den küçük sayılar:");
        foreach (var num in rangeNumbers) // tek satırda {} kullanmamıza gerek yok
            Console.Write(num + " ");
        Console.WriteLine("\n");

        // Listedeki her bir sayının karesi
        var squares = numbers.Select(n => n * n);
        Console.WriteLine("Sayıların Karesi:");
        foreach (var square in squares)
            Console.Write(square + " ");
        Console.WriteLine();
    }
}