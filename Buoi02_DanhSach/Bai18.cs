using System;

class Bai18
{
    class Node
    {
        public int MaDon;
        public string TrangThai;
        public Node Prev;
        public Node Next;

        public Node(int maDon)
        {
            MaDon = maDon;
            TrangThai = "Cho xu ly";
        }
    }

    static Node head = null;

    static void ThemDonHang(int maDon)
    {
        Node p = new Node(maDon);

        if (head == null)
        {
            head = p;
            return;
        }

        Node temp = head;

        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = p;
        p.Prev = temp;
    }

    static Node TimDonHang(int maDon)
    {
        Node temp = head;

        while (temp != null)
        {
            if (temp.MaDon == maDon)
                return temp;

            temp = temp.Next;
        }

        return null;
    }

    static void ChuyenTrangThai(int maDon)
    {
        Node donHang = TimDonHang(maDon);

        if (donHang == null)
        {
            Console.WriteLine("Khong tim thay don hang.");
            return;
        }

        if (donHang.TrangThai == "Cho xu ly")
        {
            donHang.TrangThai = "Dang giao";
        }
        else if (donHang.TrangThai == "Dang giao")
        {
            donHang.TrangThai = "Hoan thanh";
        }
        else
        {
            Console.WriteLine("Don hang da hoan thanh.");
            return;
        }

        Console.WriteLine("Trang thai moi: " + donHang.TrangThai);
    }

    static void HienThi()
    {
        Node temp = head;

        Console.WriteLine("\n===== DANH SACH DON HANG =====");

        if (temp == null)
        {
            Console.WriteLine("Chua co don hang.");
            return;
        }

        while (temp != null)
        {
            Console.WriteLine(
                "Ma don: " + temp.MaDon +
                " | Trang thai: " + temp.TrangThai
            );

            temp = temp.Next;
        }
    }

    public static void Run()
    {
        int chon;

        do
        {
            Console.WriteLine("\n===== HE THONG DAT HANG =====");
            Console.WriteLine("1. Them don hang");
            Console.WriteLine("2. Chuyen trang thai don hang");
            Console.WriteLine("3. Hien thi danh sach don hang");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");

            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap ma don hang: ");
                    int maDon = int.Parse(Console.ReadLine());
                    ThemDonHang(maDon);
                    Console.WriteLine("Them don hang thanh cong.");
                    break;

                case 2:
                    Console.Write("Nhap ma don hang: ");
                    int ma = int.Parse(Console.ReadLine());
                    ChuyenTrangThai(ma);
                    break;

                case 3:
                    HienThi();
                    break;

                case 0:
                    Console.WriteLine("Ket thuc chuong trinh.");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }

        } while (chon != 0);
    }
}