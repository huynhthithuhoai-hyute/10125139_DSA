using System;

class Bai16
{
    class Node
    {
        public string Url;
        public Node Prev;
        public Node Next;

        public Node(string url)
        {
            Url = url;
        }
    }

    static Node current = null;

    static void TruyCapTrang(string url)
    {
        Node p = new Node(url);

        if (current == null)
        {
            current = p;
            return;
        }

        // Xoa lich su Forward
        current.Next = null;

        p.Prev = current;
        current.Next = p;
        current = p;
    }

    static void Back()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Da quay lai: " + current.Url);
        }
        else
        {
            Console.WriteLine("Khong the Back!");
        }
    }

    static void Forward()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Da tien toi: " + current.Url);
        }
        else
        {
            Console.WriteLine("Khong the Forward!");
        }
    }

    static void HienThiTrangHienTai()
    {
        if (current == null)
            Console.WriteLine("Chua co trang web nao.");
        else
            Console.WriteLine("Trang hien tai: " + current.Url);
    }

    public static void Run()
    {
        int chon;

        do
        {
            Console.WriteLine("\n===== LICH SU DUYET WEB =====");
            Console.WriteLine("1. Truy cap trang web");
            Console.WriteLine("2. Back");
            Console.WriteLine("3. Forward");
            Console.WriteLine("4. Hien thi trang hien tai");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");

            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap URL: ");
                    string url = Console.ReadLine();
                    TruyCapTrang(url);
                    break;

                case 2:
                    Back();
                    break;

                case 3:
                    Forward();
                    break;

                case 4:
                    HienThiTrangHienTai();
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