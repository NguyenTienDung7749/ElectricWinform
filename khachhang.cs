using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBillWinformTest
{
    public class KhachHang
    {
        string HoVaTen;
        string CCCD;
        string LoaiKhachHang;
        int SoDienThangTruoc;
        int SoDienThangNay;
        int SoTienPhaiTra;

        public KhachHang(string ten, string cccd, string loaiKhachHang, int soDienThangTruoc, int soDienThangNay)
        {
            HoVaTen = ten;
            CCCD = cccd;
            LoaiKhachHang = loaiKhachHang;
            SoDienThangTruoc = soDienThangTruoc;
            SoDienThangNay = soDienThangNay;
            SoTienPhaiTra = TinhSoTienPhaiTra();
        }
        int TinhSoTienPhaiTra()
        {
            switch (this.LoaiKhachHang)
            {
                case "Ho Gia Dinh":
                    return (this.SoDienThangNay - this.SoDienThangTruoc) * 3400;
                case "Kinh Doanh":
                    return (this.SoDienThangNay - this.SoDienThangTruoc) * 4000;
                case "Cong Ty":
                    return (this.SoDienThangNay - this.SoDienThangTruoc) * 5000;
                default:
                    return -1;
            }
        }

        public int getSoTienPhaiTra()
        {
            return this.SoTienPhaiTra;
        }

        public string getHoVaTen()
        {
            return this.HoVaTen;
        }

        public int getSoDienThangTruoc()
        {
            return this.SoDienThangTruoc;
        }

        public int getSoDienThangNay()
        {
            return this.SoDienThangNay;
        }

        public string getLoaiKhachHang()
        {
            return this.LoaiKhachHang;
        }

        public string getCCCD()
        {
            return this.CCCD;
        }     
    }
}
