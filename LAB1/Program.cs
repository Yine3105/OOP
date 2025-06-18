using System;
namespace lab1
{
    class Program
    {
        static void Bai1_1()
        {
            string hoten;
            DateTime ngaysinh;
            bool gtnam;

            Console.Write("nhap ho ten:");
            hoten = Console.ReadLine();
            Console.Write("nhap ngay sinh:");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
            Console.Write("nhap gioi tinh (true - nam, false - nu):");
            gtnam = Convert.ToBoolean(Console.ReadLine());

            if (gtnam)
                Console.WriteLine($"{hoten}\t{ngaysinh.ToShortDateString()}\tnam");
            else
                Console.WriteLine($"{hoten}\t{ngaysinh.ToShortDateString()}\tnu");
        }
        static void Bai1_2()
        {
            string hoten;
            DateTime ngaysinh;

            Console.Write("nhap ten:");
            hoten = Console.ReadLine();
            Console.Write("nhap ngay sinh:");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());

            int tuoi = DateTime.Today.Year - ngaysinh.Year;
            if (DateTime.Today.DayOfYear < ngaysinh.DayOfYear)
            {
                tuoi--;
            }
            Console.WriteLine("{0} {1} tuoi", hoten, tuoi);
        }
        static void Bai1_3()
        {
            byte sogio;
            float luong, tienluong;

            Console.Write("nhap so gio:");
            while (!byte.TryParse(Console.ReadLine(), out sogio) || sogio > 24)
                Console.Write("nhap lai so gio lam:");
            Console.Write("nhap luong 1 gio lam:");
            while (!float.TryParse(Console.ReadLine(), out luong) || luong < 0 || luong > 50)
                Console.Write("nhap lai luong 1 gio lam:");

            if (sogio <= 8)
                tienluong = sogio * luong;
            else
                tienluong = 8 * luong + (sogio - 8) * luong * 1.5f;
            Console.Write("tien luong 1 ngay la:{0}", tienluong);
        }
        static void Bai1_4()
        {
            int a, b;
            char c;
            float? kq = null;

            Console.Write("nhap so nguyen thu 1:");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.Write("nhap lai so nguyen thu 1:");
            Console.Write("nhap so nguyen thu 2:");
            while (!int.TryParse(Console.ReadLine(), out b))
                Console.Write("nhap lai so nguyen thu 2:");
            Console.Write("nhap ky hieu phep toan (+,-,*,/):");
            while (!char.TryParse(Console.ReadLine(), out c) || (c != '+' && c != '-' && c != '*' && c != '/'))
                Console.Write("nhap lai ki hieu phep toan (+,-,*,/):");

            switch (c)
            {
                case '+': kq = a + b; break;
                case '-': kq = a - b; break;
                case '*': kq = a * b; break;
                case '/':
                    if (b != 0)
                        kq = (float)a / b;
                    else Console.Write("loi chia 0!");
                    break;
            }
            Console.WriteLine($"{a} {c} {b} = {kq}");
        }
        static void Bai1_5()
        {
            string pass;
            byte count = 0;
            do
            {
                Console.Write("nhap mat khau:");
                pass = Console.ReadLine();
                count++;
                if (pass == "123")
                {
                    Console.WriteLine("dang nhap thanh cong :))) ");
                    break;
                }
                else
                    Console.WriteLine("mat khau khong hop le :((( ");
            } while (count < 3);
        }
        static int x, y;
        static void Bai1_6()
        {
            nhap();
            boi();
            hoandoi();
            UCLN();
        }
        static void nhap()
        {
            Console.Write("nhap x:");
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.Write("nhap lai x:");
            Console.Write("nhap y:");
            while (!int.TryParse(Console.ReadLine(), out y))
                Console.Write("nhap lai y:");
        }
        static void boi()
        {
            if (x % y == 0)
                Console.WriteLine($"{x} la boi cua {y}");
            else if (y % x == 0)
                Console.WriteLine($"{y} la boi cua {x}");
            else
                Console.WriteLine("khong so nao la boi!!!");
        }
        static void hoandoi()
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"x={x}, y={y}");
        }
        static void UCLN()
        {
            int a = x;
            int b = y;
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine($"UCLN cua {x} va {y} la: {a}");
        }
        static void Bai1_7()
        {
            int n = NhapSoLuongPhanTu();
            int[] danhSach = NhapDanhSach(n);
            SapXep(danhSach);
            InDanhSach(danhSach);
        }
        static int NhapSoLuongPhanTu()
        {
            int n;
            while (true)
            {
                Console.Write("Nhap n: ");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 3 && n <= 20)
                {
                    return n;
                }
                else
                {
                    Console.WriteLine("Nhap lai n: ");
                }
            }
        }
        static int[] NhapDanhSach(int n)
        {
            int[] danhSach = new int[n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Phan tu thu {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out danhSach[i]))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nhap lai.");
                    }
                }
            }
            return danhSach;
        }
        static void SapXep(int[] danhSach)
        {
            int n = danhSach.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (danhSach[i] > danhSach[j])
                    {
                        HoanDoi(danhSach, i, j);
                    }
                }
            }
        }
        static void InDanhSach(int[] danhSach)
        {
            Console.WriteLine("Day so sau khi sap xep");
            foreach (int phanTu in danhSach)
            {
                Console.Write(phanTu + " ");
            }
            Console.WriteLine();
        }
        static void HoanDoi(int[] danhSach, int i, int j)
        {
            int temp = danhSach[i];
            danhSach[i] = danhSach[j];
            danhSach[j] = temp;
        }
        static void Bai1_8()
        {
            int nam;
            Console.Write("Nhap nam: ");
            if(int.TryParse(Console.ReadLine(), out nam))
            {
                if(Namnhuan(nam))
                {
                    Console.WriteLine($"{nam} la nam nhuan");
                }
                else
                {
                    Console.WriteLine($"{nam} khong phai la nam nhuan");
                }
            }
            else
            {
                Console.WriteLine("Nhap lai nam: ");
            }
        }
        static bool Namnhuan(int nam)
        {
            if(nam % 4 == 0)
            {
                if(nam % 100 == 0)
                {
                    return nam % 400 == 0;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        static void Bai1_9()
        {
            Console.Write("Nhap ky tu: ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            string kq = CheckChar(inputChar);
            Console.WriteLine(kq);
        }
        static string CheckChar(char inputChar)
        {
            switch (char.ToLower(inputChar))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return $"{inputChar} la nguyen am.";
                case 'b':
                case 'c':
                case 'd':
                case 'f':
                case 'g':
                case 'h':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    return $"{inputChar} la phu am.";
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return $"{inputChar} la chu so.";
                default:
                    return $"{inputChar} khong phai nguyen am, phu am hay chu so";
            }
        }
        static void Bai1_10()
        {
            Console.Write("Nhap dan so hien tai: ");
            int dshientai = int.Parse(Console.ReadLine());
            Console.Write("Nhap ty le tang dan so hang nam: ");
            double tocdotangtruong = double.Parse(Console.ReadLine());
            Console.Write("Nhap so nam: ");
            int nam = int.Parse(Console.ReadLine());
            int dstuonglai = TinhDS(dshientai, tocdotangtruong, nam);
            Console.WriteLine($"Dan so sau {nam} nam la: {dstuonglai} nguoi");
        }
        static int TinhDS(int dshientai, double tocdotangtruong, int nam)
        {
            double tangtruong = tocdotangtruong / 100;
            for (int i = 0; i < nam; i++)
            {
                dshientai = (int)(dshientai * (1 + tangtruong));
            }
            return dshientai;
        }
        static void Main(string[] args)
        {
            byte chon;
            while (true)
            {
                Console.Write("chon chay bai thu:");
                if (!byte.TryParse(Console.ReadLine(), out chon))
                {
                    Console.WriteLine("Nhap so nguyen hop le");
                    continue;
                }
                switch (chon)
                {
                    case 1: Bai1_1(); break;
                    case 2: Bai1_2(); break;
                    case 3: Bai1_3(); break;
                    case 4: Bai1_4(); break;
                    case 5: Bai1_5(); break;
                    case 6: Bai1_6(); break;
                    case 7: Bai1_7(); break;
                    case 8: Bai1_8(); break;
                    case 9: Bai1_9(); break;
                    case 10: Bai1_10(); break;
                }
            }
            /*1.11
            cau a: 15, 10
            cau b: 1, 0
            cau c: 5
            cau d: khoi tao bool chk = true -> 10
            khoi tao chk = false -> false
            cau e: 1
             */
        }
    }
}