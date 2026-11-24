using System;

class Bai14
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    static void ThemCuoi(ref Node head, int x)
    {
        Node p = new Node(x);

        if (head == null)
        {
            head = p;
            return;
        }

        Node temp = head;

        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = p;
    }

    static Node GopDanhSach(Node a, Node b)
    {
        Node dummy = new Node(0);
        Node tail = dummy;

        while (a != null && b != null)
        {
            if (a.Data <= b.Data)
            {
                tail.Next = a;
                a = a.Next;
            }
            else
            {
                tail.Next = b;
                b = b.Next;
            }

            tail = tail.Next;
        }

        if (a != null)
            tail.Next = a;

        if (b != null)
            tail.Next = b;

        return dummy.Next;
    }

    static Node NhapDanhSach(string ten)
    {
        Node head = null;

        Console.Write($"Nhap so phan tu danh sach {ten}: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            int x = int.Parse(Console.ReadLine());
            ThemCuoi(ref head, x);
        }

        return head;
    }

    static void HienThi(Node head)
    {
        while (head != null)
        {
            Console.Write(head.Data + " ");
            head = head.Next;
        }

        Console.WriteLine();
    }

    public static void Run()
    {
        Console.WriteLine("Nhap danh sach tang dan!");
        Node a = NhapDanhSach("1");
        Node b = NhapDanhSach("2");

        Console.Write("Danh sach 1: ");
        HienThi(a);

        Console.Write("Danh sach 2: ");
        HienThi(b);

        Node ketQua = GopDanhSach(a, b);

        Console.Write("Danh sach sau khi gop: ");
        HienThi(ketQua);
    }
}