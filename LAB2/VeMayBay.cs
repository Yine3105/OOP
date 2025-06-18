using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TruongThiBaoNhi
{
    class VeMayBay
    {
        public string so_hieu_chuyen_bay;
        public string ten_chuyen_bay;
        public DateTime ngay_bay;
        public double gia_ve;
        public bool cho_ngoi;
        //khong co tham so
        public VeMayBay()
        {
            so_hieu_chuyen_bay = "VN123";
            ten_chuyen_bay = "Nha Trang - Ha Noi";
            ngay_bay = DateTime.Now;
            gia_ve = 500;
            cho_ngoi = false;
        }
        //co tham so
        public VeMayBay(string ten_chuyen_bay, DateTime ngay_bay, double gia_ve, bool cho_ngoi)
        {
            this.ten_chuyen_bay = ten_chuyen_bay;
            this.ngay_bay = ngay_bay;
            this.gia_ve = gia_ve;
            this.cho_ngoi = cho_ngoi;
            gia_ve = 500;
        }
        public void nhap_thong_tin_ve()
        {
            Console.Write("Nhap so hieu chuyen bay: ");
            so_hieu_chuyen_bay = Console.ReadLine();
            Console.Write("Nhap ten chuyen bay: ");
            ten_chuyen_bay = Console.ReadLine();
            Console.Write("Nhap ngay bay: ");
            ngay_bay = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap gia ve: ");
            gia_ve = int.Parse(Console.ReadLine());
            Console.Write("Co chon cho ngoi khong: ");
            cho_ngoi = bool.Parse(Console.ReadLine());
        }
        public double tinh_tien()
        {
            double tong_tien = gia_ve + 350;
            if (cho_ngoi)
            {
                tong_tien += 50;
            }
            return tong_tien;
        }
        public void Show()
        {
            Console.WriteLine("Ten chuyen bay: " + ten_chuyen_bay);
            Console.WriteLine("Ngay bay: " + ngay_bay.ToString("dd/MM/yy"));
            Console.WriteLine("Tong tien: " + tinh_tien());
        }
    }
}
