using System;

class Program
{
    static int UocLeMax(int n)
    {
        if (n % 2 == 1)
            return n;

        return UocLeMax(n / 2);
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Uoc le lon nhat: " + UocLeMax(n));

        Console.ReadKey();
    }
}
