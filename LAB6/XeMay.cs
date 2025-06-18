using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_TRUONGTHIBAONHI_65132499
{
    internal abstract class XeMay
    {
        //khai báo thuộc tính
        protected string bien_so;
        protected int nam_dang_ky;
        //khởi tạo không tham số
        public XeMay()
        {
            bien_so = "";
            nam_dang_ky = 0;
        }
        //khởi tạo có tham số
        public XeMay(string bien_so, int nam_dang_ky)
        {
            this.bien_so = bien_so;
            this.nam_dang_ky = nam_dang_ky;   
        }
        //Nhập thông tin xe máy
        public virtual void Nhap()
        {
            Console.Write("Nhap bien so: ");
            bien_so = Console.ReadLine();
            Console.Write("Nhap nam dang ky: ");
            while (!int.TryParse(Console.ReadLine(), out nam_dang_ky))
                Console.Write("Nhap lai: ");
        }
        //Xuất thông tin xe máy
        public virtual void Xuat()
        {
            Console.WriteLine($"Bien so: {bien_so}");
            Console.WriteLine($"Nam dang ky: {nam_dang_ky}");
            Console.WriteLine($"Thoi han bao hanh: {TinhThoiHanBaoHanh()}");
        }
        //Tính thời hạn bảo hành
        public abstract double TinhThoiHanBaoHanh();
    }
    class XeDien : XeMay
    {
        //khai báo thuộc tính
        protected double dung_luong_pin;
        //khai báo không tham số
        public XeDien() : base()
        {
            this.dung_luong_pin = 0;
        }
        public XeDien(string bien_so, int nam_dang_ky, int dung_luong) : base()
        {
            dung_luong_pin = dung_luong;
        }
        //Nhập thông tin xe điện
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap dung luong pin: ");
            while (!double.TryParse(Console.ReadLine(), out dung_luong_pin))
                Console.Write("Nhap lai: ");
        }
        //Xuất thông tin xe điện
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Dung luong pin : {dung_luong_pin}Wh");
        }
        //tính thời hạn bảo hành
        public override double TinhThoiHanBaoHanh()
        {
            return nam_dang_ky + 3;
        }
    }
    class XeXang : XeMay
    {
        //khai báo tham số 
        protected double dung_tich_xang;
        //khởi tạo không tham số
        public XeXang() : base()
        {
            this.dung_tich_xang = 0;
        }

        public XeXang(string bien_so, int nam_dang_ky, double dung_tich) : base()
        {
            dung_tich_xang = dung_tich;
        }
        //Nhập thông tin xe xăng
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap dung tich xang: ");
            while (!double.TryParse(Console.ReadLine(), out dung_tich_xang))
                Console.Write("Nhap lai: ");
        }
        //Xuất thông tin xe điện
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Dung tich xang : {dung_tich_xang}l");
        }
        //tính thời hạn bảo hành
        public override double TinhThoiHanBaoHanh()
        {
            return nam_dang_ky + 2;
        }
    }
    class DS_XeMay
    {
        List<XeMay> ls;
        public void NhapDS()
        {
            ls = new List<XeMay>();
            int n;
            Console.Write("Nhap so luong xe: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 1 || n >= 20)
                Console.Write("Nhap lai: ");
            //nhập vào n đối tượng
            byte chon;//chon = 1 -> tạo ra đối tượng xe điện, ngược lại -> xe xăng
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Xe thu {i + 1} la xe dien hay xe xang (1.XeDien): ");
                while (!byte.TryParse(Console.ReadLine(), out chon))
                    Console.Write("Nhap lai lua chon: ");
                XeMay xe;
                if(chon == 1)
                {
                    xe = new XeDien();
                }
                else
                {
                    xe = new XeXang();
                    xe.Nhap();
                    ls.Add(xe);
                }
            }
        }
        //Xuất danh sách
        public void XuatDS()
        {
            foreach(var xe in ls)
                xe.Xuat();
        }
        public int Dem()
        {
            //cách 1
            int c = 0;
            foreach(var xe in ls)
                if(DateTime.Now.Year > xe.TinhThoiHanBaoHanh())
                        c++;
            return c;
            ////cách 2
            //c = ls.Count(x => DateTime.Now.Year > x.TinhThoiHanBaoHanh());
            //return c;
        }
    }
}
