using System;

class Program
{
    static int TongBinhPhuong(int n)
    {
        if (n == 1)
            return 1;

        return TongBinhPhuong(n - 1) + n * n;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Tong S(n) = " + TongBinhPhuong(n));

        Console.ReadKey();
    }
}