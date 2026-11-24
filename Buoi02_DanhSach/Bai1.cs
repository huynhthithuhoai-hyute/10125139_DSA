
using System;


class Bai1
{
    // nhập mảng 
    public static void NhapMang(ref int[] a, ref int n)
    {
        Console.Write("Nhap so luong phan tu n: ");
        n = int.Parse(Console.ReadLine());

        a = new int[n];

        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());

                if (a[i] <= 0)
                {
                    Console.WriteLine("Vui long nhap so nguyen duong!");
                }

            } while (a[i] <= 0);
        }
    }

    // hiển thị mảng 
    public static void HienThiMang(int[] a, int n)
    {
        Console.WriteLine("Mang hien tai:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }

    // Chèn phần tử x vào vị trí k
    public static void ChenPhanTu(
        ref int[] a, ref int n, int x, int k)
    {
        if (k < 0 || k > n)
        {
            Console.WriteLine("Vi tri chen khong hop le!");
            return;
        }

        int[] tmp = new int[n + 1];

        // Sao chép các phần tử trước vị trí k
        for (int i = 0; i < k; i++)
        {
            tmp[i] = a[i];
        }

        // Chèn x vào vị trí k
        tmp[k] = x;

        // Sao chép các phần tử còn lại
        for (int i = k; i < n; i++)
        {
            tmp[i + 1] = a[i];
        }

        a = tmp;
        n++;

        Console.WriteLine("Chen phan tu thanh cong!");
    }

    // Ham chay Bai 1
    public static void Run()
    {
        int[] a = null;
        int n = 0;

        // Câu a: Nhập mảng
        NhapMang(ref a, ref n);

        // Câu b: Hiển thị mảng
        HienThiMang(a, n);

        // Câu c: Chèn phần tử
        Console.Write("\nNhap gia tri x can chen: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Nhap vi tri k can chen (0 den n): ");
        int k = int.Parse(Console.ReadLine());

        ChenPhanTu(ref a, ref n, x, k);

        // Hiển thị kết quả
        HienThiMang(a, n);
    }
}
