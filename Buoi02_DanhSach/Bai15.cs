using System;

class Bai15
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

    static bool CoChuTrinh()
    {
        Node slow = head;
        Node fast = head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast)
                return true;
        }

        return false;
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

        // Tao chu trinh de minh hoa neu danh sach co tu 2 node
        if (head != null && head.Next != null)
        {
            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = head.Next;
        }

        if (CoChuTrinh())
            Console.WriteLine("Danh sach co chu trinh.");
        else
            Console.WriteLine("Danh sach khong co chu trinh.");
    }
}