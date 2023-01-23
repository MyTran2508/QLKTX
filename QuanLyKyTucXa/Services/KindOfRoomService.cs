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
    class KindOfRoomService
    {
        // Sql connection
        SqlConnection connection = FactoryManager.GetSqlConnection();

        // Get all employees
        public List<KindOfRoomModel> FindAll()
        {


            List<KindOfRoomModel> kofs = new List<KindOfRoomModel>();
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
                string query = "SELECT * FROM fn_GetKindOfRoom()";

                // Create SqlCommand
                SqlCommand command = FactoryManager.GetSqlCommand(connection, query);
                command.CommandType = CommandType.Text;

                // Get data from DB
                SqlDataReader data = command.ExecuteReader();

                // Loop get element
                while (data.Read())
                {
                    // Get data from system
                    string id = (string)data["ma_loai_phong"];
                    bool KindofRoom = (bool)data["loai_phong"];
                    Int16 MaxinumNumberOfStudent = (Int16)data["so_luong_thanh_vien"];
                    KindOfRoomModel kof = new KindOfRoomModel(id, KindofRoom, MaxinumNumberOfStudent);

                    // Add in list 
                    kofs.Add(kof);
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
            return kofs;
        }
    }
}
