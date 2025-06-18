using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_TRUONGTHIBAONHI_65132499
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1. Bài 6.1");
                Console.WriteLine("2. Bài 6.2");
                Console.WriteLine("3. Bài 6.3");
                Console.WriteLine("4. Bài 6.4");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhap lua chon cua ban: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\nBai 6.1");
                            bai6_1();
                            break;
                        case 2:
                            Console.WriteLine("\nBai 6.2");
                            bai6_2();
                            break;
                        case 3:
                            Console.WriteLine("\nBai 6.3");
                            bai6_3();
                            break;
                        case 4:
                            Console.WriteLine("\n Bai 6.4");
                            bai6_4();
                            break;
                        case 0:
                            Console.WriteLine("Thoat chuong trinh.");
                            break;
                        default:
                            Console.WriteLine("Lua chon khong hop le. Vui long nhap lai.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Vui long nhap mot so.");
                }
            } while (choice != 0);
        }
        //Bài 6.1
        static void bai6_1()
        {
            DS_XeMay ds = new DS_XeMay();
            ds.NhapDS();
            ds.XuatDS();
            Console.WriteLine($"So luong xe het han bao hanh: {ds.Dem()}");
        }
        //Bài 6.2
        static void bai6_2()
        {
            DS_VeXeBus ds = new DS_VeXeBus();
            ds.NhapDS();
            ds.XuatDS();
            ds.NhapDS();
            ds.XuatDS();
            Console.WriteLine($"So luong ve xe bus co gia ve > 1000 la: {ds.Dem()}");
            ds.Xoa();
            Console.WriteLine("Danh sach ve xe bus sau khi xoa: ");
            ds.XuatDS();
            ds.Them();
            Console.WriteLine("Danh sach ve xe bus sau khi them: ");
            ds.XuatDS();
        }
        //Bài 6.3
        static void bai6_3()
        {
            DS_HCN danhSachHCN = new DS_HCN();
            danhSachHCN.NhapDS();
            danhSachHCN.XuatDS();

            // Sắp xếp giảm dần theo chi phí vẽ
            danhSachHCN.SapXepGiamDan();

            // Xóa hình chữ nhật đầu tiên có diện tích nhỏ hơn x
            Console.Write("\nNhap gia tri x de xoa hinh chu nhat co dien tich nho hon: ");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                danhSachHCN.XoaHCN(x);
                danhSachHCN.XuatDS();
            }
            else
            {
                Console.WriteLine("Gia tri x khong hop le.");
            }

            // Thêm một hình chữ nhật vào vị trí thứ i
            Console.Write("\nNhap vi tri i de them hinh chu nhat: ");
            if (int.TryParse(Console.ReadLine(), out int viTriThem))
            {
                danhSachHCN.ThemHinhChuNhat(viTriThem);
                danhSachHCN.XuatDS();
            }
            else
            {
                Console.WriteLine("Vi tri them khong hop le.");
            }

            // Tính và in ra tổng chi phí vẽ
            double tongChiPhi = danhSachHCN.TinhTongChiPhiVe();
            Console.WriteLine($"\nTong chi phi ve cua cac hinh chu nhat: {tongChiPhi}");

            Console.ReadKey();
        }
        //Bài 6.4
        static void bai6_4()
        {
            QuanLyMayTinh.Show();
        }
    }
}
