# Rastgele Sayı Listesi ve LINQ Sorguları

Bu proje, C# kullanarak rastgele üretilen 10 sayıdan oluşan bir liste üzerinden LINQ (Language-Integrated Query) sorguları gerçekleştiren bir uygulamadır. Bu örnekle, sayılar üzerinde çeşitli filtreleme ve dönüşüm işlemlerinin nasıl yapıldığını öğrenebilirsiniz.

## İçindekiler
- [Özellikler](#özellikler)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Nasıl Çalıştırılır](#nasıl-çalıştırılır)
- [Kod Açıklaması](#kod-açıklaması)

## Özellikler
Bu uygulama, rastgele 10 sayı üreterek bu liste üzerinde aşağıdaki işlemleri gerçekleştirir:
- Çift sayıları filtreleme
- Tek sayıları filtreleme
- Negatif sayıları filtreleme
- Pozitif sayıları filtreleme
- 15'ten büyük ve 22'den küçük sayıları filtreleme
- Listedeki her bir sayının karesini hesaplama

## Kullanılan Teknolojiler
- .NET Core veya .NET Framework
- C# dili
- LINQ (Language-Integrated Query)

## Nasıl Çalıştırılır
1. Bu projeyi bir C# geliştirme ortamına (örneğin, Visual Studio veya Visual Studio Code) açın.
2. `Program.cs` dosyasını oluşturun ve aşağıdaki kodu yapıştırın.
3. Projeyi çalıştırın.
4. Konsol ekranında orijinal liste ve yapılan sorguların sonuçları görüntülenecektir.

## Kod Açıklaması
```csharp
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
        foreach (var num in rangeNumbers)
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
```

### Kod Açıklaması
1. **Rastgele Sayı Listesi Oluşturma**: `Random` sınıfı kullanılarak -30 ile 30 arasında rastgele sayılardan oluşan bir liste oluşturulur.
2. **Çift Sayıları Filtreleme**: `Where` metodu ile çift sayılar `n % 2 == 0` koşulu kullanılarak seçilir.
3. **Tek Sayıları Filtreleme**: `Where` metodu ile tek sayılar `n % 2 != 0` koşulu kullanılarak seçilir.
4. **Negatif Sayıları Filtreleme**: `n < 0` koşulu ile negatif sayılar seçilir.
5. **Pozitif Sayıları Filtreleme**: `n > 0` koşulu ile pozitif sayılar seçilir.
6. **15-22 Aralığındaki Sayıları Filtreleme**: `n > 15 && n < 22` koşuluyla 15 ile 22 arasında olan sayılar seçilir.
7. **Sayıların Karelerini Hesaplama**: `Select` metodu ile listedeki her bir sayının karesi alınır.
