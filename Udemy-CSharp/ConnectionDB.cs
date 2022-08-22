using Microsoft.Data.SqlClient;

namespace Udemy_CSharp
{
    public partial class ConnectionDB
    
    {
        private string connectionString = "";
        SqlConnection cnn;

        public ConnectionDB()
        {
            SqlConnection();
        }
        private void SqlConnection()
        {
            connectionString = @"";
            try
            {
                cnn = new SqlConnection(connectionString);
                cnn.Open();


                //string query = "INSERT INTO Persons VALUES (1, 'Inocencio', 'Wellinton', 'Outro lugar', 'Cidade dos Cornos');";
                //SqlCommand cmd = new SqlCommand(, cnn);
                //SqlDataReader reader = cmd.ExecuteReader();

                string query = "select * from Persons";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                reader.Close();
                cnn.Close();
                Console.WriteLine("Connection Open ! ");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.WriteLine("Fail!");
            }
        }
    }
}