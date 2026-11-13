using System;

class Program
{
    static double TongPhanSo(int n)
    {
        if (n == 1)
            return 1;

        return TongPhanSo(n - 1) + 1.0 / n;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Tong S(n) = " + TongPhanSo(n));

        Console.ReadKey();
    }
}