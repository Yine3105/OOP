using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_TRUONGTHIBAONHI_65132499
{
    //lớp hình học
    class Shape
    {
        //khai báo tham số
        public string ten_hinh;
        //khởi tạo không tham số
        public Shape()
        {
            ten_hinh = "";
        }
        //khởi tạo có tham số 
        public Shape(string ten)
        {
            ten_hinh = ten;
        }
        //Tính chu vi
        public virtual double ChuVi()
        {
            return 0;
        }
        //Tính diện tích
        public virtual double DienTich()
        {
            return 0;
        }
        //in thông tin hình
        public virtual void InThongTinHinh()
        {
            Console.Write("Nhap ten hinh: ");
            ten_hinh = Console.ReadLine();
            Console.WriteLine($"Ten hinh: {ten_hinh}");
            Console.WriteLine($"Chu vi cua hinh: {ChuVi()}");
            Console.WriteLine($"Dien tich cua hinh: {DienTich()}");
        }
    }
    //lớp tam giác
    class Triangle : Shape
    {
        //khai báo tham số
        public double a;
        public double b;
        public double c;
        //khởi tạo không tham số
        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        //khởi tạo có tham số
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        // Tính chu vi tam giác
        public override double ChuVi()
        {
            return a + b + c;
        }
        //Tính diện tích tam giác
        public override double DienTich()
        {
            double p = ChuVi() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        //In thông tin
        public override void InThongTinHinh()
        {
            Console.WriteLine($"Canh a = {a} \nCanh b = {b} \nCanh c = {c}");
            base.InThongTinHinh();
        }
    }
    //lớp hình chữ nhật
    class Rectangle : Shape
    {
        // khai báo tham số
        public double chieu_dai;
        public double chieu_rong;
        //khởi tạo không tham số
        public Rectangle()
        {
            chieu_dai = 0;
            chieu_rong = 0;
        }
        //khởi tạo có tham số
        public Rectangle(double cd, double cr)
        {
            chieu_dai = cd;
            chieu_rong = cr;
        }
        //tính chu vi hình chữ nhật
        public override double ChuVi()
        {
            return (chieu_dai + chieu_rong) * 2;
        }
        public override double DienTich()
        {
            return chieu_dai * chieu_rong;
        }
        //In thông tin
        public override void InThongTinHinh()
        {
            Console.WriteLine($"Chieu dai = {chieu_dai}\nChieu rong = {chieu_rong} ");
            base.InThongTinHinh();
        }
    }
}
