using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TruongThiBaoNhi
{
    class TimeCaculation
    {
        public class Time
        {
            // Thuộc tính
            public int hour { get; set; }
            public int minute { get; set; }
            public int second { get; set; }

            // Constructor mặc định
            public Time()
            {
                hour = 0;
                minute = 0;
                second = 0;
            }

            // Constructor có tham số
            public Time(int h, int m, int s)
            {
                hour = h;
                minute = m;
                second = s;
            }

            //Phương thức hiển thị thông tin
            public int GetHour()
            {
                return hour;
            }
            public void SetHour(int i)
            {
                hour = i;
            }
            public void Show()
            {
                Console.WriteLine($"{hour}:{minute}:{second}");
            }
            public int Second_Count()
            {
                int result = 0;
                result = (hour * 3600) + (minute * 60) + second;
                return result;
            }
        }
    }
}
