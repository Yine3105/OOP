using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_TRUONGTHIBAONHI_65132499
{
    class Pixel
    {
        //khai báo tham si
        public double x;
        public double y;
        //khởi tạo không tham số
        public Pixel()
        {
            x = 0;
            y = 0;
        }
        //khởi tạo có tham số
        public Pixel(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
