using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBH;

namespace DAL_QLBH
{
    public class DAL_SANPHAM : DBConnect
    {
        public DataTable GetListHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachHang";
                DataTable dthang = new DataTable();
                dthang.Load(cmd.ExecuteReader());
                return dthang;
            }
            finally
            {
                _conn.Close();
            }

        }

        public bool insertHang(DTO_SanPham hang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertHang";
                cmd.Parameters.AddWithValue("Tenhang", hang.TenHang);
                cmd.Parameters.AddWithValue("SoLuong", hang.SoLuong);
                cmd.Parameters.AddWithValue("DonGia", hang.DonGia);
                cmd.Parameters.AddWithValue("HinhAnh", hang.HinhAnh);
                cmd.Parameters.AddWithValue("GhiChu", hang.GhiChu);
                cmd.Parameters.AddWithValue("Email", hang.Emailnv);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
        public bool UpdateHang(DTO_SanPham hang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateHang";
                cmd.Parameters.AddWithValue("Tenhang", hang.TenHang);
                cmd.Parameters.AddWithValue("SoLuong", hang.SoLuong);
                cmd.Parameters.AddWithValue("DonGia", hang.DonGia);
                cmd.Parameters.AddWithValue("HinhAnh", hang.HinhAnh);
                cmd.Parameters.AddWithValue("GhiChu", hang.GhiChu);
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
        public bool deleteHang(string mahang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteHang";
                cmd.Parameters.AddWithValue("MaHang", mahang);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
        public DataTable SearchHang(string tenhang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchHang";
                cmd.Parameters.AddWithValue("TenHang", tenhang);
                DataTable dtH = new DataTable();
                dtH.Load(cmd.ExecuteReader());
                return dtH;
            }
            finally
            {
                _conn.Close();
            }

        }
        public DataTable ThongKeHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeSP";
                DataTable dtH = new DataTable();
                dtH.Load(cmd.ExecuteReader());
                return dtH;
            }
            finally
            {
                _conn.Close();
            }

        }
        public DataTable ThongKeHangTon()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeTonKho";
                DataTable dtH = new DataTable();
                dtH.Load(cmd.ExecuteReader());
                return dtH;
            }
            finally
            {
                _conn.Close();
            }

        }
    }
}
