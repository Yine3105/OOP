using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TruongThiBaoNhi
{
    class Adult
    {
        public string full_name;
        public double weight;
        public double height;
        // khong tham so
        public Adult()
        {
            full_name = "";
            weight = 0;
            height = 0;
        }
        //co tham so
        public Adult(string name, double w, double h)
        {
            full_name = name;
            weight = w;
            height = h;
        }
        // sao chep
        public Adult(Adult adult)
        {
            full_name = adult.full_name;
            weight = adult.weight;
            height = adult.height;
        }
        public void Information()
        {
            Console.Write("Nhap ho va ten: ");
            full_name = Console.ReadLine();
            Console.Write("Nhap can nang: ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu cao: ");
            height = double.Parse(Console.ReadLine());
        }
        public void BMI_calculation()
        {
            double bmi = weight / (height * height);
            Console.WriteLine("Chi so BMI: " + bmi.ToString("F2"));
            if (bmi < 18.5)
            {
                Console.WriteLine("Tinh trang: Thieu can");
                weight_calculation(bmi);
            }   
            else if (bmi <= 25)
            {
                Console.WriteLine("Tinh trang: Binh thuong (suc khoe tot)");
                weight_calculation(bmi);
            }
            else
            {
                Console.WriteLine("Tinh trang: Thua can");
                weight_calculation(bmi);
            }
        }
        public void weight_calculation(double bmi)
        {
            double weight_calcu = 0;
            //tinh can nang can thiet
            if (bmi < 18.5)
            {
                weight_calcu = 18.5 * height * height - weight;
            }
            else if (bmi > 25)
            {
                weight_calcu = 25 * height * height - weight;
            }    
            //loi khuyen
            if (weight_calcu > 0)
            {
                Console.WriteLine("Ban can tang can " + weight_calcu.ToString("F2"));
            }   
            else if (weight_calcu < 0)
            {
                Console.WriteLine("Ban can giam can " + weight_calcu.ToString("F2"));
            }
        }
        public void Show()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Ho va ten: " + full_name);
            Console.WriteLine("Can nang: " + weight + " kg");
            Console.WriteLine("Chieu cao: " + height + " m");
            BMI_calculation();
        }
    }
}
