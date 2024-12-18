using API.MODELS;
using API.DATABASE;
using MySql.Data.MySqlClient;

namespace API.SERVICE
{
    public class LoginService
    {
         public async Task<object> AccountLogin(Login newLogin)
        {

            string sql = "SELECT UserName FROM Player WHERE UserName = @UserName AND password = @Password;";
            Database myDatabase = new();


            List<MySqlParameter> parms = new();
            parms.Add(new MySqlParameter("@UserName", MySqlDbType.String) { Value = newLogin.UserName });
            parms.Add(new MySqlParameter("@Password", MySqlDbType.String) { Value = newLogin.Password });

            return await myDatabase.ValidateLogin(sql, parms);
        }
    }
}