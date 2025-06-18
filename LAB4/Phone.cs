using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_TRUONGTHIBAONHI_65132499
{
    class Phone
    {
        //khai báo dữ liệu
        public string ma_so;
        public string nhan_hieu;
        public double gia_nhap;
        public int nam_san_xuat;
        //thiết lập
        //khởi tạo không tham số
        public Phone()
        {
            ma_so = "";
            nhan_hieu = "";
            gia_nhap = 0;
            nam_san_xuat = 0;
        }
        //khởi tạo có tham số
        public Phone(string ms, string nh, double gn, int nsx)
        {
            ma_so = ms;
            nhan_hieu = nh;
            gia_nhap = gn;
            nam_san_xuat = nsx;
        }
        //Nhập thông tin điện thoại
        public virtual void Nhap()
        {
            Console.Write("Nhap ma so: ");
            ma_so = Console.ReadLine();
            Console.Write("Nhap nhan hieu: ");
            nhan_hieu = Console.ReadLine();
            Console.Write("Gia nhap: ");
            gia_nhap = double.Parse(Console.ReadLine());
            Console.Write("Nhap nam san xuat: ");
            nam_san_xuat = int.Parse(Console.ReadLine());
        }
        //Xuất thông tin điện thoại
        public virtual void Xuat()
        {
            Console.WriteLine($"Ma so: {ma_so} \bNhan hieu: {nhan_hieu} \bGia nhap: {gia_nhap} \bNam san xuat: {nam_san_xuat}");
        }
        //Tính thuế nhập dựa vào nhãn hiệu và giá nhập
        public double TinhThue()
        {
            if (nhan_hieu == "iphone")
            {
                return 10 / 100 * gia_nhap;
            }
            else
            {
                return 5 / 100 * gia_nhap;
            }
        }
    }
    class SmartPhone : Phone
    {
        // khai báo tham số
        public int dung_luong_bo_nho;
        //thiết lập khởi tạo không tham số
        public SmartPhone() : base()
        {
            dung_luong_bo_nho = 0;
        }
        //khởi tạo có tham số
        public SmartPhone(int dungluong) : base()
        {
            dung_luong_bo_nho = dungluong;
        }
        //Nhập thông tin smartphone
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap dung luong bo nho: ");
            dung_luong_bo_nho = int.Parse(Console.ReadLine());
        }
        //Xuất thông tin smartphone
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Dung luong bo nho: {dung_luong_bo_nho}");
        }
        //Tính giá bán dựa vào dung lượng bộ nhớ
        public double TinhGiaBan()
        {
            double gia_ban = gia_nhap + TinhThue();
            if (dung_luong_bo_nho >= 128)
            {
                gia_ban = gia_ban + 20 / 100 * gia_nhap;
            }
            else if (dung_luong_bo_nho > 16)
            {
                gia_ban = gia_ban + 10 / 100 * gia_nhap;
            }
            else
            {
                gia_ban = gia_ban + 5 /100 * gia_nhap;
            }
            return gia_ban;
        }
    }
}
