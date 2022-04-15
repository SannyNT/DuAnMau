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
    public class DAL_HoaDonChiTiet : DBConnect
    {
        public DataTable GetBillDetail()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "HoaDonChiTiet";
                DataTable dtKhach = new DataTable();
                dtKhach.Load(cmd.ExecuteReader());
                return dtKhach;
            }
            finally
            {
                _conn.Close();

            }
        }
        public DataTable GetHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ShowSanPham";
                DataTable dtKhach = new DataTable();
                dtKhach.Load(cmd.ExecuteReader());
                return dtKhach;
            }
            finally
            {
                _conn.Close();

            }
        }
        public bool insertDetail(DTO_HoaDonChiTiet detail)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertBillDetail";
                cmd.Parameters.AddWithValue("MaHang", detail.Mahang);
                cmd.Parameters.AddWithValue("Soluong", detail.Soluongmua);
       
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
        public bool deleteDetail(DTO_HoaDonChiTiet detail)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDetail";
                cmd.Parameters.AddWithValue("MaHang", detail.Mahang);
                cmd.Parameters.AddWithValue("Soluong", detail.Soluongmua);
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
        public DataTable HoaDonThanhToan()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TongThanhToan";
                DataTable hdtt = new DataTable();
                hdtt.Load(cmd.ExecuteReader());
                return hdtt;
            }
            finally
            {
                _conn.Close();

            }
        }
        public DataTable findHoaDon(string tenkh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SEARCHHOADON";
                cmd.Parameters.AddWithValue("TenKhach", tenkh);
                DataTable dtk = new DataTable();
                dtk.Load(cmd.ExecuteReader());
                return dtk;
            }
            finally
            {
                _conn.Close();
            }

        }
    }
}