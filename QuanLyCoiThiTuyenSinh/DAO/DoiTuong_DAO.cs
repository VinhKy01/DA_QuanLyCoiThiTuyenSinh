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
    public class DoiTuong_DAO
    {
        static SqlConnection con;
        public static List<DoiTuong_DTO> DanhSachDoiTuong()
        {
            string query = string.Format("SELECT * FROM DOITUONG");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu đối tượng DTO
            List<DoiTuong_DTO> listDoiTuong = new List<DoiTuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DoiTuong_DTO doituong = new DoiTuong_DTO();
                doituong.Madoituong = dt.Rows[i]["maDoiTuong"].ToString();
                doituong.Tendoituong = dt.Rows[i]["tenDoiTuong"].ToString();
                listDoiTuong.Add(doituong);
            }
            DataProvider.DongKetNoi(con);
            return listDoiTuong;
        }

        public static bool XoaDoiTuong_DAO(string madoituong)
        {
            string query = string.Format("EXEC proc_DoiTuong '{0}'", madoituong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemDoiTuong_DAO(DoiTuong_DTO dt)
        {
            string query = string.Format("EXEC proc_ThemDoiTuong '{0}', N'{1}'", dt.Madoituong, dt.Tendoituong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static DoiTuong_DTO KiemTraID_DoiTuong(DoiTuong_DTO doituong)
        {
            string query = string.Format("EXEC proc_KiemTraID_DoiTuong '{0}'", doituong.Madoituong);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DoiTuong_DTO dtuong = new DoiTuong_DTO();
            dtuong.Madoituong = dt.Rows[0]["maDoiTuong"].ToString();
            dtuong.Tendoituong = dt.Rows[0]["tenDoiTuong"].ToString();
            DataProvider.DongKetNoi(con);
            return dtuong;
        }

        public static bool CapNhatDoiTuong_DAO(DoiTuong_DTO dt)
        {
            string query = string.Format("EXEC proc_CapNhatDoiTuong '{0}', N'{1}'", dt.Madoituong, dt.Tendoituong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
