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
    class InvoiceService
    {
        SqlConnection connection = FactoryManager.GetSqlConnection();

        // Get all Invoices
        public List<InvoiceModel> GetAllInvoices()
        {
            List<InvoiceModel> Invoices = new List<InvoiceModel>();
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
                string query = "SELECT * FROM fn_GetHoaDon()";

                // Create SqlCommand
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);
                command.CommandType = CommandType.Text;

                // Get data from DB
                SqlDataReader data = command.ExecuteReader();

                // Loop get element
                while (data.Read())
                {
                    // Get data from system
                    string MaHoaDon = (string)data["ma_hoa_don"];
                    string MaNhanVien = (string)data["nguoi_lap_hoa_don"];
                    string MaPhong = (string)data["ma_phong"];
                    float SoM3Nuoc = (float)Convert.ToDouble(data["so_m3_nuoc"]);
                    float SoCongToDien = (float)Convert.ToDouble(data["so_cong_to_dien"]);
                    Int16 ThangGhiSo = Convert.ToInt16(data["thang_ghi_so"]);
                    double TongTien = Convert.ToDouble(data["tong_tien"]);
                    InvoiceModel Invoice = new InvoiceModel(MaHoaDon, MaPhong, SoM3Nuoc, SoCongToDien, ThangGhiSo, MaNhanVien, TongTien);

                    // Add in list 
                    Invoices.Add(Invoice);
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
            return Invoices;
        }
        public bool Insert(InvoiceModel entity)
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

                string query = "sp_InsertHoaDon";
                // Create a sql command
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@ma_hd", entity.MaHoaDon),
                    new SqlParameter("@ma_nv", entity.MaNhanVien),
                    new SqlParameter("@ma_phong", entity.MaPhong),
                    new SqlParameter("@som3nuoc", entity.SoM3Nuoc),
                    new SqlParameter("@socongtodien", entity.SoCongToDien),
                    new SqlParameter("@thang_ghiso", entity.ThangGhiSo),
                    //new SqlParameter("@tongtien", entity.TongTien),
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

        public bool Update(InvoiceModel entity)
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

                string query = "sp_UpdateHoaDon";
                // Create a sql command
                SqlCommand cmd = FactoryManager.GetSqlCommand(connection, query);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add multiple parameters to SQL 
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@ma_hd", entity.MaHoaDon),
                    new SqlParameter("@ma_nv", entity.MaNhanVien),
                    new SqlParameter("@ma_phong", entity.MaPhong),
                    new SqlParameter("@som3nuoc", entity.SoM3Nuoc),
                    new SqlParameter("@socongtodien", entity.SoCongToDien),
                    new SqlParameter("@thang_ghiso", entity.ThangGhiSo),
                    //new SqlParameter("@tongtien", entity.TongTien),
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

                string query = "sp_DeleteHoaDon";
                // create command
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);

                // Use stored procedure
                command.CommandType = CommandType.StoredProcedure;

                // Add parameter
                command.Parameters.AddRange(new[] { new SqlParameter("@ma_hd", id) });

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
