using System;
using static Lab2_TruongThiBaoNhi.TimeCaculation;

namespace Lab2_TruongThiBaoNhi
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
            string choice = GetUserChoice();
            Run(choice);
        }
        static void DisplayMenu()
        {
            Console.WriteLine("Chon");
            Console.WriteLine("1. Bai 2.1 (Time Calculation)");
            Console.WriteLine("2. Bai 2.2 (HinhChuNhat)");
            Console.WriteLine("3. Bai 2.3 (Chuoi)");
            Console.WriteLine("4. Bai 2.4 (PhanSo)");
            Console.WriteLine("5. Bai 2.5 (Diem)");
            Console.WriteLine("6. Bai 2.6 (VeMayBay)");
            Console.WriteLine("7. Bai 2.7 (Adult)");
            Console.WriteLine("8. Bai 2.8 (BaiToan)");
            Console.WriteLine("9. Thoat");
        }
        static string GetUserChoice()
        {
            return Console.ReadLine();
        }
        static void Run(string choice)
        {
            switch (choice)
            {
                case "1": Bai2_1(); break;
                case "2": Bai2_2(); break;
                case "3": Bai2_3(); break;
                case "4": Bai2_4(); break;
                case "5": Bai2_5(); break;
                case "6": Bai2_6(); break;
                case "7": Bai2_7(); break;
                case "8": Bai2_8(); break;
                case "9": return;
                default: Console.WriteLine("Sai bai."); break;
            }
        }
        static void Bai2_1()
        {
            Time time_1 = new Time();
            Time time_2 = new Time(1, 0, 0);
            time_1.SetHour(1);
            time_2.SetHour(2);
            time_1.Show();
            time_2.Show();
            int time1_second_count = time_1.Second_Count();
            int time2_second_count = time_2.Second_Count();
            int result = time1_second_count - time2_second_count;
            if (result < 0)
            {
                Console.WriteLine($"time 1 < time 2 {Math.Abs(result)} seconds!");
            }
            else if (result == 0)
            {
                Console.WriteLine("0 second!");
            }
            else
            {
                Console.WriteLine($"time 1 > time 2 {result} seconds");
            }
        }
        static void Bai2_2()
        {
            HinhChuNhat.HCN hinh_Chu_Nhat_1 = new HinhChuNhat.HCN();
            hinh_Chu_Nhat_1.TinhChuVi();
            hinh_Chu_Nhat_1.TinhDienTich();
            hinh_Chu_Nhat_1.Show();
            Console.WriteLine("\b");
            HinhChuNhat.HCN hinh_Chu_Nhat_2 = new HinhChuNhat.HCN(10, 5);
            hinh_Chu_Nhat_2.TinhChuVi();
            hinh_Chu_Nhat_2.TinhDienTich();
            hinh_Chu_Nhat_2.Show();
            Console.WriteLine("\b");
            HinhChuNhat.HCN hinh_Chu_Nhat_3 = new HinhChuNhat.HCN();
            hinh_Chu_Nhat_3.NhapGiaTriHinhChuNhat();
            hinh_Chu_Nhat_3.TinhChuVi();
            hinh_Chu_Nhat_3.TinhDienTich();
            hinh_Chu_Nhat_3.Show();

        }
        static void Bai2_3()
        {
            Chuoi mover = new Chuoi("  a   ", 10, 5, ConsoleColor.Blue, ConsoleColor.Yellow);
            mover.Move();

        }
        static void Bai2_4()
        {
            PhanSo phanSo1 = new PhanSo();
            phanSo1.Show();
            PhanSo phanSo2 = new PhanSo(2, 5);
            phanSo2.Show();
            PhanSo phanSo3 = new PhanSo(3, 6);
            phanSo3.Show();
            phanSo3.TinhToan(phanSo2, phanSo3, "Cong");
            phanSo3.TinhToan(phanSo2, phanSo3, "Tru");
            phanSo3.TinhToan(phanSo2, phanSo3, "Nhan");
            phanSo3.TinhToan(phanSo2, phanSo3, "Chia");

        }
        static void Bai2_5()
        {
            Diem diem1 = new Diem();
            diem1.Show();
            Diem diem2 = new Diem(3, 5);
            diem2.Show();
            Diem diem3 = new Diem(4, 2);
            diem3.Show();
            double khoangCach = diem3.tinh_khoang_cach(diem2);
            Console.WriteLine($"Khoang cach: {khoangCach}");

        }
        static void Bai2_6()
        {
            VeMayBay veMayBay1 = new VeMayBay();
            veMayBay1.Show();
            Console.WriteLine("\b");
            VeMayBay veMayBay2 = new VeMayBay("Ha Noi - TPHCM", new DateTime(2025, 3, 8), 800, true);
            veMayBay2.Show();
            Console.WriteLine("\b");
            VeMayBay veMayBay3 = new VeMayBay();
            veMayBay3.nhap_thong_tin_ve();
            veMayBay3.Show();
            Console.WriteLine("\b");
            VeMayBay giaVeCaoNhat = veMayBay3.gia_ve > veMayBay2.gia_ve ? veMayBay3 : veMayBay2;
            Console.WriteLine("Thong tin ve co gia cao nhat: ");
            giaVeCaoNhat.Show();
        }
        static void Bai2_7()
        {
            Adult adult = new Adult();
            adult.Information();
            adult.Show();
        }
        static void Bai2_8()
        {
            //a
            BaiToan pt1 = new BaiToan();
            pt1.Xuat();
            //kq 0 + 0 = 0

            //b
            BaiToan pt2 = new BaiToan();
            pt2.CapNhat();//giả sử nhập a=7, b=8, c=+
            pt2.Xuat();
            //kq 7 + 8 = 15

            //c
            BaiToan pt3 = new BaiToan(3, 6, '+');
            pt3.Xuat();
            //kq 3 + 6 = 9

            //d
            BaiToan pt4 = new BaiToan(3, 6, '+');
            pt4.CapNhat();//giả sử nhập a=7, b=8, c=+
            pt4.Xuat();
            //kq 7 + 8 = 15

        }
    }
}