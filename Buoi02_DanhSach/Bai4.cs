
using System;

class Bai4
{
    // Khai báo cấu trúc một nút
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

    // Thêm phần tử vào cuối danh sách
    static void ThemCuoi(int x)
    {
        Node p = new Node(x);

        // Nếu danh sách rỗng
        if (pHead == null)
        {
            pHead = p;
            return;
        }

        // Duyệt đến nút cuối cùng
        Node q = pHead;

        while (q.Next != null)
        {
            q = q.Next;
        }

        q.Next = p;
    }

    // Hiển thị danh sách
    static void HienThi()
    {
        if (pHead == null)
        {
            Console.WriteLine("Danh sach rong!");
            return;
        }

        Node p = pHead;

        while (p != null)
        {
            Console.Write(p.Data + " -> ");
            p = p.Next;
        }

        Console.WriteLine("NULL");
    }

    // Câu a: Đếm số lần xuất hiện của x
    static int DemSoLanXuatHien(int x)
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

    // Câu b: Tìm phần tử dương nhỏ nhất
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

    // Câu c: Xóa phần tử x xuất hiện đầu tiên
    static bool XoaPhanTuDauTien(int x)
    {
        Node p = pHead;
        Node t = null;

        // Tìm phần tử x đầu tiên
        while (p != null && p.Data != x)
        {
            t = p;
            p = p.Next;
        }

        // Không tìm thấy x
        if (p == null)
        {
            return false;
        }

        // Trường hợp x nằm ở đầu danh sách
        if (t == null)
        {
            pHead = p.Next;
        }
        else
        {
            // Nối nút trước với nút sau p
            t.Next = p.Next;
        }

        return true;
    }

    // Chương trình chính của Bài 4
    public static void Run()
    {
        pHead = null;

        Console.WriteLine("===== BAI TAP 4: DANH SACH LIEN KET DON =====");

        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        // Nhập danh sách
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
            int x = int.Parse(Console.ReadLine());

            ThemCuoi(x);
        }

        Console.WriteLine("\nDanh sach vua nhap:");
        HienThi();

        // Câu a
        Console.Write("\nNhap gia tri x can dem: ");
        int giaTriX = int.Parse(Console.ReadLine());

        int dem = DemSoLanXuatHien(giaTriX);

        Console.WriteLine("So lan xuat hien cua " + giaTriX + " la: " + dem);

        // Câu b
        int min = TimSoDuongNhoNhat();

        if (min == int.MaxValue)
        {
            Console.WriteLine("Danh sach khong co phan tu duong.");
        }
        else
        {
            Console.WriteLine("Phan tu duong nho nhat la: " + min);
        }

        // Câu c
        Console.Write("\nNhap gia tri x can xoa: ");
        int giaTriXoa = int.Parse(Console.ReadLine());

        if (XoaPhanTuDauTien(giaTriXoa))
        {
            Console.WriteLine("Da xoa phan tu " + giaTriXoa + " dau tien.");
        }
        else
        {
            Console.WriteLine("Khong tim thay phan tu can xoa.");
        }

        Console.WriteLine("Danh sach sau khi xoa:");
        HienThi();
    }
}
