# Buổi 03 – Ngăn xếp và Hàng đợi (Stack & Queue)

Họ tên: Huỳnh Thị Thu Hoài · MSV: 10125139

## Bài đã làm

Các bài tập được viết bằng C# Console, sử dụng cấu trúc dữ liệu **Stack (ngăn xếp)** và **Queue (hàng đợi)** trong thư viện `System.Collections.Generic`.

| Bài | Nội dung | Cấu trúc dữ liệu |
|:---:|---|---|
| 1 | Kiểm tra tính hợp lệ của biểu thức toán học với các dấu ngoặc `()`, `[]`, `{}` | Stack |
| 2 | Mô phỏng lịch sử trình duyệt web: truy cập, Back, Forward | Hai Stack |
| 3 | Mô phỏng Function Call Stack – quản lý thứ tự gọi và kết thúc hàm | Stack |
| 4 | Mô phỏng hệ thống in ấn, xử lý tài liệu theo thứ tự đến trước – phục vụ trước | Queue |
| 5 | Mô phỏng đường truyền dữ liệu, gửi và nhận các gói tin | Queue |
| 6 | Quản lý hàng đợi khách hàng tại ngân hàng | Queue |

## Cách chạy

Cần cài đặt .NET SDK 10.0. Chạy lệnh từ thư mục gốc của repository:

```bash
dotnet run --project Buoi03_Stack_Queue/Buoi03_Stack_Queue
```

Hoặc mở file `Buoi03_Stack_Queue.slnx` bằng Visual Studio và chạy project `Buoi03_Stack_Queue`.

## Cách sử dụng chương trình

Sau khi chạy, chương trình hiển thị menu gồm 6 bài tập. Nhập số tương ứng để chạy bài muốn xem:

- Nhập `1` đến `6`: chạy bài tập tương ứng.
- Nhập `0`: thoát chương trình.

Sau khi một bài hoàn thành, menu được hiển thị lại để chọn bài khác.

## Kết quả chạy

**Bài 1 – Kiểm tra biểu thức**

Ví dụ nhập biểu thức `{[a+b]*(c-d)}`:

```text
Nhập biểu thức cần kiểm tra: {[a+b]*(c-d)}
=> Kết quả: Biểu thức HỢP LỆ.
```

**Bài 2 – Mô phỏng lịch sử trình duyệt web**

Chương trình lần lượt truy cập `youtube.com`, `github.com`, `utehy.edu.vn`, thực hiện Back/Forward và truy cập nhánh mới `vnexpress.net`. Khi truy cập nhánh mới, lịch sử Forward được xóa.

**Bài 3 – Mô phỏng Function Call Stack**

Thứ tự gọi hàm là `Main` → `TinhDiemTrungBinh` → `LamTronSo`. Khi trả về, các hàm kết thúc theo thứ tự ngược lại: `LamTronSo` → `TinhDiemTrungBinh` → `Main`.

**Bài 4 – Mô phỏng hệ thống in ấn**

Ba tài liệu được đưa vào hàng đợi và xử lý theo đúng thứ tự đã thêm vào (FIFO).

**Bài 5 – Mô phỏng đường truyền dữ liệu**

Bốn gói tin có mã từ `101` đến `104` được nhận và xử lý theo thứ tự gửi.

**Bài 6 – Quản lý hàng đợi tại ngân hàng**

Ba khách hàng lấy số thứ tự lần lượt là `1`, `2`, `3` và được mời đến quầy theo thứ tự đó.

## Kiến thức áp dụng

- **Stack (LIFO – Last In, First Out):** phần tử được thêm vào sau cùng sẽ được lấy ra trước. Các thao tác chính: `Push()`, `Pop()`, `Peek()` và `Count`.
- **Queue (FIFO – First In, First Out):** phần tử được thêm vào trước sẽ được lấy ra trước. Các thao tác chính: `Enqueue()`, `Dequeue()`, `Peek()` và `Count`.
