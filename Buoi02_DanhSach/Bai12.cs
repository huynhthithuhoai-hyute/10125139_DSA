using System;

class Bai12
{
    static void Run()
    {
        Console.Write("Nhap so dong m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Nhap so cot n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhap so min: ");
        int soMin = int.Parse(Console.ReadLine());

        if (m <= 0 || n <= 0 || soMin < 0 || soMin > m * n)
        {
            Console.WriteLine("Du lieu khong hop le!");
            return;
        }

        int[,] bang = new int[m, n];
        bool[,] coMin = new bool[m, n];

        Random random = new Random();
        int daDat = 0;

        // Dat min ngau nhien, khong trung vi tri
        while (daDat < soMin)
        {
            int i = random.Next(m);
            int j = random.Next(n);

            if (!coMin[i, j])
            {
                coMin[i, j] = true;
                daDat++;
            }
        }

        // Tinh so min xung quanh moi o
        int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (coMin[i, j])
                    continue;

                int dem = 0;

                for (int k = 0; k < 8; k++)
                {
                    int x = i + dx[k];
                    int y = j + dy[k];

                    if (x >= 0 && x < m &&
                        y >= 0 && y < n &&
                        coMin[x, y])
                    {
                        dem++;
                    }
                }

                bang[i, j] = dem;
            }
        }

        // In bang
        Console.WriteLine("\nBang Minesweeper:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (coMin[i, j])
                    Console.Write("* ");
                else
                    Console.Write(bang[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}