using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TruongThiBaoNhi
{
    class Diem
    {
        public int x { get; set; }
        public int y { get; set; }
        //khong co tham so
        public Diem()
        {
            x = 0;
            y = 0;
        }
        //co tham so
        public Diem(int toa_do_x, int toa_do_y)
        {
            x = toa_do_x;
            y = toa_do_y;
        }
        //tinh khoang cach 2 diem
        public double tinh_khoang_cach(Diem diem2)
        {
            int deltaX = x - diem2.x;
            int deltaY = y - diem2.y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        //in ra diem co dang (x, y)
        public void Show()
        {
            Console.WriteLine($"Toa do ({x}, {y})");
        }
    }
}
