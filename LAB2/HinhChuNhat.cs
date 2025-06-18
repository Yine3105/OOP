using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TruongThiBaoNhi
{
    class HinhChuNhat
    {
        public class HCN
        {
            // Thuộc tính
            public int chieu_dai { get; set; }
            public int chieu_rong { get; set; }

            // Constructor mặc định
            public HCN()
            {
                chieu_dai = 0;
                chieu_rong = 0;
            }

            // Constructor có tham số
            public HCN(int chieudai, int chieurong)
            {
                chieu_dai = chieudai;
                chieu_rong = chieurong;
            }

            //Phương thức hiển thị thông tin
            public void GanGiaTri(int chieudai, int chieurong)
            {
                chieu_dai = chieudai;
                chieu_rong = chieurong;
            }
            public void NhapGiaTriHinhChuNhat()
            {
                Console.Write("Nhap chieu dai: ");
                string input_chieudai = Console.ReadLine();
                Console.Write("Nhap chieu rong: ");
                string input_chieurong = Console.ReadLine();
                int chieudai = int.Parse(input_chieudai);
                int chieurong = int.Parse(input_chieurong);
                chieu_dai = chieudai;
                chieu_rong = chieurong;
            }
            public void TinhChuVi()
            {
                int ketqua = (chieu_dai + chieu_rong) / 2;
                Console.WriteLine($"Chu vi cua hinh chu nhat la: {ketqua}");
            }
            public void TinhDienTich()
            {
                int ketqua = chieu_dai * chieu_rong;
                Console.WriteLine($"Dien tich cua hinh chu nhat la: {ketqua}");
            }
            public void Show()
            {
                Console.WriteLine($"Hinh chu nhat co chieu dai {chieu_dai} va chieu rong {chieu_rong}");
            }
            
        }
    }
}
