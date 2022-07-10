using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Security.Cryptography;
using System.Collections.ObjectModel;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        public static TaiKhoan_DTO DangNhap_BUS(TaiKhoan_DTO tk)
        {
            MD5 md5Hash = MD5.Create();
            string MKMH = TaiKhoan_BUS.GetMd5Hash(md5Hash, tk.Matkhau);
            return TaiKhoan_DAO.DangNhap_DAO(tk, MKMH);
        }

        //Mã hóa mật khẩu
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static bool ThemTaiKhoan_BUS(TaiKhoan_DTO tk)
        {
            MD5 md5Hash = MD5.Create();
            string MKhauMoiMH = TaiKhoan_BUS.GetMd5Hash(md5Hash, tk.Matkhau);
            return TaiKhoan_DAO.ThemTaiKhoan_DAO(tk, MKhauMoiMH);
        }

        public static List<TaiKhoan_DTO> DanhSachNguoiDung_BUS()
        {
            return TaiKhoan_DAO.DanhSachNguoiDung_DAO();
        }

        public static bool CapNhatMatKhau_BUS(TaiKhoan_DTO taikhoan, string mKMoi)
        {
            MD5 md5Hash = MD5.Create();
            string MKhauMoiMH = TaiKhoan_BUS.GetMd5Hash(md5Hash, mKMoi);
            return TaiKhoan_DAO.CapNhatMatKhau_DAO(taikhoan, MKhauMoiMH);
        }

        public static TaiKhoan_DTO KiemTraIDTaiKhoan_BUS(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.KiemTraIDTaiKhoan_DAO(tk);
        }

        public static bool XoaTaiKhoan_BUS(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.XoaTaiKhoan_DAO(tk);
        }

        public static bool ResetMK_BUS(TaiKhoan_DTO tk)
        {
            MD5 md5Hash = MD5.Create();
            string mKMoi = "123";
            string MKhauMoiMH = TaiKhoan_BUS.GetMd5Hash(md5Hash, mKMoi);
            return TaiKhoan_DAO.ResetMK_DAO(tk, MKhauMoiMH);
        }

        public static bool PhanQuyen_BUS(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.PhanQuyen_DAO(tk);
        }

        public static bool XoaFK_TaiKhoan_BUS(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.XoaFK_TaiKhoan_DAO(tk);
        }
    }
}
