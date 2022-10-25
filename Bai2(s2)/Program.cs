using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_s2_
{
    class Program
    {
        struct HangHoa
        {
            public int MaHH;
            public string TenHH;
            public int SoLuong;
            public float DonGia;
            public override string ToString()
            {
                return string.Format("{0} - {1} - {2} cai x {3} d = {4}", MaHH, TenHH, SoLuong, DonGia, SoLuong * DonGia);
            }
        }
        static void Main(string[] args)
        {
            List<HangHoa> dssp = new List<HangHoa>();
            HangHoa hh1;
            hh1.MaHH = 1; hh1.TenHH = "Big SG";
            hh1.SoLuong = 15; hh1.DonGia = 13500;
            HangHoa hh2 = new HangHoa()
            {
                MaHH = 2, TenHH = "Tra da", SoLuong = 1, DonGia = 1000
            };
            dssp.Add(hh2);
            foreach (HangHoa hh in dssp)
            {
                string chuoi = string.Format("{0} - {1} - {2} cai x {3} d = {4}", hh.MaHH, hh.TenHH, hh.SoLuong, hh.DonGia, hh.SoLuong * hh.DonGia);
                Console.WriteLine(hh);
            }
            Console.ReadKey();
        }
    }
}
