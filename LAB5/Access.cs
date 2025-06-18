using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_TRUONGTHIBAONHI_65132499
{
    internal class Access
    {
        public string Code { get; set; }
        public string Role { get; set; }
        public DateTime Time { get; set; }

        public Access(string code, string role)
        {
            Code = code;
            Role = role;
            Time = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Time.ToString("dd/MM/yyyy hh:mm:ss tt")}   {Role}";
        }
    }
}
