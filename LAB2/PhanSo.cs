using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TruongThiBaoNhi
{
    class PhanSo
    {
        public int tu_so { get; set; }
        public int mau_so { get; set; }
        //khong co tham so
        public PhanSo()
        {
            tu_so = 0;
            mau_so = 1;
        }
        //co tham so
        public PhanSo(int gia_tri_tu_so, int gia_tri_mau_so)
        {
            tu_so = gia_tri_tu_so;
            mau_so = gia_tri_mau_so;
        }
        //sao chep
        public PhanSo(PhanSo ps)
        {
            tu_so = ps.tu_so;
            mau_so = ps.mau_so;
        }
        //tinh phan so
        public void TinhToan(PhanSo ps1, PhanSo ps2, string phep_tinh)
        {
            int tuSoMoi = 0;
            int mauSoMoi = 1;
            switch(phep_tinh)
            {
                case "Cong":
                    if (ps1.mau_so != ps2.mau_so)
                    {
                        tuSoMoi = ps1.tu_so * ps2.mau_so + ps2.tu_so * ps1.mau_so;
                        mauSoMoi = ps1.mau_so * ps2.mau_so;
                    }
                    else
                    {
                        tuSoMoi = ps1.tu_so + ps2.tu_so;
                        mauSoMoi = ps1.mau_so;
                    }
                    int a = TimUCLN(tuSoMoi, mauSoMoi);
                    tuSoMoi = tuSoMoi / a;
                    mauSoMoi = mauSoMoi / a;
                    Console.WriteLine($"Ket qua phep cong : {tuSoMoi}/{mauSoMoi}");
                    break;
                case "Tru":
                    if (ps1.mau_so != ps2.mau_so)
                    {
                        tuSoMoi = ps1.tu_so * ps2.mau_so - ps2.tu_so * ps1.mau_so;
                        mauSoMoi = ps1.mau_so * ps2.mau_so;
                    }
                    else
                    {
                        tuSoMoi = ps1.tu_so - ps2.tu_so;
                        mauSoMoi = ps1.mau_so;
                    }
                    int b = TimUCLN(tuSoMoi, mauSoMoi);
                    tuSoMoi = tuSoMoi / b;
                    mauSoMoi = mauSoMoi / b;
                    Console.WriteLine($"Ket qua phep tru: {tuSoMoi}/{mauSoMoi}");
                    break;
                case "Nhan":
                    tuSoMoi = ps1.tu_so * ps2.tu_so;
                    mauSoMoi = ps1.mau_so * ps2.mau_so;
                    int c = TimUCLN(tuSoMoi, mauSoMoi);
                    tuSoMoi = tuSoMoi / c;
                    mauSoMoi = mauSoMoi / c;
                    Console.WriteLine($"Ket qua phep nhan: {tuSoMoi}/{mauSoMoi}");
                    break;
                case "Chia":
                    tuSoMoi = ps1.tu_so * ps2.mau_so;
                    mauSoMoi = ps1.mau_so * ps2.tu_so;
                    int d = TimUCLN(tuSoMoi, mauSoMoi);
                    tuSoMoi = tuSoMoi / d;
                    mauSoMoi = mauSoMoi / d;
                    Console.WriteLine($"Ket qua phep chia: {tuSoMoi}/{mauSoMoi}");
                    break;
            }    
        }
        public static int TimUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public void Show()
        {
            Console.WriteLine($"{tu_so}/{mau_so}");
        }
    }
}
