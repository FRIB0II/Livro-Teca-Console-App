using Dapper;
using MySql.Data.MySqlClient;
using Models;

namespace Data;

public class UserData
{
    public static UserRegisterModel UserRegisterData(UserRegisterModel userRegister)
    {   
        string connectionString = "Server=localhost;Database=livroteca;User=root;Password=Password123#@!;";
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var userParameterRegisterName = userRegister.userName;
                var userParameterRegiterEmail = userRegister.userEmail;
                var userParameterRegisterPassword = userRegister.userPassword;
            }   
        }
        return userRegister;
    }

    public static UserLoginModel UserLoginData(UserLoginModel userLogin)
    {   
        string connectionString = "Server=localhost;Database=livroteca;User=root;Password=Password123#@!;";
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var userParameterLoginName = userLogin.userName;
                var userParameterLoginEmail = userLogin.userEmail;
                var userParameterLoginPassword = userLogin.userPassword;
            }   
        }

        return userLogin;
    }

}