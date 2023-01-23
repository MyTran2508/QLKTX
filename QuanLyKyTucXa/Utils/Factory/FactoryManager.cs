using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


namespace QuanLyKyTucXa.Utils.Factory
{
    class FactoryManager
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectString = GetUserCache();
            //string connectString = "Data Source=LAPTOP-7LH094OF\\SQL_MYTRAN;Initial Catalog=QuanLyKyTucXaDB;uid=sa;pwd=123456"; //Integrated Security=True";
            try
            {
                SqlConnection conn = new SqlConnection(connectString);
                return conn;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private static string GetUserCache()
        {
            string connect = null;
            var currentDirectory = Directory.GetCurrentDirectory();
            var basePath = currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
            string AccountLogin = basePath + @"\AccountCache.txt";
            try
            {
                // Create a StreamReader  
                using (StreamReader reader = new StreamReader(AccountLogin))
                {
                    string user = reader.ReadLine();
                    string pass = reader.ReadLine();
                    if (user != null && pass != null)
                    {
                        connect = "Data Source=(local);Initial Catalog=QuanLyKyTucXaDB;uid=" + user + ";pwd=" + pass +";";
                    }    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            return connect;
        }
        public static SqlCommand GetSqlCommand(SqlConnection conn, string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
