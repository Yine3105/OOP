using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_TRUONGTHIBAONHI_65132499
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chon: \n1. Bai 4.1 \n2. Bai 4.2 \n3. Bai 4.3 ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Bai4_1();
                    break;
                case "2":
                    Bai4_2();
                    break;
                case "3":
                    Bai4_3();
                    break;
            }    
        }
        //bài 4.1
        static void Bai4_1()
        {
            Console.WriteLine("Chon: \n1. Phuong trinh bac 1 \n2. Phuong trinh bac 2");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    // Tạo ra một đối tượng PTB1
                    PTB1 ptb1 = new PTB1();
                    Console.WriteLine("--- Nhap du lieu cho phuong trinh bac nhat ---");
                    ptb1.Nhap();
                    ptb1.Xuat();
                    Console.WriteLine("--- Giai phuong trinh bac nhat ---");
                    ptb1.Giai();
                    Console.WriteLine();
                    break;
                case "2":
                    // Tạo ra một đối tượng PTB2
                    PTB2 ptb2 = new PTB2();
                    Console.WriteLine("--- Nhap du lieu cho phuong trinh bac hai ---");
                    ptb2.Nhap();
                    ptb2.Xuat();
                    Console.WriteLine("--- Giai phuong trinh bac hai ---");
                    ptb2.Giai();
                    break;
            }
        }
        //bài 4.2
        static void Bai4_2()
        {
            Console.Write("Nhap so luong SmartPhone: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 30)
            {
                Console.WriteLine("Nhap lai: ");
            }

            List<SmartPhone> danhSachSmartPhone = new List<SmartPhone>();
            Console.WriteLine("\nNhap thong tin smartphone:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap thong tin smartphone {i + 1}:");
                SmartPhone smartPhone = new SmartPhone();
                smartPhone.Nhap();
                danhSachSmartPhone.Add(smartPhone);
            }

            // Sắp xếp danh sách SmartPhone theo chiều giảm dần của giá nhập
            danhSachSmartPhone = danhSachSmartPhone.OrderByDescending(sp => sp.gia_nhap).ToList();

            Console.WriteLine("\nDanh sach smartphone giam dan:");
            foreach (var smartPhone in danhSachSmartPhone)
            {
                smartPhone.Xuat();
                Console.WriteLine("---");
            }

            // Đếm và in ra số lượng SmartPhone có năm sản xuất bằng x
            Console.Write("\nNhap nam san xuat x de dem: ");
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Nhap lai: ");
            }

            int count = danhSachSmartPhone.Count(sp => sp.nam_san_xuat == x);
            Console.WriteLine($"\nSo luong smart phone trong nam {x} la: {count}");
        }
        //bài 4.3
        static void Bai4_3()
        {
            Console.Write("Nhap so luong hinh: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 20)
            {
                Console.WriteLine("Nhap lai (2 <= n <= 20): ");
            }

            List<Shape> danhSachHinh = new List<Shape>();
            Console.WriteLine("\nNhap thong tin hinh:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap thong tin hinh thu {i + 1}:");
                Console.WriteLine("Chon (1: Tam giac, 2: Hinh chu nhat): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Nhap canh a: ");
                        double canhA = double.Parse(Console.ReadLine());
                        Console.Write("Nhap canh b: ");
                        double canhB = double.Parse(Console.ReadLine());
                        Console.Write("Nhap canh c: ");
                        double canhC = double.Parse(Console.ReadLine());
                        danhSachHinh.Add(new Triangle(canhA, canhB, canhC));
                        break;
                    case "2":
                        Console.Write("Nhap chieu dai: ");
                        double chieuDai = double.Parse(Console.ReadLine());
                        Console.Write("Nhap chieu rong: ");
                        double chieuRong = double.Parse(Console.ReadLine());
                        danhSachHinh.Add(new Rectangle(chieuDai, chieuRong));
                        break;
                    default:
                        Console.WriteLine("Loi.");
                        i--; // Giảm i để nhập lại hình hiện tại
                        break;
                }
            }

            Console.WriteLine("\nThong tin hinh vua nhap:");
            foreach (var hinh in danhSachHinh)
            {
                hinh.InThongTinHinh();
                Console.WriteLine("---");
            }

            // Tính và in ra diện tích trung bình của các hình chữ nhật
            double tongDienTichHCN = 0;
            int soLuongHCN = 0;
            foreach (var hinh in danhSachHinh)
            {
                if (hinh is Rectangle)
                {
                    tongDienTichHCN += hinh.DienTich();
                    soLuongHCN++;
                }
            }

            if (soLuongHCN > 0)
            {
                double dienTichTrungBinhHCN = tongDienTichHCN / soLuongHCN;
                Console.WriteLine($"\nDien tich trung binh cua hinh chu nhat: {dienTichTrungBinhHCN:N2}");
            }
            else
            {
                Console.WriteLine("\nKhong co hcn nao.");
            }
        }
        //bài 4.5
        static void Bai4_5()
        {

        }
    }
}
