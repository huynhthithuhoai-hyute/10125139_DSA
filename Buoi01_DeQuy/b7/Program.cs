using System;

class Program
{
    static int SoChuSo(int n)
    {
        if (n == 0)
            return 0;

        return SoChuSo(n / 10) + 1;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("So chu so = " + SoChuSo(n));

        Console.ReadKey();
    }
}