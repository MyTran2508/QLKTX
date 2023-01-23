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
    class ReceiptService
    {
        // Sql connection
        SqlConnection connection = FactoryManager.GetSqlConnection();

        public List<ReceiptModel> FindAll()
        {
            List<ReceiptModel> receipts = new List<ReceiptModel>();

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
                string query = "SELECT * FROM fn_GetBienLai()";

                // Create SqlCommand
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);
                command.CommandType = CommandType.Text;

                // Get data from DB
                SqlDataReader data = command.ExecuteReader();

                // Loop get element
                while (data.Read())
                {
                    // Get data from system
                    string receiptId = (string)data["ma_bien_lai"];
                    string employeeID = (string)data["ma_nhan_vien"];
                    string roomID = (string)data["ma_phong"];
                    string schoolYear = (string)data["nam_hoc"];
                    double fee = Convert.ToDouble(data["so_tien"]);
                    DateTime date = Convert.ToDateTime(data["ngay_thu"]);
                    string studentID = (string)data["ma_sinh_vien"];
                    ReceiptModel receipt = new ReceiptModel(receiptId, employeeID, roomID, schoolYear, fee, date, studentID);
                    // Add in list 
                    receipts.Add(receipt);
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
            return receipts;
        }
    public List<ReceiptModel> GetView()
    {
        List<ReceiptModel> receipts = new List<ReceiptModel>();

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
            string query = "SELECT * FROM BienLaiOPhongCuaSinhVienDuocTaoBoiNhanVien";

            // Create SqlCommand
            SqlCommand command = FactoryManager.GetSqlCommand(connection, query);
            command.CommandType = CommandType.Text;

            // Get data from DB
            SqlDataReader data = command.ExecuteReader();

            // Loop get element
            while (data.Read())
            {
                // Get data from system
                string receiptId = (string)data["ma_bien_lai"];
                string schoolYear = (string)data["nam_hoc"];
                DateTime date = (DateTime)data["ngay_thu"];
                float fee = (float)data["so_tien"];
                string employeeName = (string)data["ho_ten_NV"];
                string roomID = (string)data["ma_phong"];
                string studentName = (string)data["ho_ten_SV"];
                ReceiptModel receipt = new ReceiptModel(receiptId, employeeName, roomID, schoolYear, fee, date, studentName);
                // Add in list 
                receipts.Add(receipt);
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
        return receipts;
    }
    public bool Insert(ReceiptModel entity)
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
                string query = "sp_InsertBienLai";
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@bienlai", entity.MaBienLai),
                    new SqlParameter("@ma_nv", entity.MaNhanVien),
                    new SqlParameter("@ma_phong", entity.MaPhong),
                    new SqlParameter("@nam_hoc", entity.NamHoc),
                    // new SqlParameter("@sotien", entity.SoTien),
                    new SqlParameter("@ngaythu", entity.NgayThu),
                    new SqlParameter("@ma_sv", entity.MaSinhVien)
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
        public bool Update(ReceiptModel entity)
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

                string query = "sp_UpdateBienLai";
                // Create a sql command
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@bienlai", entity.MaBienLai),
                    new SqlParameter("@ma_nv", entity.MaNhanVien),
                    new SqlParameter("@ma_phong", entity.MaPhong),
                    new SqlParameter("@nam_hoc", entity.NamHoc),
                   // new SqlParameter("@sotien", entity.SoTien),
                    new SqlParameter("@ngaythu", entity.NgayThu),
                    new SqlParameter("@ma_sv", entity.MaSinhVien)
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

                string query = "sp_DeleteBienLai";

                // create command
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);

                // Use stored procedure
                command.CommandType = CommandType.StoredProcedure;

                // Add parameter
                command.Parameters.AddRange(new[] { new SqlParameter("@bienlai", id) });

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
