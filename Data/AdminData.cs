using Dapper;
using MySql.Data.MySqlClient;
using Models;

namespace Data;

public class AdminData
{

public static AdminRegisterModel AdminRegisterData(AdminRegisterModel adminRegister)
    {   
        string connectionString = "Server=localhost;Database=livroteca;User=root;Password=Password123#@!;";
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var adminParameterRegisterName = adminRegister.adminName;
                var adminParameterRegiterEmail = adminRegister.adminPassword;
                var adminParameterRegisterPassword = adminRegister.adminPassword;
                var adminParameterRegisterToken = adminRegister.adminToken;
            }   
        }
        return adminRegister;
    }

    public static AdminLoginModel AdminLoginData(AdminLoginModel adminLogin)
    {   
        string connectionString = "Server=localhost;Database=livroteca;User=root;Password=Password123#@!;";
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var adminParameterLoginName = adminLogin.adminName;
                var adminParameterLoginEmail = adminLogin.adminPassword;
                var adminParameterLoginPassword = adminLogin.adminPassword;
                var adminParameterLoginToken = adminLogin.adminToken;
            }   
        }

        return adminLogin;
    }
    
}