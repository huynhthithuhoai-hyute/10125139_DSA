
using System;

class Bai3
{
    static int[,] a;
    static int n;

    // Nhập ma trận
    static void NhapMaTran()
    {
        Console.Write("Nhap cap ma tran n: ");
        n = int.Parse(Console.ReadLine());

        if (n < 0 || n >= 100)
        {
            Console.WriteLine("n phai nam trong khoang 0 den 99!");
            return;
        }

        a = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i},{j}] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // In ma trận
    static void InMaTran()
    {
        Console.WriteLine("\nMa tran vua nhap:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(a[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    // a. Tính tổng tất cả phần tử
    static void TinhTong()
    {
        long tong = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                tong += a[i, j];
            }
        }

        Console.WriteLine("\nTong cac phan tu cua ma tran: " + tong);
    }

    // b. Tìm giá trị dương nhỏ nhất
    static void TimSoDuongNhoNhat()
    {
        int min = int.MaxValue;
        bool timThay = false;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] > 0 && a[i, j] < min)
                {
                    min = a[i, j];
                    timThay = true;
                }
            }
        }

        if (timThay)
        {
            Console.WriteLine(
                "\nGia tri duong nho nhat: " + min
            );
        }
        else
        {
            Console.WriteLine(
                "\nMa tran khong co phan tu duong!"
            );
        }
    }

    // c. Tính tổng đường chéo phụ
    static void TinhTongCheoPhu()
    {
        long tong = 0;

        for (int i = 0; i < n; i++)
        {
            tong += a[i, n - 1 - i];
        }

        Console.WriteLine(
            "\nTong cac phan tu tren duong cheo phu: " + tong
        );
    }

    // d. Kiểm tra đường chéo chính có tăng dần không
    static bool KiemTraTangDan()
    {
        for (int i = 0; i < n - 1; i++)
        {
            if (a[i, i] >= a[i + 1, i + 1])
            {
                return false;
            }
        }

        return true;
    }

    // Chương trình chính của Bài 3
    public static void Run()
    {
        NhapMaTran();

        if (n < 0 || n >= 100)
        {
            return;
        }

        InMaTran();

        int chon;

        do
        {
            Console.WriteLine("\n========== BAI TAP 3 ==========");
            Console.WriteLine("1. Tinh tong cac phan tu");
            Console.WriteLine("2. Tim so duong nho nhat");
            Console.WriteLine("3. Tinh tong duong cheo phu");
            Console.WriteLine("4. Kiem tra duong cheo chinh tang dan");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");

            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    TinhTong();
                    break;

                case 2:
                    TimSoDuongNhoNhat();
                    break;

                case 3:
                    TinhTongCheoPhu();
                    break;

                case 4:
                    if (KiemTraTangDan())
                    {
                        Console.WriteLine(
                            "\nDuong cheo chinh tang dan!"
                        );
                    }
                    else
                    {
                        Console.WriteLine(
                            "\nDuong cheo chinh khong tang dan!"
                        );
                    }
                    break;

                case 0:
                    Console.WriteLine("Ket thuc Bai 3!");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

        } while (chon != 0);
    }
}
