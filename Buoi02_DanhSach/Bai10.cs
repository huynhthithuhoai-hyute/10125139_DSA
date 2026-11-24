using System;

class Bai10
{
    static void Run()
    {
        Console.Write("Nhap so dong m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Nhap so cot n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] a = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i},{j}] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int top = 0, bottom = m - 1;
        int left = 0, right = n - 1;

        Console.WriteLine("\nMa tran xoan oc:");

        while (top <= bottom && left <= right)
        {
            // Trai sang phai
            for (int j = left; j <= right; j++)
                Console.Write(a[top, j] + " ");
            top++;

            // Tren xuong duoi
            for (int i = top; i <= bottom; i++)
                Console.Write(a[i, right] + " ");
            right--;

            // Phai sang trai
            if (top <= bottom)
            {
                for (int j = right; j >= left; j--)
                    Console.Write(a[bottom, j] + " ");
                bottom--;
            }

            // Duoi len tren
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    Console.Write(a[i, left] + " ");
                left++;
            }
        }

        Console.WriteLine();
    }
}

