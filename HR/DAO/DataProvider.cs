using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    internal class DataProvider
    {
        //singleton

        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            private set { DataProvider.instance = value; }
        }

        private DataProvider()
        {

        }

        //
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HRM;Integrated Security=True";

        //public DataTable ExecuteQuery(string query, string id)
        //parameter có thể null
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {

            DataTable data = new DataTable();
            //khối lệnh trong using sẽ được giải phóng khỏi bộ nhớ
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                //cmd.Parameters.AddWithValue("@userName", id);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        //trả về số dòng được thực thi: insert, update, delete
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }


                data = cmd.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        //trả về ô đầu tiên trong dataset khi query sử dụng COUNT, MAX, MIN ...
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
