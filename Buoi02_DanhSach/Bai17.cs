using System;

class Bai17
{
    class Node
    {
        public string TenBaiHat;
        public Node Prev;
        public Node Next;

        public Node(string ten)
        {
            TenBaiHat = ten;
        }
    }

    static Node head = null;
    static Node current = null;

    static void ThemBaiHat(string ten)
    {
        Node p = new Node(ten);

        if (head == null)
        {
            head = current = p;
            return;
        }

        Node temp = head;

        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = p;
        p.Prev = temp;
    }

    static void XoaBaiHat(string ten)
    {
        Node temp = head;

        while (temp != null && temp.TenBaiHat != ten)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Khong tim thay bai hat.");
            return;
        }

        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;
        else
            head = temp.Next;

        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;

        if (current == temp)
        {
            current = temp.Next ?? temp.Prev;
        }

        Console.WriteLine("Da xoa bai hat.");
    }

    static void Next()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Dang phat: " + current.TenBaiHat);
        }
        else
        {
            Console.WriteLine("Khong con bai hat tiep theo.");
        }
    }

    static void Previous()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Dang phat: " + current.TenBaiHat);
        }
        else
        {
            Console.WriteLine("Khong con bai hat truoc do.");
        }
    }

    static void HienThi()
    {
        Node temp = head;

        Console.WriteLine("\nDanh sach playlist:");

        while (temp != null)
        {
            if (temp == current)
                Console.Write("-> ");

            Console.WriteLine(temp.TenBaiHat);
            temp = temp.Next;
        }

        if (current == null)
            Console.WriteLine("Playlist rong.");
    }

    public static void Run()
    {
        int chon;

        do
        {
            Console.WriteLine("\n===== PLAYLIST NHAC =====");
            Console.WriteLine("1. Them bai hat");
            Console.WriteLine("2. Xoa bai hat");
            Console.WriteLine("3. Next");
            Console.WriteLine("4. Previous");
            Console.WriteLine("5. Hien thi playlist");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");

            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhap ten bai hat: ");
                    ThemBaiHat(Console.ReadLine());

                    if (current == null)
                        current = head;
                    break;

                case 2:
                    Console.Write("Nhap ten bai hat can xoa: ");
                    XoaBaiHat(Console.ReadLine());
                    break;

                case 3:
                    Next();
                    break;

                case 4:
                    Previous();
                    break;

                case 5:
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