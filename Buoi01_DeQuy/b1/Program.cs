using System;

class Program
{
    static int Tong(int n)
    {
        if (n == 1)
            return 1;

        return Tong(n - 1) + n;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Tong S(n) = " + Tong(n));

        Console.ReadKey();
    }
}