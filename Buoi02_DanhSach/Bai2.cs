
using System;

class Bai2
{
    // Cau truc luu thong tin nhan vien
    struct NhanVien
    {
        public string MaNV;
        public string HoTen;
        public int NamSinh;
        public string PhongBan;
        public int LuongCB;
        public int Thuong;
    }

    static NhanVien[] DS;
    static int n;

    // Tinh thuc linh cua mot nhan vien
    static int ThucLinh(int i)
    {
        return DS[i].LuongCB + DS[i].Thuong;
    }

    // Nhap danh sach nhan vien
    static void NhapDanhSach()
    {
        Console.Write("Nhap so luong nhan vien: ");
        n = int.Parse(Console.ReadLine());

        DS = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhan vien thu {i + 1}:");

            Console.Write("Ma nhan vien: ");
            DS[i].MaNV = Console.ReadLine();

            Console.Write("Ho ten: ");
            DS[i].HoTen = Console.ReadLine();

            Console.Write("Nam sinh: ");
            DS[i].NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Phong ban: ");
            DS[i].PhongBan = Console.ReadLine();

            Console.Write("Luong co ban: ");
            DS[i].LuongCB = int.Parse(Console.ReadLine());

            Console.Write("Thuong: ");
            DS[i].Thuong = int.Parse(Console.ReadLine());
        }
    }

    // In thong tin mot nhan vien
    static void InNhanVien(NhanVien nv)
    {
        Console.WriteLine(
            $"{nv.MaNV,-12} {nv.HoTen,-20} {nv.NamSinh,-10} " +
            $"{nv.PhongBan,-15} {nv.LuongCB,-15} {nv.Thuong,-12} " +
            $"{nv.LuongCB + nv.Thuong}"
        );
    }

    // In toan bo danh sach
    static void InDanhSach()
    {
        Console.WriteLine(
            "\nMa NV       Ho ten              Nam sinh  Phong ban      " +
            "Luong CB       Thuong       Thuc linh"
        );

        for (int i = 0; i < n; i++)
        {
            InNhanVien(DS[i]);
        }
    }

    // a. Tinh tong thuc linh
    static void TinhTongThucLinh()
    {
        long tong = 0;

        for (int i = 0; i < n; i++)
        {
            tong += ThucLinh(i);
        }

        Console.WriteLine("\nTong thuc linh: " + tong);
    }

    // b. Tim nhan vien co luong co ban thap nhat
    static void TimLuongThapNhat()
    {
        if (n == 0)
        {
            Console.WriteLine("Danh sach rong!");
            return;
        }

        int min = DS[0].LuongCB;

        // Tim muc luong co ban nho nhat
        for (int i = 1; i < n; i++)
        {
            if (DS[i].LuongCB < min)
            {
                min = DS[i].LuongCB;
            }
        }

        Console.WriteLine("\nNhan vien co luong co ban thap nhat:");

        // In tat ca nhan vien co muc luong bang min
        for (int i = 0; i < n; i++)
        {
            if (DS[i].LuongCB == min)
            {
                InNhanVien(DS[i]);
            }
        }
    }

    // c. Dem nhan vien co thuong >= 1200000
    static void DemNhanVienThuongCao()
    {
        int dem = 0;

        for (int i = 0; i < n; i++)
        {
            if (DS[i].Thuong >= 1200000)
            {
                dem++;
            }
        }

        Console.WriteLine(
            "\nSo nhan vien co thuong >= 1200000: " + dem
        );
    }

    // d. Sap xep tang dan theo phong ban,
    // neu trung phong ban thi giam dan theo ma nhan vien
    static void SapXep()
    {
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int kq = string.Compare(
                    DS[i].PhongBan,
                    DS[j].PhongBan,
                    StringComparison.OrdinalIgnoreCase
                );

                bool doiCho = false;

                if (kq > 0)
                {
                    doiCho = true;
                }
                else if (kq == 0 &&
                    string.Compare(
                        DS[i].MaNV,
                        DS[j].MaNV,
                        StringComparison.OrdinalIgnoreCase
                    ) < 0)
                {
                    doiCho = true;
                }

                if (doiCho)
                {
                    NhanVien temp = DS[i];
                    DS[i] = DS[j];
                    DS[j] = temp;
                }
            }
        }

        Console.WriteLine("\nDanh sach sau khi sap xep:");
        InDanhSach();
    }

    // e. Tang luong co ban len 5%
    static void TangLuong()
    {
        for (int i = 0; i < n; i++)
        {
            DS[i].LuongCB = (int)Math.Round(
                DS[i].LuongCB * 1.05,
                MidpointRounding.AwayFromZero
            );
        }

        Console.WriteLine("\nDa tang luong co ban len 5%.");
        InDanhSach();
    }

    // Ham chay Bai 2
    public static void Run()
    {
        NhapDanhSach();

        int chon;

        do
        {
            Console.WriteLine("\n========== MENU BAI 2 ==========");
            Console.WriteLine("1. In danh sach nhan vien");
            Console.WriteLine("2. Tinh tong thuc linh");
            Console.WriteLine("3. Tim nhan vien luong thap nhat");
            Console.WriteLine("4. Dem nhan vien co thuong >= 1200000");
            Console.WriteLine("5. Sap xep danh sach");
            Console.WriteLine("6. Tang luong 5%");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");

            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    InDanhSach();
                    break;

                case 2:
                    TinhTongThucLinh();
                    break;

                case 3:
                    TimLuongThapNhat();
                    break;

                case 4:
                    DemNhanVienThuongCao();
                    break;

                case 5:
                    SapXep();
                    break;

                case 6:
                    TangLuong();
                    break;

                case 0:
                    Console.WriteLine("Ket thuc Bai 2!");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

        } while (chon != 0);
    }
}
