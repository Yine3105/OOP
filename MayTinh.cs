using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_TRUONGTHIBAONHI_65132499
{
    abstract class MayTinh
    {
        //khai bao tham số
        protected string nhan_hieu;
        protected int ram;
        protected int bo_nho;
        protected float gia_nhap;

        public string Nhan_hieu { get => nhan_hieu; set => nhan_hieu = value; }
        public int Ram { get => ram; set => ram = value; }
        public int Bo_nho { get => bo_nho; set => bo_nho = value; }
        public float Gia_nhap { get => gia_nhap; set => gia_nhap = value; }

        //khởi tạo không tham số
        public MayTinh()
        {
            nhan_hieu = "";
            ram = 0;
            bo_nho = 0;
            gia_nhap = 0;
        }
        //khởi tạo có tham số
        public MayTinh(string nh, int ram, int bonho, float nhap)
        {
            this.nhan_hieu = nh;
            this.ram = ram;
            this.bo_nho = bonho;
            this.gia_nhap = nhap;
        }
        //Nhập thông tin máy tính
        public virtual void NhapThongTin()
        {
            Console.Write("Nhap nhan hieu: ");
            nhan_hieu = Console.ReadLine();
            Console.Write("Nhap so GB cua Ram: ");
            while(!int.TryParse(Console.ReadLine(), out ram));
            Console.Write("Nhap so GB cua bo nho: ");
            while (!int.TryParse(Console.ReadLine(), out bo_nho));
            Console.Write("Nhap gia nhap: ");
            while (!float.TryParse(Console.ReadLine(), out gia_nhap));
        }
        //tính giá bán
        public abstract float TinhGiaBan();
        //Xuất thông tin
        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Nhan hieu: {nhan_hieu}");
            Console.WriteLine($"Ram: {ram}GB");
            Console.WriteLine($"Bo nho: {bo_nho}GB");
            Console.WriteLine($"Gia ban: {TinhGiaBan()}");
        }
    }
    class Laptop : MayTinh
    {
        //tham số
        protected float trong_luong;
        public float Trong_luong { get => trong_luong; set => trong_luong = value; }
        //khởi tạo không tham số
        public Laptop() : base() 
        {
            trong_luong = 0;
        }
        //khởi tạo có tham số
        public Laptop(float trong_luong) : base()
        {
            this.trong_luong= trong_luong;
        }
        //Nhập thông tin Laptop
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap trong luong cua laptop: ");
            while (!float.TryParse(Console.ReadLine(), out trong_luong));
        }
        //tính giá bán
        public override float TinhGiaBan()
        {
            if(trong_luong >= 2)
            {
               return gia_nhap + gia_nhap * 15 / 100;
            }
            else
            {
                return gia_nhap + gia_nhap * 20 / 100;
            }
        }
        //xuất thông tin
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"Trong luong cua may: {trong_luong}");
        }
    }
    class Macbook : MayTinh
    {
        //tham số
        protected string loai_Macbook;
        public string Loai_Macbook { get => loai_Macbook; set => loai_Macbook = value; }
        //khởi tạo không tham số
        public Macbook() : base()
        {
            loai_Macbook = "";
        }
        //khởi tạo có tham số
        public Macbook(string loai_Macbook) : base()
        {
            this.loai_Macbook= loai_Macbook;
        }
        //Nhập thông tin Macbook
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("Chon loai Macbook:");
            Console.WriteLine("1. MacBook Air");
            Console.WriteLine("2. MacBook Pro 13 inch");
            Console.WriteLine("3. MacBook Pro 16 inch");
            Console.Write("Nhap so tuong ung: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    loai_Macbook = "MacBook Air";
                    break;
                case "2":
                    loai_Macbook = "MacBook Pro 13 inch";
                    break;
                case "3":
                    loai_Macbook = "MacBook Pro 16 inch";
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        }
        //tính giá bán
        public override float TinhGiaBan()
        {
            if(loai_Macbook.ToLower() == "macbook air")
            {
                return gia_nhap + gia_nhap * 50 / 100;
            }
            else if(loai_Macbook.ToLower() =="macbook pro 13 inch")
            {
                return gia_nhap + gia_nhap * 80 / 100;
            }
            else
            {
                return 2 * gia_nhap;
            }
        }
        //Xuất thông tin
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"Loai Macbook: {loai_Macbook}");
        }
    }
    class QuanLyMayTinh
    {
        static MayTinh NhapMotMayTinh()
        {
            Console.WriteLine("Nhap loai may tinh(Laptop/Macbook): ");
            string loai = Console.ReadLine();
            MayTinh mt = null;
            if (loai.ToLower() == "laptop")
            {
                mt = new Laptop();
                mt.NhapThongTin();
            }
            else if (loai.ToLower() == "macbook")
            {
                mt = new Macbook();
                mt.NhapThongTin();
            }
            else
            {
                Console.WriteLine("Loai may tinh khong hop le.");
            }
            return mt;
        }

        public static void Show()
        {
            // Nhập vào một đối tượng máy tính
            Console.WriteLine("Nhap mot doi tuong may tinh");
            MayTinh mt1 = NhapMotMayTinh();
            if (mt1 != null)
            {
                Console.WriteLine("\nThong tin doi tuong vua nhap");
                mt1.XuatThongTin();
            }

            // Nhập vào n đối tượng máy tính
            Console.WriteLine("\nNhap danh sach n doi tuong may tinh");
            int n;
            do
            {
                Console.Write("Nhap so luong may tinh (2 <= n <= 30): ");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 2 && n <= 30)
                {
                    break;
                }
                Console.WriteLine("So luong khong hop le. Vui long nhap lai.");
            } while (true);

            List<MayTinh> danhSachMT = new List<MayTinh>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap thong tin may tinh thu {i + 1}:");
                MayTinh mt = NhapMotMayTinh();
                if (mt != null)
                {
                    danhSachMT.Add(mt);
                }
                else
                {
                    i--; // Nhập lại nếu không hợp lệ
                }
            }

            // Xuất thông tin n đối tượng
            Console.WriteLine("Thong tin cac doi tuong may tinh da nhap");
            foreach (var mt in danhSachMT)
            {
                mt.XuatThongTin();
            }

            // Đếm và in ra số lượng mỗi loại
            int soLaptop = danhSachMT.OfType<Laptop>().Count();
            int soMacbook = danhSachMT.OfType<Macbook>().Count();

            Console.WriteLine($"\nSo luong Laptop: {soLaptop}");
            Console.WriteLine($"So luong Macbook: {soMacbook}");
        }
    }
}
