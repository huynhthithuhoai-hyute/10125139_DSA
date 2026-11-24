
using System;

class Bai7
{
    // a) Nhập nhiệt độ của n ngày
    static void NhapNhietDo(double[] nhietDo, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap nhiet do ngay {0}: ", i + 1);
            nhietDo[i] = double.Parse(Console.ReadLine());
        }
    }

    // b) Tìm nhiệt độ cao nhất và ngày tương ứng
    static void TimNhietDoCaoNhat(double[] nhietDo, int n)
    {
        double max = nhietDo[0];

        for (int i = 1; i < n; i++)
        {
            if (nhietDo[i] > max)
            {
                max = nhietDo[i];
            }
        }

        Console.WriteLine("Nhiet do cao nhat: " + max);
        Console.Write("Ngay co nhiet do cao nhat: ");

        for (int i = 0; i < n; i++)
        {
            if (nhietDo[i] == max)
            {
                Console.Write((i + 1) + " ");
            }
        }

        Console.WriteLine();
    }

    // c) Tìm nhiệt độ thấp nhất và ngày tương ứng
    static void TimNhietDoThapNhat(double[] nhietDo, int n)
    {
        double min = nhietDo[0];

        for (int i = 1; i < n; i++)
        {
            if (nhietDo[i] < min)
            {
                min = nhietDo[i];
            }
        }

        Console.WriteLine("Nhiet do thap nhat: " + min);
        Console.Write("Ngay co nhiet do thap nhat: ");

        for (int i = 0; i < n; i++)
        {
            if (nhietDo[i] == min)
            {
                Console.Write((i + 1) + " ");
            }
        }

        Console.WriteLine();
    }

    // d) Tính nhiệt độ trung bình
    static double TinhNhietDoTrungBinh(double[] nhietDo, int n)
    {
        double tong = 0;

        for (int i = 0; i < n; i++)
        {
            tong += nhietDo[i];
        }

        return tong / n;
    }

    // Chương trình chính
    public static void Run()
    {
        Console.Write("Nhap so ngay n: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("So ngay phai lon hon 0!");
            return;
        }

        // Khai báo mảng nhiệt độ
        double[] nhietDo = new double[n];

        // Nhập dữ liệu
        NhapNhietDo(nhietDo, n);

        // Hiển thị nhiệt độ
        Console.WriteLine("\nDanh sach nhiet do:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Ngay {0}: {1}", i + 1, nhietDo[i]);
        }

        // Tìm nhiệt độ cao nhất
        Console.WriteLine("\n--- KET QUA ---");
        TimNhietDoCaoNhat(nhietDo, n);

        // Tìm nhiệt độ thấp nhất
        TimNhietDoThapNhat(nhietDo, n);

        // Tính nhiệt độ trung bình
        double trungBinh = TinhNhietDoTrungBinh(nhietDo, n);

        Console.WriteLine("Nhiet do trung binh: {0:F2}", trungBinh);
    }
}
