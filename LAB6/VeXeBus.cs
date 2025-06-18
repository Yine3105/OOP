using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_TRUONGTHIBAONHI_65132499
{
    internal class VeXeBus
    {
        //khai báo thuộc tính
        protected int tuyen_xe;
        protected const int gia_san = 5000;
        protected string doi_tuong;

        public int Tuyen_xe { get => tuyen_xe; set => tuyen_xe = value; }

        //khởi tạo không tham số
        public VeXeBus()
        {
            tuyen_xe = 0;
            doi_tuong = "";
        }
        //khởi tạo có tham số
        public VeXeBus(int tuyen_xe, string doi_tuong)
        {
            this.tuyen_xe = tuyen_xe;
            this.doi_tuong = doi_tuong;
        }
        //Nhập thông tin vé xe bus
        public virtual void NhapThongTinVeXe()
        {
            Console.Write("Nhap tuyen xe: ");
            while (!int.TryParse(Console.ReadLine(), out tuyen_xe))
                Console.Write("Nhap lai: ");
            Console.Write("Nhap doi tuong: ");
            doi_tuong = Console.ReadLine();
        } 
        //Xuất thông tin vé xe bus
        public virtual void XuatThongTinVeXe()
        {
            Console.WriteLine($"Tuyen xe: {tuyen_xe}");
            Console.WriteLine($"Doi tuong: {doi_tuong}");
            Console.WriteLine($"Gia san: {gia_san}");
            Console.WriteLine($"Gia ve: {TinhGiaVe()}");
        }
        //Tính giá vé
        public virtual float TinhGiaVe()
        {
            float gia_ve;
            if(doi_tuong.ToLower() == "hoc sinh" || doi_tuong.ToLower() == "sinhvien")
            {
                gia_ve = gia_san;
            }
            else
            {
                gia_ve = gia_san * 1.2f;
            }
            return gia_ve;
        }
    }
    //khai báo giao diện
    interface IMuaVeThang
    {
        byte Sothang { get; set; }
        float TinhTienGiam();
    }
    class VeXeBusLienHuyen : VeXeBus, IMuaVeThang
    {
        float so_km;
        byte sothang;

        public byte Sothang { get => sothang; set => sothang = value; }
        public float So_km { get => so_km; set => so_km = value; }

        //nhập
        public override void NhapThongTinVeXe()
        {
            base.NhapThongTinVeXe();
            Console.Write("Nhap chieu dai tuyen: ");
            while (!float.TryParse(Console.ReadLine(), out so_km))
                Console.Write("Nhap lai: ");
            Console.Write("Nhap so thang: ");
            while (!byte.TryParse(Console.ReadLine(), out sothang))
                Console.Write("Nhap lai: ");
        }
        //tính tiền giảm
        public float TinhTienGiam()
        {
            if (sothang >= 3 && so_km >= 20)
                return 15 / 100 * base.TinhGiaVe();
            else
                return 10 / 100 * base.TinhGiaVe();
        }
        //giá vé
        public override float TinhGiaVe()
        {
            return base.TinhGiaVe() - TinhTienGiam();
        }
        //xuất
        public override void XuatThongTinVeXe()
        {
            base.XuatThongTinVeXe();
            Console.WriteLine($"So thang: {sothang}");
            Console.WriteLine($"Do dai tuyen xe: {so_km}");
            Console.WriteLine($"Gia ve sau khi giam: {TinhGiaVe()}");
        }
    }
    class DS_VeXeBus
    {
        List<VeXeBusLienHuyen> ls;
        public void NhapDS()
        {
            ls = new List<VeXeBusLienHuyen>();
            int n;
            Console.Write("Nhap so ve xe bus lien huyen: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 3 || n >= 50)
                Console.Write("Nhap lai: ");
            //nhập n đối tượng
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin ve thu {0}", i + 1);
                VeXeBusLienHuyen l = new VeXeBusLienHuyen();
                l.NhapThongTinVeXe();
                ls.Add(l);
            }
        }
        //xuất
        public void XuatDS()
        {
            foreach (VeXeBusLienHuyen l in ls)
                l.XuatThongTinVeXe();
        }
        //Dem
        public int Dem()
        {
            float a, b;
            Console.Write("Nhap vao chieu dai chuyen: ");
            while (!float.TryParse(Console.ReadLine(), out a) || a <= 0)
                Console.Write("Nhap lai: ");
            Console.Write("Nhap vao chieu dai chuyen: ");
            while (!float.TryParse(Console.ReadLine(), out b) || b < a)
                Console.Write("Nhap lai: ");
            int c = 0;
            foreach(VeXeBus veXeBus in ls)
            {
                if (((VeXeBusLienHuyen)veXeBus).So_km >= a && ((VeXeBusLienHuyen)veXeBus).So_km <= b)
                    c++;
            }
            return c;
        }
        //xóa
        public void Xoa()
        {
            for (int i = 0; i < ls.Count;i++)
                if (ls[i].Tuyen_xe == 1)
                {
                    ls.RemoveAt(i);
                    i--;
                }
        }
        //thêm
        public void Them()
        {
            Console.WriteLine("Nhap thong tin doi tuong can them: ");
            VeXeBusLienHuyen ve = new VeXeBusLienHuyen();
            ve.NhapThongTinVeXe();
            int p;
            Console.Write("Nhap vi tri can them: ");
            while (!int.TryParse(Console.ReadLine(), out p) || p < 0)
                Console.Write("Nhap lai: ");
            if(p < ls.Count) 
                ls.Insert(p, ve);
            else
                ls.Add(ve);
                //Console.WriteLine("Vi tri them khong phu hop");
        }
    }
}
