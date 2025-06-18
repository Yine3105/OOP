using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_TRUONGTHIBAONHI_65132499
{
    internal class DienThoai :IComparable<DienThoai>
    {
        //khai báo kết hợp đóng gói thuộc tính để sử dụng ngoài lớp
        public string MaSo { get; set; }
        public string NhanHieu { get; set; }
        public float GiaNhap { get; set; }
        public string HinhAnh { get; set; }//đường dẫn đến file ảnh
        //khởi tạo
        public DienThoai(string m = "", string h = "", float g = 0, string anh = "")
        {
            MaSo = m; NhanHieu = h; GiaNhap = g; HinhAnh = anh;
        }
        //tính gia bán
        public float TinhGB()
        {
            if (NhanHieu.CompareTo("iphone") == 0)
                return 1.5f * GiaNhap;
            else
                return 1.3f * GiaNhap;
        }
        //phương thức của interface ICompareable
        public int CompareTo(DienThoai other)
        {
            if (GiaNhap < other.GiaNhap) return 1;
            else if (GiaNhap == other.GiaNhap) return 0;
            else return -1;
        }
    }
}
