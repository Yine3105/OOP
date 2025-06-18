using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_TRUONGTHIBAONHI_65132499
{
    abstract class Shape
    {
        //khởi tạo thuộc tính
        protected string shape_name;
        //khởi tạo không có tham số
        public Shape()
        {
            shape_name = "Hinh hoc";
        }
        //khởi tạo có tham số
        public Shape(string shape_name)
        {
            this.shape_name = shape_name;
        }

        public string Shape_name { get => shape_name; set => shape_name = value; }
        //nhập
        public virtual void Nhap()
        {
            
        }
        //xuất thông tin
        public virtual void Xuat()
        {
            Console.WriteLine($"{shape_name}");
        }
        //tính diện tích
        public abstract double DienTich();
    }
    interface IPaint
    {
        double DonGiaVe1DonVi { get; set; }
        double TinhChiPhiVe();
    }
    class Rectangle : Shape, IPaint
    {
        //tham số
        protected double chieu_dai;
        protected double chieu_rong;
        protected double donGiaVe1DonVi;
        // khởi tạo không tham số
        public Rectangle()
        {
            chieu_dai = 0;
            chieu_rong = 0;
        }
        //khởi tạo có tham số
        public Rectangle(double chieu_dai, double chieu_rong)
        {
            this.chieu_dai = chieu_dai;
            this.chieu_rong = chieu_rong;
        }

        public double DonGiaVe1DonVi { get => donGiaVe1DonVi; set => donGiaVe1DonVi = value; }
        public double Chieu_dai { get => chieu_dai; set => chieu_dai = value; }
        public double Chieu_rong { get => chieu_rong; set => chieu_rong = value; }
        //nhập 
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap chieu dai: ");
            while (!double.TryParse(Console.ReadLine(), out chieu_dai))
            {
                Console.Write("Nhap lai chieu dai: ");
            }
            Console.Write("Nhap chieu rong: ");
            while (!double.TryParse(Console.ReadLine(), out chieu_rong))
            {
                Console.Write("Nhap lai chieu rong: ");
            }
            Console.Write("Nhap don gia ve 1 don vi: ");
            while (!double.TryParse(Console.ReadLine(), out donGiaVe1DonVi))
            {
                Console.Write("Nhap lai don gia: ");
            }
        }
        //tính diện tích
        public override double DienTich()
        {
            return chieu_dai * chieu_rong;
        }
        //tính chi phí vẽ
        public double TinhChiPhiVe()
        {
            double dt = DienTich();
            return donGiaVe1DonVi * dt;
        }
        //xuất thông tin
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Chieu dai: {chieu_dai}");
            Console.WriteLine($"Chieu rong: {chieu_rong}");
            Console.WriteLine($"Dien tich: {DienTich()}");
            Console.WriteLine($"Chi phi de ve theo dien tich: {TinhChiPhiVe()}");
        }
    }
    class DS_HCN
    {
        List<Rectangle> ls;
        public void NhapDS()
        {
            ls = new List<Rectangle>();
            int n;
            Console.Write("Nhap so hinh chu nhat: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 2 || n >= 10)
                Console.Write("Nhap lai: ");
            //nhập n đối tượng
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin hinh chu nhat thu {0}", i + 1);
                Rectangle l = new Rectangle();
                l.Nhap();
                ls.Add(l);
            }
        }
        //xuất
        public void XuatDS()
        {
            foreach (Rectangle l in ls)
                l.Xuat();
        }
        //sắp xếp giảm dần theo chi phí vẽ
        public void SapXepGiamDan()
        {
            ls.Sort();
            Console.WriteLine("Danh sach hinh chu nhat sau khi sap xep giam dan theo chi phi ve: ");
            XuatDS();
        }
        //Xóa hình chữ nhật đầu tiên có diện tích nhỏ hơn x
        public void XoaHCN(double x)
        {
            Rectangle hinh_chu_nhat_can_xoa = ls.FirstOrDefault(rect => rect.DienTich() < x);
            if(hinh_chu_nhat_can_xoa == null)
            {
                Console.WriteLine($"Khong tim thay hinh chu nhat nao nho hon {x}");
            }
            else
            {
                ls.Remove(hinh_chu_nhat_can_xoa);
                Console.WriteLine($"Da xoa hinh chu nhat nho hon {x}");
            }
        }
        //thêm hình chữ nhật ở vị trí i
        public void ThemHinhChuNhat(int i)
        {
            if (i >= 0 && i <= ls.Count)
            {
                Console.WriteLine("Nhap thong tin cua hinh chu nhat muon them vao: ");
                Rectangle newRectangle = new Rectangle();
                newRectangle.Nhap();
                ls.Insert(i, newRectangle);
                Console.WriteLine($"Da them hinh chu nhat moi vao vi tri {i}");
            }
            else
            {
                Console.WriteLine($"Vi tri khong hop le");
            }
        }
        // Tính và in ra tổng chi phí vẽ của n hình chữ nhật
        public double TinhTongChiPhiVe()
        {
            double tongChiPhi = 0;
            foreach (Rectangle rect in ls)
            {
                tongChiPhi += rect.TinhChiPhiVe();
            }
            return tongChiPhi;
        }
    }
}
