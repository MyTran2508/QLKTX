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
    class StudentService
    {
        // Sql connection
        SqlConnection connection = FactoryManager.GetSqlConnection();

        // Get all employees
        public List<StudentModel> FindAll()
        {


            List<StudentModel> students = new List<StudentModel>();
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
                //string query = "SELECT * FROM GetSinhVien()";
                string query = "SELECT * FROM SinhVienOPhong";

                // Create SqlCommand
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);
                command.CommandType = CommandType.Text;

                // Get data from DB
                SqlDataReader data = command.ExecuteReader();

                // Loop get element
                while (data.Read())
                {
                    // Get data from system
                    string id = (string)data["ma_sinh_vien"];
                    string StudentName = (string)data["ho_ten"];
                    string CMND = (string)data["cmnd"];
                    string Address = (string)data["dia_chi"];
                    bool Gender = (bool)data["gioi_tinh"];
                    Int16 SchoolYear = (Int16)data["nien_khoa"];
                    string RoomId = (string)data["ma_phong"];
                    Int16 NumberOfStudent = (Int16)data["so_luong_sinh_vien_hien_tai"];
                    Int16 MaximumNumberOfStudent = (Int16)data["so_luong_sinh_vien_toi_da"];
                    StudentModel student = new StudentModel(id, StudentName, Gender, Address, CMND, SchoolYear, RoomId, NumberOfStudent, MaximumNumberOfStudent);

                    // Add in list 
                    students.Add(student);
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
            return students;
        }
        public bool Insert(StudentModel entity)
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
                string query = "sp_InsertSinhVien";
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;
                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                new SqlParameter("@ma_sv", entity.MaSinhVien),
                new SqlParameter("@ma_phong", entity.MaPhong),
                new SqlParameter("@hoten_sv", entity.HoTenSV),
                new SqlParameter("@gioitinh", entity.GioiTinh),
                new SqlParameter("@diachi", entity.DiaChi),
                new SqlParameter("@cccd", entity.CCCD),
                new SqlParameter("@nienkhoa", entity.NienKhoa),
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

        public bool Update(StudentModel entity)
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

                string query = "sp_UpdateSinhVien";
                var e = entity;
                // Create a sql command
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                new SqlParameter("@ma_sv", entity.MaSinhVien),
                new SqlParameter("@ma_phong", entity.MaPhong),
                new SqlParameter("@hoten_sv", entity.HoTenSV),
                new SqlParameter("@gioitinh", entity.GioiTinh),
                new SqlParameter("@diachi", entity.DiaChi),
                new SqlParameter("@cccd", entity.CCCD),
                new SqlParameter("@nienkhoa", entity.NienKhoa),
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

        //Remove Student
        public bool Remove(string id)
        {
            bool isDeleted = false;
            try
            {
                // Open database
                connection.Open();

                string query = "sp_DeleteSinhVien";

                // create command
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);

                // Use stored procedure
                command.CommandType = CommandType.StoredProcedure;

                // Add parameter
                command.Parameters.AddRange(new[] { new SqlParameter("@ma_sv", id) });

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
   
        public StudentModel FindBy(string maSinhVien)
        {
            StudentModel st = null;
            try
            {
                // Open database
                connection.Open();

                string query = "SELECT * FROM SinhVien WHERE ma_sinh_vien = @maSinhVien";

                // create command
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);

                // Use stored text
                command.CommandType = CommandType.Text;

                // Add parameter
                command.Parameters.Add(new SqlParameter("@maSinhVien", maSinhVien));

                // Get data from DB
                SqlDataReader data = command.ExecuteReader();

                // Loop get element
                while (data.Read())
                {
                    // Get data from system
                    string maPhong = (string)data["ma_phong"];
                    st = new StudentModel(maPhong);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return st;
        }
    }
}

