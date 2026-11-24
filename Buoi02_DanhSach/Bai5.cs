
using System;

class Bai5
{
    // Khai báo cấu trúc Node
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int x)
        {
            Data = x;
            Next = null;
        }
    }

    // Con trỏ đầu danh sách
    static Node pHead = null;

    // Thêm một phần tử vào cuối danh sách
    static void ThemCuoi(int x)
    {
        Node p = new Node(x);

        if (pHead == null)
        {
            pHead = p;
        }
        else
        {
            Node q = pHead;

            while (q.Next != null)
            {
                q = q.Next;
            }

            q.Next = p;
        }
    }

    // Hiển thị danh sách
    static void HienThi()
    {
        Node p = pHead;

        while (p != null)
        {
            Console.Write(p.Data + " -> ");
            p = p.Next;
        }

        Console.WriteLine("NULL");
    }

    // a) Tìm phần tử lớn nhất
    static int TimMax()
    {
        int max = int.MinValue;
        Node p = pHead;

        while (p != null)
        {
            if (p.Data > max)
            {
                max = p.Data;
            }

            p = p.Next;
        }

        return max;
    }

    // b) Tính tổng các phần tử
    static long TinhTong()
    {
        long tong = 0;
        Node p = pHead;

        while (p != null)
        {
            tong += p.Data;
            p = p.Next;
        }

        return tong;
    }

    // Hàm kiểm tra số nguyên tố
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    // c) Đếm số nguyên tố
    static int DemSoNguyenTo()
    {
        int dem = 0;
        Node p = pHead;

        while (p != null)
        {
            if (LaSoNguyenTo(p.Data))
            {
                dem++;
            }

            p = p.Next;
        }

        return dem;
    }

    // d) Đếm số âm, số 0 và số dương
    static void DemAmDuongKhong(
        out int am, out int khong, out int duong)
    {
        am = 0;
        khong = 0;
        duong = 0;

        Node p = pHead;

        while (p != null)
        {
            if (p.Data < 0)
            {
                am++;
            }
            else if (p.Data == 0)
            {
                khong++;
            }
            else
            {
                duong++;
            }

            p = p.Next;
        }
    }

    // e) Đếm số lần xuất hiện của x
    static int DemX(int x)
    {
        int dem = 0;
        Node p = pHead;

        while (p != null)
        {
            if (p.Data == x)
            {
                dem++;
            }

            p = p.Next;
        }

        return dem;
    }

    // f) Tìm phần tử dương nhỏ nhất
    static int TimSoDuongNhoNhat()
    {
        int min = int.MaxValue;
        Node p = pHead;

        while (p != null)
        {
            if (p.Data > 0 && p.Data < min)
            {
                min = p.Data;
            }

            p = p.Next;
        }

        return min;
    }

    // Chương trình chính của bài 5
    public static void Run()
    {
        pHead = null;

        Console.Write("Nhap so luong phan tu n: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("So luong phan tu phai lon hon 0!");
            return;
        }

        // Nhập danh sách
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu {0}: ", i + 1);
            int x = int.Parse(Console.ReadLine());

            ThemCuoi(x);
        }

        Console.WriteLine("\nDanh sach vua nhap:");
        HienThi();

        // a) Tìm phần tử lớn nhất
        Console.WriteLine("\na) Phan tu lon nhat: " + TimMax());

        // b) Tính tổng
        Console.WriteLine("b) Tong cac phan tu: " + TinhTong());

        // c) Đếm số nguyên tố
        Console.WriteLine("c) So luong so nguyen to: " + DemSoNguyenTo());

        // d) Đếm số âm, 0, dương
        int am, khong, duong;

        DemAmDuongKhong(out am, out khong, out duong);

        Console.WriteLine("d) So phan tu am: " + am);
        Console.WriteLine("   So phan tu bang 0: " + khong);
        Console.WriteLine("   So phan tu duong: " + duong);

        // e) Đếm số lần xuất hiện của x
        Console.Write("\nNhap gia tri x can dem: ");
        int giaTriX = int.Parse(Console.ReadLine());

        Console.WriteLine("e) So lan xuat hien cua {0}: {1}",
            giaTriX, DemX(giaTriX));

        // f) Tìm số dương nhỏ nhất
        int minDuong = TimSoDuongNhoNhat();

        if (minDuong == int.MaxValue)
        {
            Console.WriteLine("f) Danh sach khong co phan tu duong.");
        }
        else
        {
            Console.WriteLine("f) So duong nho nhat: " + minDuong);
        }
    }
}
