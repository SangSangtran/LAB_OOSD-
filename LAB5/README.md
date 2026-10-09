# LAB 5: Quan Ly Cong Ty Du Lich
**Ho va ten:** Tran Nguyen Tuan Sang
**Mon hoc:** OOSD



## Cấu trúc thư mục
- **Docs/**: Chứa file báo cáo (.docx) và các hình ảnh sơ đồ UML (Use Case, Activity, Sequence, Class, ERD).
- **Source/**: Chứa mã nguồn ứng dụng (Form UI và code kết nối Database).
- **Database/**: Chứa file script tạo CSDL.

## Hướng dẫn cài đặt và chạy
1. Clone repository này về máy.
2. Mở script SQL trong thư mục `Database` và execute để tạo CSDL (Ví dụ: SQL Server LocalDB).
3. Mở project trong thư mục `Source` bằng IDE (Ví dụ: Visual Studio 2022).
4. Cập nhật lại chuỗi kết nối (Connection String) cho phù hợp với môi trường máy cá nhân.
5. Build và Run ứng dụng.

## Kien truc thu muc


```text
LAB5/
├── Docs/                      # Tài liệu phân tích thiết kế
│   ├── Bao_cao_Do_an.docx     # File báo cáo chính thức
│   └── UML_Diagrams/          # Chứa các hình ảnh sơ đồ UML
├── Database/                  # Lưu trữ Cơ sở dữ liệu
│   └── CreateDB.sql           # Script SQL Server tạo bảng và dữ liệu mẫu
├── Source/                    # Mã nguồn ứng dụng (C# WinForms Visual Studio 2022)
│   └── QuanLyDuLich/
│       ├── QuanLyDuLich.sln   # File Solution của dự án
│       ├── Forms/             # Chứa các giao diện UI (Kéo thả)
│       │   ├── frmMain.cs
│       │   ├── frmDangKyTour.cs
│       │   └── frmPhanCong.cs
│       ├── Models/            # Chứa các Class thực thể 
│       └── Utils/             # Chứa class kết nối CSDL (Connection Database)
└── README.md                  # File thông tin dự án