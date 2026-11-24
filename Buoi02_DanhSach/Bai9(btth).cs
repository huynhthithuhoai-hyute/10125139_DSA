using System;

class Bai9

{
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static bool LaSoHoanHao(int n)
    {
        if (n <= 1) return false;

        int tong = 0;

        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
                tong += i;
        }

        return tong == n;
    }

    public static void Run()
    {
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nCac so nguyen to:");
        foreach (int x in a)
            if (LaSoNguyenTo(x))
                Console.Write(x + " ");

        Console.WriteLine("\n\nCac so chan:");
        foreach (int x in a)
            if (x % 2 == 0)
                Console.Write(x + " ");

        Console.WriteLine("\n\nCac so hoan hao:");
        foreach (int x in a)
            if (LaSoHoanHao(x))
                Console.Write(x + " ");

        Console.WriteLine();
    }
}