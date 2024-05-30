using Dapper;
using MySql.Data.MySqlClient;
using AppEntry;
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
                var parameterRegisterName = userRegister.userName;
                var parameterRegiterEmail = userRegister.userEmail;
                var parameterRegisterPassword = userRegister.userPassword;
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
                var parameterLoginName = userLogin.userName;
                var parameterLoginEmail = userLogin.userEmail;
                var parameterLoginPassword = userLogin.userPassword;
            }   
        }

        return userLogin;
    }

}