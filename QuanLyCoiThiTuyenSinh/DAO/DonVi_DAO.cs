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
    public class DonVi_DAO
    {
        static SqlConnection con;
        public static List<DonVi_DTO> DanhSachDonVi()
        {
            string query = string.Format("SELECT * FROM DONVI");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu đơn vị DTO
            List<DonVi_DTO> listDonVi = new List<DonVi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DonVi_DTO donvi = new DonVi_DTO();
                donvi.Madonvi = dt.Rows[i]["maDonVi"].ToString();
                donvi.Tendonvi = dt.Rows[i]["tenDonVi"].ToString();
                listDonVi.Add(donvi);
            }
            DataProvider.DongKetNoi(con);
            return listDonVi;
        }

        public static bool XoaDonVi_DAO(DonVi_DTO dv)
        {
            string query = string.Format("EXEC proc_XoaDonVi '{0}'", dv.Madonvi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapNhatDonVi_DAO(DonVi_DTO dv)
        {
            string query = string.Format("EXEC proc_CapNhatDonVi '{0}', N'{1}'", dv.Madonvi, dv.Tendonvi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemDonVi_DAO(DonVi_DTO dv)
        {
            string query = string.Format("EXEC proc_ThemDonVi '{0}', N'{1}'", dv.Madonvi, dv.Tendonvi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static DonVi_DTO KiemTraID_DonVi(DonVi_DTO dv)
        {
            string query = string.Format("EXEC proc_KiemTraID_DonVi '{0}'", dv.Madonvi);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu đơn vị DTO
            DonVi_DTO donvi = new DonVi_DTO();
            donvi.Madonvi = dt.Rows[0]["maDonVi"].ToString();
            donvi.Tendonvi = dt.Rows[0]["tenDonVi"].ToString();
            DataProvider.DongKetNoi(con);
            return donvi;
        }
    }
}
