using PrimeraApi.Model;
using System.Data.SqlClient;

namespace PrimeraApi.Repository
{
    public static class UserHandler
    {
        public const string ConnectionString =
            "Server=DESKTOP-1B8UARM;" +
            "Database=SistemaGestion;" +
            "Trusted_Connection=True;";
        public static List<User> GetUsers()
        {

            List<User> result = new List<User>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [User]", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                User user = new User();

                                user.Id = Convert.ToInt32(dataReader["Id"]);
                                user.Name = dataReader["Name"].ToString();

                                result.Add(user);
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }

            return result;
        }
    }

}