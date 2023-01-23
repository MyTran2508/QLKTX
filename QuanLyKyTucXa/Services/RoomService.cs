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
    class RoomService
    {
        // Sql connection
        SqlConnection connection = FactoryManager.GetSqlConnection();

        // Get all employees
        public List<RoomModel> FindAll()
        {


            List<RoomModel> rooms = new List<RoomModel>();
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
                //string query = "SELECT * FROM fn_GetPhong()";
                string query = "SELECT * FROM PhongDuocTaoBoiNhanVien";
                // Create SqlCommand
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);
                command.CommandType = CommandType.Text;

                // Get data from DB
                SqlDataReader data = command.ExecuteReader();

                while (data.Read())
                {
                    // Get data from system
                    string Roomid = (string)data["ma_phong"];
                    bool KindofRoom = (bool)data["loai_phong_danh_cho"];
                    Int16 MaximumNumberofStudent = (Int16)data["so_luong_sinh_vien_toi_da"];
                    Int16 NumberofStudent = (Int16)data["so_luong_sinh_vien_hien_tai"];
                    string RoomStatus = (string)data["tinh_trang_phong"];
                    string EmployeeId = (string)data["ma_nhan_vien"];
                    string EmployeeName = (string)data["ho_ten"];
                    string Position = (string)data["chuc_vu"];
                    string PhoneNumber = (string)data["so_dien_thoai"];
                    RoomModel room = new RoomModel(Roomid, KindofRoom, MaximumNumberofStudent, NumberofStudent,RoomStatus, EmployeeId, EmployeeName, Position, PhoneNumber);
                    // Add in list 
                    rooms.Add(room);
                }

                // Loop get element
                //while (data.Read())
                //{
                //    // Get data from system
                //    string Roomid = (string)data["ma_phong"];
                //    string RoomStatus = (string)data["tinh_trang_phong"];
                //    Int16 NumberofStudent = (Int16)data["so_luong_sinh_vien_hien_tai"];
                //    bool KindofRoom = (bool)data["loai_phong"];
                //    Int16 MaximumNumberofStudent = (Int16)data["so_luong_sinh_vien_toi_da"];
                //    string EmployeeName = (string)data["ho_ten_nhan_vien"];
                //    string PhoneNumber = (string)data["so_dien_thoai_nhan_vien"];
                //    string Position = (string)data["chuc_vu"];
                //    RoomModel room = new RoomModel(Roomid, RoomStatus, NumberofStudent, KindofRoom, MaximumNumberofStudent, EmployeeName, PhoneNumber, Position);
                //    // Add in list 
                //    rooms.Add(room);
                //}
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
            return rooms;
        }

        public RoomModel GetRoomById(string id)
        {
            RoomModel room = new RoomModel();
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
                string query = "prc_GetRoomById";

                // Create SqlCommand
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddRange(new[]
                {
                    new SqlParameter("@ma_phong", id),
                });

                // Get data from DB
                SqlDataReader data = command.ExecuteReader();


                // Loop get element
                while (data.Read())
                {
                    // Get data from system
                    string Roomid = (string)data["ma_phong"];
                    string EmployeeName = (string)data["ho_ten"];
                    string RoomStatus = (string)data["tinh_trang_phong"];
                    string KindofRoomId = (string)data["ma_loai_phong"];
                    RoomModel ro = new RoomModel(Roomid,EmployeeName, RoomStatus,KindofRoomId);
                    // Add in list 
                    room = ro;
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
            return room;
        }

        public bool Insert(RoomModel entity)
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
                string query = "sp_InsertPhong";
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;
                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@ma_phong", entity.MaPhong),
                    new SqlParameter("@ma_nv", entity.MaNhanVien),
                    new SqlParameter("@tinhtrang_phong", entity.TinhTrangPhong),
                    new SqlParameter("@soluongsinhvienhientai", entity.SoLuongSinhVienHienTai),
                    new SqlParameter("@ma_loai_phong", entity.MaLoaiPhong),
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

        public bool Update(RoomModel entity)
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

                string query = "sp_UpdatePhong";
                var e = entity;
                // Create a sql command
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@ma_phong", entity.MaPhong),
                    new SqlParameter("@ma_nv", entity.MaNhanVien),
                    new SqlParameter("@tinhtrang_phong", entity.TinhTrangPhong),
                    new SqlParameter("@soluongsinhvienhientai", entity.SoLuongSinhVienHienTai),
                    new SqlParameter("@ma_loai_phong", entity.MaLoaiPhong),
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

                string query = "sp_DeletePhong";

                // create command
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);

                // Use stored procedure
                command.CommandType = CommandType.StoredProcedure;

                // Add parameter
                command.Parameters.AddRange(new[] { new SqlParameter("@ma_phong", id) });

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
