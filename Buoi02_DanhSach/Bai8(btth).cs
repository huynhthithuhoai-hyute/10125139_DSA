
using System;
using System.Collections.Generic;
using System.Text;

class Bai8
{
    // 1. Chuẩn hóa chuỗi:
    // Chuyển chữ thường và loại bỏ ký tự đặc biệt
    static string ChuanHoaChuoi(string s)
    {
        s = s.ToLowerInvariant();

        StringBuilder sb = new StringBuilder();

        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                sb.Append(c);
            }
            else
            {
                // Thay ký tự không phải chữ bằng khoảng trắng
                sb.Append(' ');
            }
        }

        return sb.ToString();
    }

    // 2. Tách chuỗi thành các từ
    static string[] TachTu(string s)
    {
        return s.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );
    }

    // 3. Đếm số lần xuất hiện của mỗi từ
    static Dictionary<string, int> DemTanSuat(string[] danhSachTu)
    {
        Dictionary<string, int> tuDien =
            new Dictionary<string, int>();

        foreach (string tu in danhSachTu)
        {
            if (tuDien.ContainsKey(tu))
            {
                tuDien[tu]++;
            }
            else
            {
                tuDien.Add(tu, 1);
            }
        }

        return tuDien;
    }

    // 4. Sắp xếp và hiển thị kết quả
    static void HienThiKetQua(Dictionary<string, int> tuDien)
    {
        List<string> danhSachTu =
            new List<string>(tuDien.Keys);

        danhSachTu.Sort(StringComparer.Ordinal);

        Console.WriteLine("\nTHONG KE TAN SUAT CAC TU");
        Console.WriteLine("-------------------------");

        foreach (string tu in danhSachTu)
        {
            Console.WriteLine("{0}: {1} lan",
                tu, tuDien[tu]);
        }
    }

    // Chương trình chính
    public static void Run()
    {
        Console.Write("Nhap chuoi van ban: ");
        string s = Console.ReadLine();

        // Kiểm tra chuỗi rỗng
        if (string.IsNullOrWhiteSpace(s))
        {
            Console.WriteLine("Chuoi khong co noi dung!");
            return;
        }

        // Bước 1: Chuẩn hóa
        string chuoiChuanHoa = ChuanHoaChuoi(s);

        // Bước 2: Tách thành các từ
        string[] danhSachTu = TachTu(chuoiChuanHoa);

        // Bước 3: Đếm tần suất
        Dictionary<string, int> tuDien =
            DemTanSuat(danhSachTu);

        // Bước 4: Hiển thị kết quả
        HienThiKetQua(tuDien);
    }
}
