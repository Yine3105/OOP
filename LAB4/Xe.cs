using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_TRUONGTHIBAONHI_65132499
{
    abstract class Xe
    {
        //khai báo dữ liệu
        public string ten;
        public string mau_xe;
        public double gia_xe;
        //khởi tạo không tham số
        public Xe()
        {
            ten = "";
            mau_xe = "";
            gia_xe = 0;
        }
        //khởi tạo có tham số
        public Xe(string ten_xe, string mau, double gia_xe)
        {
            ten = ten_xe;
            mau_xe = mau;
            gia_xe = gia_xe;
        }
        //Nhập thông tin xe
        public virtual void Nhap()
        {
            Console.Write("Nhap ten xe: ");
            ten = Console.ReadLine();
            Console.Write("Nhap mau xe: ");
            mau_xe = Console.ReadLine();
            Console.Write("Nhap gia xe: ");
            gia_xe = double.Parse(Console.ReadLine());
        }
        //Tính lệ phí trươc bạ
        public abstract double TinhLePhi();
        //Xuất thông tin 
        public virtual void Xuat()
        {
            Console.WriteLine($"Ten xe: {ten}");
            Console.WriteLine($"Mau xe: {mau_xe}");
            Console.WriteLine($"Gia xe: {gia_xe}");
            Console.WriteLine($"Le phi truoc ba: {TinhLePhi()}");
        }
    }
    abstract class XeMay : Xe
    {
        //khởi tạo tham số
        public bool dang_ky_lan_dau;
        // khởi tạo không tham số
        public XeMay() : base()
        {
            dang_ky_lan_dau = true;
        }
        // khởi tạo có tham số
        public XeMay(bool dang_ky) : base()
        {
            dang_ky_lan_dau = dang_ky;
        }
        //Nhập thông cho xe máy
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Dang ky lan dau dung hay khong (true/false): ");
            dang_ky_lan_dau = bool.Parse(Console.ReadLine());
        }
        //Tính lệ phí trước bạ
        public override double TinhLePhi()
        {
            if (dang_ky_lan_dau)
            {
                return 5 / 100 * gia_xe;
            }
            else
            {
                return 1 / 100 * gia_xe;
            }
        }
    }
    abstract class XeHoi : Xe
    {
        //khai báo tham số
        public int loai_xe;
        // khởi tạo không tham số
        public XeHoi() : base()
        {
            loai_xe = 0;
        }
        //Khởi tạo tham số
        public XeHoi(int loai) : base()
        {
            loai_xe = loai;
        }
        //nhập thông tin cho xe hơi
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap loai xe\n1: xe duoi 9 cho chay xang \n2. xe chay dien,...");
            loai_xe = int.Parse(Console.ReadLine());
        }
        //tính lệ phí trước bạ
        public override double TinhLePhi()
        {
            if(loai_xe == 1)
            {
                return 10 / 100 * gia_xe;
            }
            else if(loai_xe == 2)
            {
                return 0 * gia_xe;
            }
            else
            {
                return 2 / 100 * gia_xe;
            }
        }
    }
}
