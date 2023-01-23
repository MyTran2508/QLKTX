using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKyTucXa.Models;
using QuanLyKyTucXa.Utils.Factory;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKyTucXa.Services
{
    class ContractService
    {
        // Sql connection
        SqlConnection connection = FactoryManager.GetSqlConnection();

        // Get all Contracts
        public List<ContractModel> GetAllContracts()
        {


            List<ContractModel> Contracts = new List<ContractModel>();
            try
            {
                if (connection == null)
                {
                    // Create a connection
                    SqlConnection connection = FactoryManager.GetSqlConnection();
                }

                if (connection.State == ConnectionState.Open)
                    connection.Close();
                // Open a connection

                connection.Open();
                string query = "SELECT * FROM fn_GetHopDong()";

                // Create SqlCommand
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);
                command.CommandType = CommandType.Text;

                // Get data from DB
                SqlDataReader data = command.ExecuteReader();

                // Loop get element
                while (data.Read())
                {
                    // Get data from system
                    string MaHD = (string)data["ma_hop_dong"];
                    string TenNV = (string)data["ho_ten_nhan_vien_quan_ly"];
                    string TenSV = (string)data["ho_ten_sinh_vien"];
                    DateTime NgayDK = (DateTime)data["ngay_dang_ky"];
                    DateTime NgayBD = (DateTime)data["ngay_bat_dau"];
                    DateTime NgayKT = (DateTime)data["ngay_ket_thuc"];
                    string MaPhong = (string)data["ma_phong"];
                    ContractModel Contract = new ContractModel(MaHD, NgayDK, NgayBD, NgayKT, TenNV, TenSV, MaPhong);

                    // Add in list 
                    Contracts.Add(Contract);
                }
            }
            catch (Exception ex)
            {
                // Catch error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close database
                connection.Close();
            }
            return Contracts;
        }
        public bool Insert(ContractModel entity)
        {
            bool IsInsert = false;
            try
            {
                if (connection == null)
                {
                    // Create a connection
                    SqlConnection connection = FactoryManager.GetSqlConnection();
                }

                if (connection.State == ConnectionState.Closed)
                {
                    // Open a connection
                    connection.Open();
                }

                // Create a sql command
                string query = "sp_InsertHopDong";
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@ma_hd", entity.MaHopDong),
                    new SqlParameter("@ma_nv", entity.MaNhanVien),
                    new SqlParameter("@ma_sv", entity.MaSinhVien),
                    new SqlParameter("@ngay_dangky", entity.NgayDangKy),
                    new SqlParameter("@ngay_batdau", entity.NgayBatDau),
                    new SqlParameter("@ngay_ketthuc", entity.NgayKetThuc),
                });

                IsInsert = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsInsert;

        }

        public bool Update(ContractModel entity)
        {
            bool IsUpdate = false;
            try
            {
                if (connection == null)
                {
                    // Create a connection
                    SqlConnection connection = FactoryManager.GetSqlConnection();
                }

                if (connection.State == ConnectionState.Closed)
                {
                    // Open a connection
                    connection.Open();
                }

                // Create a sql command
                string query = "sp_UpdateHopDong";
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@ma_hd", entity.MaHopDong),
                    new SqlParameter("@ma_nv", entity.MaNhanVien),
                    new SqlParameter("@ma_sv", entity.MaSinhVien),
                    new SqlParameter("@ngay_dangky", entity.NgayDangKy),
                    new SqlParameter("@ngay_batdau", entity.NgayBatDau),
                    new SqlParameter("@ngay_ketthuc", entity.NgayKetThuc),
                });

                IsUpdate = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsUpdate;
        }

        public bool Remove(string MaHD)
        {
            bool isDeleted = false;
            try
            {
                // Open database
                connection.Open();

                // create command
                string query = "sp_DeleteHopDong";
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);

                // Use stored procedure
                command.CommandType = CommandType.StoredProcedure;

                // Add parameter
                command.Parameters.AddRange(new[] { new SqlParameter("@ma_hd", MaHD) });

                // execute non query and assgin isDeleted
                isDeleted = command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isDeleted;
        }

    }
}