# Buổi 01 – Đệ quy

Họ tên: Nguyễn Trọng Tâm · MSV: 10125280

## Bài đã làm

Mỗi bài là một project console C# riêng, nằm trong thư mục tương ứng. Tất cả đều giải bằng **đệ quy**.

| Bài | Thư mục | Nội dung |
|:---:|---|---|
| 1 | `b1` | S(n) = 1 + 2 + 3 + … + n |
| 2 | `b2` | S(n) = 1 + 2² + 3² + … + n² |
| 3 | `b3` | S(n) = 1 + 1/2 + 1/3 + … + 1/n |
| 4 | `b4` | S(x, n) = xⁿ (n có thể âm) |
| 5 | `b5` | Ước lẻ lớn nhất của n |
| 6 | `b6` | Ước chung lớn nhất UCLN(a, b) |
| 7 | `b7` | Đếm số chữ số của n |
| 8 | `b8` | S(n) = √(1 + √(2 + … + √n)) |

## Cách chạy

Chạy từ thư mục gốc của repo (cần cài .NET SDK 10.0). Thay `b1` bằng thư mục của bài cần chạy:

```
dotnet run --project Buoi01_DeQuy/b1
dotnet run --project Buoi01_DeQuy/b2
dotnet run --project Buoi01_DeQuy/b3
dotnet run --project Buoi01_DeQuy/b4
dotnet run --project Buoi01_DeQuy/b5
dotnet run --project Buoi01_DeQuy/b6
dotnet run --project Buoi01_DeQuy/b7
dotnet run --project Buoi01_DeQuy/b8
```

Biên dịch toàn bộ 8 bài cùng lúc:

```
dotnet build Buoi01_DeQuy/Buoi01_DeQuy.slnx
```

## Kết quả chạy

**Bài 1** – nhập n = 10:

```
Nhap n: 10
Tong S(n) = 55
```

**Bài 2** – nhập n = 10:

```
Nhap n: 10
Tong S(n) = 385
```

**Bài 3** – nhập n = 10:

```
Nhap n: 10
Tong S(n) = 2.9289682539682538
```

**Bài 4** – nhập x = 2, n = 10, và x = 2, n = −3:

```
Nhap x: 2
Nhap n: 10
Ket qua S(x,n) = 1024
```

```
Nhap x: 2
Nhap n: -3
Ket qua S(x,n) = 0.125
```

**Bài 5** – nhập n = 100:

```
Nhap n: 100
Uoc le lon nhat: 25
```

**Bài 6** – nhập a = 48, b = 18:

```
Nhap a: 48
Nhap b: 18
UCLN = 6
```

**Bài 7** – nhập n = 12345:

```
Nhap n: 12345
So chu so = 5
```

**Bài 8** – nhập n = 10:

```
Nhap n: 10
Ket qua S(n) = 1.757932611393831
```
