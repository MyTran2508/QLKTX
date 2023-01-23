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
    class EmployeeService //: ServiceTemplate<EmployeeModel>
    {

        // Sql connection
        SqlConnection connection = FactoryManager.GetSqlConnection();

        // Get all employees
        public List<EmployeeModel> FindAll()
        {

            
            List<EmployeeModel> employees = new List<EmployeeModel>();
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
                string query = "SELECT * FROM fn_GetNhanVien()";

                // Create SqlCommand
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);
                command.CommandType = CommandType.Text;

                // Get data from DB
                SqlDataReader data = command.ExecuteReader();

                // Loop get element
                while (data.Read())
                {
                    // Get data from system
                    string id = (string)data["ma_nhan_vien"];
                    string EmployeeName = (string)data["ho_ten"];
                    bool Gender = (bool)data["gioi_tinh"];
                    string Address = (string)data["dia_chi"];
                    string Phonenumber = (string)data["so_dien_thoai"];
                    string Position = (string)data["chuc_vu"];
                    EmployeeModel employee = new EmployeeModel(id, EmployeeName, Gender, Address, Phonenumber, Position);

                    // Add in list 
                    employees.Add(employee);
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
            return employees;
        }
        public bool Insert(EmployeeModel entity)
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
                string query = "sp_InsertNhanVien";
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@ma_nv", entity.MaNhanVien),
                    new SqlParameter("@hoten_nv", entity.HoTenNV),
                    new SqlParameter("@gioitinh", entity.GioiTinh),
                    new SqlParameter("@diachi", entity.DiaChi),
                    new SqlParameter("@sodienthoai", entity.SoDienThoai),
                    new SqlParameter("@chucvu", entity.ChucVu),
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

        public bool Update(EmployeeModel entity)
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

                string query = "sp_UpdateNhanVien";
                // Create a sql command
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@ma_nv", entity.MaNhanVien),
                    new SqlParameter("@hoten_nv", entity.HoTenNV),
                    new SqlParameter("@gioitinh", entity.GioiTinh),
                    new SqlParameter("@diachi", entity.DiaChi),
                    new SqlParameter("@sodienthoai", entity.SoDienThoai),
                    new SqlParameter("@chucvu", entity.ChucVu),
                }) ;

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

                string query = "sp_DeleteNhanVien";

                // create command
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);

                // Use stored procedure
                command.CommandType = CommandType.StoredProcedure;

                // Add parameter
                command.Parameters.AddRange(new[] { new SqlParameter("@ma_nv", id) });

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
