# Buổi 02 – Danh sách

Họ tên: Huỳnh Thị Thu Hoài · MSV: 10125139

## Bài đã làm

Các bài tập được tổ chức trong một project console C# duy nhất, gồm các file `.cs` tương ứng.

| Bài | File | Nội dung |
|:---:|---|---|
| 1 | `Bai1.cs` | Nhập và hiển thị mảng số nguyên dương; chèn phần tử `x` vào vị trí `k` |
| 2 | `Bai2.cs` | Quản lý danh sách nhân viên: tính tổng thực lĩnh, tìm lương cơ bản thấp nhất, đếm nhân viên có thưởng từ 1.200.000, sắp xếp và tăng lương 5% |
| 3 | `Bai3.cs` | Ma trận vuông: tính tổng phần tử, tìm số dương nhỏ nhất, tính tổng đường chéo phụ và kiểm tra đường chéo chính tăng dần |
| 4 | `Bai4.cs` | Danh sách liên kết đơn: đếm số lần xuất hiện của `x`, tìm số dương nhỏ nhất và xóa lần xuất hiện đầu tiên của `x` |
| 5 | `Bai5.cs` | Danh sách liên kết đơn: tìm phần tử lớn nhất, tính tổng, đếm số nguyên tố, phân loại âm/không/dương, đếm `x` và tìm số dương nhỏ nhất |
| 7 | `Bai7(btth).cs` | Thống kê nhiệt độ trong `n` ngày: cao nhất, thấp nhất, ngày tương ứng và nhiệt độ trung bình |
| 8 | `Bai8(btth).cs` | Chuẩn hóa văn bản, tách từ và thống kê tần suất xuất hiện của từng từ |
| 9 | `Bai9(btth).cs` | Nhập mảng và liệt kê các số nguyên tố, số chẵn, số hoàn hảo |
| 10 | `Bai10.cs` | Nhập ma trận và duyệt/in các phần tử theo đường xoắn ốc |
| 11 | `Bai11.cs` | Kiểm tra ma trận vuông có phải ma trận đơn vị và ma trận đối xứng hay không |
| 12 | `Bai12.cs` | Tạo bảng Minesweeper: đặt mìn ngẫu nhiên và đếm số mìn ở 8 ô lân cận |
| 13 | `Bai13.cs` | Đảo ngược danh sách liên kết đơn |
| 14 | `Bai14.cs` | Gộp hai danh sách liên kết đơn đã được sắp xếp tăng dần |
| 15 | `Bai15.cs` | Kiểm tra danh sách liên kết đơn có chu trình bằng hai con trỏ chậm/nhanh |
| 16 | `Bai16.cs` | Mô phỏng lịch sử duyệt web với thao tác truy cập, Back và Forward bằng danh sách liên kết kép |
| 17 | `Bai17.cs` | Quản lý playlist bằng danh sách liên kết kép: thêm, xóa, Next, Previous và hiển thị |
| 18 | `Bai18.cs` | Quản lý đơn hàng bằng danh sách liên kết kép: thêm, tìm, chuyển trạng thái và hiển thị |

**Lưu ý:** Trong thư mục hiện tại không có file `Bai6.cs`; số thứ tự bài được giữ nguyên theo tên các file đã cung cấp.

## Cách chạy

Cần cài đặt .NET SDK 10.0. Mở terminal tại thư mục chứa project và chạy:

```bash
dotnet run --project Buoi02_DanhSach/Buoi02_DanhSach.csproj
```

Hoặc nếu terminal đang ở ngay trong thư mục `Buoi02_DanhSach`:

```bash
dotnet run
```

Biên dịch project:

```bash
dotnet build Buoi02_DanhSach/Buoi02_DanhSach.csproj
```

## Lưu ý về chương trình khởi chạy

Hiện tại, `Program.cs` gọi `Bai9.Run()`, vì vậy lệnh `dotnet run` sẽ chạy **Bài 9**. Các bài còn lại đang được lưu thành những class riêng trong từng file `.cs`, chưa có menu tổng để lựa chọn bài từ chương trình chính. Một số phương thức `Run()` cũng đang để `private` (mặc định của class), nên cần điều chỉnh quyền truy cập và `Program.cs` nếu muốn gọi trực tiếp các bài đó từ chương trình chính.

Các file `Bai7(btth).cs`, `Bai8(btth).cs`, `Bai9(btth).cs` có dấu hiệu là các bài thực hành thêm (BTTH), được giữ nguyên tên file như trong thư mục gốc.
