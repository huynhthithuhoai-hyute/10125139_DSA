using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Stack_Queue
{

    // BÀI 1: kiểm tra hợp lệ biểu thức toán học (dùng Stack)

    public class Bai1
    {
        private bool KiemTraHopLe(string bieuThuc)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in bieuThuc)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0) return false;

                    char dinh = stack.Pop();
                    if ((c == ')' && dinh != '(') ||
                        (c == ']' && dinh != '[') ||
                        (c == '}' && dinh != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        public void Run()
        {
            Console.WriteLine("\n--- BÀI 1: KIỂM TRA BIỂU THỨC TOÁN HỌC ---");
            Console.Write("Nhập biểu thức cần kiểm tra: ");
            string input = Console.ReadLine();

            bool ketQua = KiemTraHopLe(input);
            Console.WriteLine(ketQua
                ? "=> Kết quả: Biểu thức HỢP LỆ."
                : "=> Kết quả: Biểu thức KHÔNG HỢP LỆ.");
        }
    }

    
    // BÀI 2: MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT WEB
    
    public class Bai2
    {
        private Stack<string> backStack = new Stack<string>();
        private Stack<string> forwardStack = new Stack<string>();
        private string currentPage = "google.com";

        private void TruyCap(string url)
        {
            backStack.Push(currentPage);
            currentPage = url;
            forwardStack.Clear();
            Console.WriteLine($"[Truy cập] Trang hiện tại: {currentPage}");
        }

        private void Back()
        {
            if (backStack.Count == 0)
            {
                Console.WriteLine("[Back] Không có trang trước đó!");
                return;
            }
            forwardStack.Push(currentPage);
            currentPage = backStack.Pop();
            Console.WriteLine($"[Back] Trang hiện tại: {currentPage}");
        }

        private void Forward()
        {
            if (forwardStack.Count == 0)
            {
                Console.WriteLine("[Forward] Không có trang tiếp theo!");
                return;
            }
            backStack.Push(currentPage);
            currentPage = forwardStack.Pop();
            Console.WriteLine($"[Forward] Trang hiện tại: {currentPage}");
        }

        public void Run()
        {
            Console.WriteLine("\n--- BÀI 2: MÔ PHỎNG TRÌNH DUYỆT WEB ---");
            Console.WriteLine($"Trang mặc định ban đầu: {currentPage}");

            TruyCap("youtube.com");
            TruyCap("github.com");
            TruyCap("utehy.edu.vn");
            Back();     // Về github.com
            Back();     // Về youtube.com
            Forward();  // Lên github.com
            TruyCap("vnexpress.net"); // Rẽ nhánh mới -> Xóa Forward
            Forward();  // Báo không có trang tiếp theo
        }
    }

   
    // BÀI 3: MÔ PHỎNG FUNCTION CALL STACK
   
    public class Bai3
    {
        private class StackFrame
        {
            public string TenHam { get; set; }
            public string ThamSo { get; set; }

            public StackFrame(string tenHam, string thamSo)
            {
                TenHam = tenHam;
                ThamSo = thamSo;
            }
        }

        private Stack<StackFrame> callStack = new Stack<StackFrame>();

        private void CallFunction(string tenHam, string thamSo)
        {
            callStack.Push(new StackFrame(tenHam, thamSo));
            Console.WriteLine($"--> Gọi hàm: {tenHam}({thamSo}) | Đang ở đỉnh Stack");
        }

        private void ReturnFunction()
        {
            if (callStack.Count > 0)
            {
                StackFrame frame = callStack.Pop();
                Console.WriteLine($"<-- Kết thúc hàm: {frame.TenHam}({frame.ThamSo})");
            }
        }

        public void Run()
        {
            Console.WriteLine("\n--- BÀI 3: MÔ PHỎNG FUNCTION CALL STACK ---");
            CallFunction("Main", "");
            CallFunction("TinhDiemTrungBinh", "toan=8, van=9");
            CallFunction("LamTronSo", "diem=8.5");

            Console.WriteLine("--- Bắt đầu trả về từ các hàm ---");
            ReturnFunction(); // LamTronSo kết thúc trước
            ReturnFunction(); // TinhDiemTrungBinh kết thúc sau
            ReturnFunction(); // Main kết thúc cuối cùng
        }
    }

   
    // BÀI 4: MÔ PHỎNG HỆ THỐNG IN ẤN
   
    public class Bai4
    {
        public void Run()
        {
            Console.WriteLine("\n--- BÀI 4: MÔ PHỎNG HỆ THỐNG IN ẤN (FIFO) ---");
            Queue<string> hangDoiIn = new Queue<string>();

            // Thêm các lệnh in vào hàng đợi
            hangDoiIn.Enqueue("1. BaoCaoThucTap.pdf");
            hangDoiIn.Enqueue("2. DeCuongOnTap_DSA.docx");
            hangDoiIn.Enqueue("3. DanhSachSinhVien.xlsx");

            Console.WriteLine($"Tổng số tài liệu đang chờ trong hàng đợi: {hangDoiIn.Count}");

            while (hangDoiIn.Count > 0)
            {
                string taiLieu = hangDoiIn.Dequeue();
                Console.WriteLine($"Đang in tài liệu: {taiLieu} -> Hoàn thành!");
            }
        }
    }

   
    // BÀI 5: MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU
    
    public class Bai5
    {
        private class GoiTin
        {
            public int MaGoi { get; set; }
            public string DuLieu { get; set; }

            public GoiTin(int maGoi, string duLieu)
            {
                MaGoi = maGoi;
                DuLieu = duLieu;
            }
        }

        public void Run()
        {
            Console.WriteLine("\n--- BÀI 5: MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU ---");
            Queue<GoiTin> bufferMang = new Queue<GoiTin>();

            // Gửi gói tin vào 
            bufferMang.Enqueue(new GoiTin(101, "Gói tin khởi tạo kết nối (SYN)"));
            bufferMang.Enqueue(new GoiTin(102, "Dữ liệu hình ảnh phần 1"));
            bufferMang.Enqueue(new GoiTin(103, "Dữ liệu hình ảnh phần 2"));
            bufferMang.Enqueue(new GoiTin(104, "Gói tin kết thúc (FIN)"));

            // Bên nhận lấy gói tin ra xử lý 
            while (bufferMang.Count > 0)
            {
                GoiTin pkt = bufferMang.Dequeue();
                Console.WriteLine($"[Đã nhận] Mã #{pkt.MaGoi} - Nội dung: {pkt.DuLieu}");
            }
        }
    }

    
    // BÀI 6: QUẢN LÝ HÀNG ĐỢI TẠI NGÂN HÀNG
    
    public class Bai6
    {
        private class KhachHang
        {
            public int STT { get; set; }
            public string HoTen { get; set; }
            public string DichVu { get; set; }

            public KhachHang(int stt, string hoTen, string dichVu)
            {
                STT = stt;
                HoTen = hoTen;
                DichVu = dichVu;
            }
        }

        public void Run()
        {
            Console.WriteLine("\n--- BÀI 6: QUẢN LÝ HÀNG ĐỢI NGÂN HÀNG ---");
            Queue<KhachHang> hangDoiKH = new Queue<KhachHang>();

            // Khách lấy số thứ tự
            hangDoiKH.Enqueue(new KhachHang(1, "Nguyễn Văn An", "Nộp tiền mặt"));
            hangDoiKH.Enqueue(new KhachHang(2, "Trần Thị Bình", "Mở thẻ ATM"));
            hangDoiKH.Enqueue(new KhachHang(3, "Lê Hoàng Cường", "Tư vấn vay vốn"));

            while (hangDoiKH.Count > 0)
            {
                KhachHang kh = hangDoiKH.Dequeue();
                Console.WriteLine($"Mời khách hàng STT {kh.STT} ({kh.HoTen}) đến quầy giao dịch: {kh.DichVu}");
            }
            Console.WriteLine("Hàng đợi trống. Tất cả khách hàng đã được phục vụ!");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                
                Console.WriteLine("1. Bài 1: Kiểm tra tính đúng đắn biểu thức");
                Console.WriteLine("2. Bài 2: Mô phỏng lịch sử trình duyệt web");
                Console.WriteLine("3. Bài 3: Mô phỏng Function Call Stack");
                Console.WriteLine("4. Bài 4: Mô phỏng hệ thống in ấn");
                Console.WriteLine("5. Bài 5: Mô phỏng đường truyền dữ liệu");
                Console.WriteLine("6. Bài 6: Quản lý hàng đợi ngân hàng / CSKH");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("=> Chọn bài tập muốn chạy : ");

                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        new Bai1().Run();
                        break;
                    case "2":
                        new Bai2().Run();
                        break;
                    case "3":
                        new Bai3().Run();
                        break;
                    case "4":
                        new Bai4().Run();
                        break;
                    case "5":
                        new Bai5().Run();
                        break;
                    case "6":
                        new Bai6().Run();
                        break;
                    case "0":
                        Console.WriteLine("Đã thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập từ 0 đến 6!");
                        break;
                }
            }
        }
    }
}