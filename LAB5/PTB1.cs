using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_TRUONGTHIBAONHI_65132499
{
    class PTB1
    {
        public float b, c;

        public PTB1() { }

        public PTB1(float b, float c)
        {
            this.b = b;
            this.c = c;
        }
        //giai
        public string Giai()
        {
            if (b == 0)
            {
                if (c == 0)
                    return "Phương trình vô số nghiệm";
                else
                    return "Phương trình vô nghiệm";
            }
            else
                return "Phương trình có nghiệm x = " + (-c / b);
        }
    }
    class PTB2 : PTB1
    {
        float a;
        public PTB2() : base()
        {

        }
        public PTB2(float a, float b, float c)
        {
            this.a = a;
        }
        public new string Giai() 
        {
            if (a == 0)
            {
                return base.Giai();
            }
            else
            {
                float delta = b * b - (4 * a / c);
                if(delta < 0)
                {
                    return "Vo Nghiem";
                }
                else
                {
                    float x1 = (-b - (float)Math.Abs(delta) / (2 * a));
                    float x2 = (-b - (float)Math.Abs(delta) / (2 * a));
                    return "Phuong trinh co 2 nghiem: x1 = " + x1.ToString() + ", x2 = " + x2.ToString() + " ";
                }
            }
        }
    }
}
