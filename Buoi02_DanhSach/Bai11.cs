using System;

class Bai11
{
    static bool LaMaTranDonVi(int[,] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j && a[i, j] != 1)
                    return false;

                if (i != j && a[i, j] != 0)
                    return false;
            }
        }

        return true;
    }

    static bool LaMaTranDoiXung(int[,] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] != a[j, i])
                    return false;
            }
        }

        return true;
    }

    static void Run()
    {
        Console.Write("Nhap cap ma tran n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] a = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i},{j}] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        if (LaMaTranDonVi(a, n))
            Console.WriteLine("Day la ma tran don vi.");
        else
            Console.WriteLine("Khong phai ma tran don vi.");

        if (LaMaTranDoiXung(a, n))
            Console.WriteLine("Day la ma tran doi xung.");
        else
            Console.WriteLine("Khong phai ma tran doi xung.");
    }
}