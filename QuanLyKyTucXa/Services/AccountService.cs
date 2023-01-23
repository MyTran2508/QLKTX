using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKyTucXa.Models;
using QuanLyKyTucXa.Utils.Factory;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QuanLyKyTucXa.Services
{
    class AccountService
    {
        // Sql connection
        SqlConnection connection = FactoryManager.GetSqlConnection();

        //get account
        public List<AccountModel> GetAccounts()
        {
            List<AccountModel> accounts = new List<AccountModel>();

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
                string query = "SELECT * FROM fn_GetTaiKhoan()";

                // Create SqlCommand
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);
                command.CommandType = CommandType.Text;

                // Get data from DB
                SqlDataReader data = command.ExecuteReader();

                // Loop get element
                while (data.Read())
                {
                    // Get data from system
                    string id = (string)data["ma_tai_khoan"];
                    string employeename = (string)data["ma_nhan_vien"];
                    string username = (string)data["ten_dang_nhap"];
                    string password = (string)data["mat_khau"];
                    string role = (string)data["role"];
                    AccountModel account = new AccountModel(id, employeename, username, password, role);

                    // Add in list 
                    accounts.Add(account);
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
            return accounts;
        }
        public bool Insert(AccountModel entity)
        {
            bool isInserted = false;
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
                string query = "sp_InsertTaiKhoan";
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@ma_tai_khoan", entity.MaTaiKhoan),
                    new SqlParameter("@ma_nv", entity.MaNhanVien),
                    new SqlParameter("@ten_dang_nhap", entity.TenDangNhap),
                    new SqlParameter("@mat_khau", entity.MatKhau),
                    new SqlParameter("@role", entity.Role)
                });
                isInserted = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isInserted;
        }
        public bool Update(AccountModel entity)
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

                string query = "sp_UpdateTaiKhoan";
                // Create a sql command
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@ma_tai_khoan", entity.MaTaiKhoan),
                    new SqlParameter("@ma_nhan_vien", entity.MaNhanVien),
                    new SqlParameter("@ten_dang_nhap", entity.TenDangNhap),
                    new SqlParameter("@mat_khau", entity.MatKhau),
                    new SqlParameter("@role", entity.Role)
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
        public bool Remove(string id)
        {
            bool isDeleted = false;
            try
            {
                // Open database
                connection.Open();

                string query = "sp_DeleteTaiKhoan";

                // create command
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);

                // Use stored procedure
                command.CommandType = CommandType.StoredProcedure;

                // Add parameter
                command.Parameters.AddRange(new[] { new SqlParameter("@ma_tai_khoan", id) });

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
