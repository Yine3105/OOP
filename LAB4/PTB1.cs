using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_TRUONGTHIBAONHI_65132499
{
    class PTB1
    {
        //khai báo dữ liệu 
        public double b;
        public double c;
        //khởi tạo không tham số
        public PTB1()
        {
            b = 0;
            c = 0;
        }
        //khởi tạo có tham số
        public PTB1(double b1, double c1)
        {
            b = b1;
            c = c1;
        }
        //Phương thức nhập dữ liệu cho PTB1
        public void Nhap()
        {
            Console.Write("Nhap gia tri b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri c: ");
            c = double.Parse(Console.ReadLine());
        }
        //Phương thức xuất dữ liệu cho PTB1
        public void Xuat()
        {
            Console.WriteLine($"Phuong trinh bac nhat co dang: {b}x + {c} = 0");
        }
        //Giải và biện luận PTB1
        public void Giai()
        {
            if(b == 0)
            {
                if(c == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phuong trinh co nghiem duy nhat: x = {x}");
            }
        }
    }
    class PTB2 : PTB1
    {
        public double a;
        //khởi tạo không tham số
        public PTB2() : base()
        {
            a = 0;
        }
        //khởi tạo có tham số
        public PTB2(double a1, double b, double c) : base(b, c)
        {
            a = a1;
        }
        //Nhập dữ liệu cho PTB2
        public new void Nhap()
        {
            Console.Write("Nhap gia tri a: ");
            a = double.Parse(Console.ReadLine());
            base.Nhap();
        }
        //Giải và biện luận PTB2
        public void Giai()
        {
            if(a == 0)
            {
                // a = 0 thì pt có dạng bx + c = 0
                base.Giai();
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if(delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phuong trinh co nghiem kep: x1 = x2 = {x}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phuong trinh co hai nghiem phan biet:");
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                }
            }
        }
    }
}
