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
    public class DAL_KhachHang:DBConnect
    {
        public DataTable GetListkh()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachKhachHang";
                DataTable dtKhach = new DataTable();
                dtKhach.Load(cmd.ExecuteReader());
                return dtKhach;
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool insertKhach(DTO_KhachHang khach)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertKhachHang";
                cmd.Parameters.AddWithValue("Dienthoai",khach.DienThoai);
                cmd.Parameters.AddWithValue("Tenkhach",khach.TenKhachHang);
                cmd.Parameters.AddWithValue("Diachi",khach.DiaChi);
                cmd.Parameters.AddWithValue("Phai",khach.GioiTinh);
                cmd.Parameters.AddWithValue("Email",khach.Emailkh);
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
        public bool updateKhach(DTO_KhachHang khach)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateKhachHang";
                cmd.Parameters.AddWithValue("Dienthoai",khach.DienThoai);
                cmd.Parameters.AddWithValue("Tenkhach",khach.TenKhachHang);
                cmd.Parameters.AddWithValue("Diachi",khach.DiaChi);
                cmd.Parameters.AddWithValue("Phai",khach.GioiTinh);
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
        public bool deleteKhachHang(string sodt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteKhachHang";
                cmd.Parameters.AddWithValue("DienThoai", sodt);
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
        public DataTable findKH(string sodt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FindKH";
                cmd.Parameters.AddWithValue("DienThoai", sodt);
                DataTable dtKH = new DataTable();
                dtKH.Load(cmd.ExecuteReader());
                return dtKH;
            }
            finally
            {
                _conn.Close();
            }

        }

    }
}
