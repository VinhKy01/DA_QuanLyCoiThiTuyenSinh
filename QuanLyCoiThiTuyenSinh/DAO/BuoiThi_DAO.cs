using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BuoiThi_DAO
    {
        static SqlConnection con;
        public static List<BuoiThi_DTO> DanhSachBuoiThi()
        {
            string query = string.Format("SELECT * FROM BUOITHI");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu thời gian DTO
            List<BuoiThi_DTO> listBuoiThi = new List<BuoiThi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BuoiThi_DTO bt = new BuoiThi_DTO();
                bt.Mabt = dt.Rows[i]["maBuoiThi"].ToString();
                bt.Tenbt = dt.Rows[i]["buoiThi"].ToString();
                listBuoiThi.Add(bt);
            }
            DataProvider.DongKetNoi(con);
            return listBuoiThi;
        }

        public static bool XoaBuoiThi_DAO(BuoiThi_DTO bt)
        {
            string query = string.Format("EXEC proc_XoaBuoiThi '{0}'", bt.Mabt);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapNhatBuoiThi_DAO(BuoiThi_DTO bt)
        {
            string query = string.Format("EXEC proc_CapNhatBuoiThi '{0}', N'{1}'", bt.Mabt, bt.Tenbt);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemBuoiThi_DAO(BuoiThi_DTO bt)
        {
            string query = string.Format("EXEC proc_ThemBuoiThi '{0}', N'{1}'", bt.Mabt, bt.Tenbt);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static BuoiThi_DTO KiemTraID_BuoiThi(BuoiThi_DTO bt)
        {
            string query = string.Format("EXEC proc_KiemTraID_BuoiThi '{0}'", bt.Mabt);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            BuoiThi_DTO buoithi = new BuoiThi_DTO();
            buoithi.Mabt = dt.Rows[0]["maBuoiThi"].ToString();
            buoithi.Tenbt = dt.Rows[0]["buoiThi"].ToString();
            DataProvider.DongKetNoi(con);
            return buoithi;
        }
    }
}
