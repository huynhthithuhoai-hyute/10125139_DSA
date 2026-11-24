using System;

class Bai13
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

    static Node head = null;

    static void ThemCuoi(int x)
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

    static void DaoNguoc()
    {
        Node previous = null;
        Node current = head;
        Node next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }

        head = previous;
    }

    static void HienThi()
    {
        Node temp = head;

        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }

        Console.WriteLine();
    }

    public static void Run()
    {
        Console.Write("Nhap so luong node: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap node thu {i + 1}: ");
            int x = int.Parse(Console.ReadLine());
            ThemCuoi(x);
        }

        Console.Write("Danh sach ban dau: ");
        HienThi();

        DaoNguoc();

        Console.Write("Danh sach sau khi dao nguoc: ");
        HienThi();
    }
}