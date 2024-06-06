using Dapper;
using MySql.Data.MySqlClient;
using Models;
using AppEntry;
using AppViews;

namespace Data;

public class UserData
{
    public static UserRegisterModel UserRegisterData(UserRegisterModel userRegister)
    {
        string connectionString = "Server=localhost;Database=livroteca;User=root;Password=Password123#@!;";
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    var userParameterRegisterName = userRegister.userName;
                    var userParameterRegiterEmail = userRegister.userEmail;
                    var userParameterRegisterPassword = userRegister.userPassword;

                    var query = @"INSERT INTO Usuario (Nome, Email, Senha) 
                            VALUES (@Nome, @Email, @Senha)";

                    var parameters = new { Nome = userParameterRegisterName, Email = userParameterRegiterEmail, Senha = userParameterRegisterPassword };

                    connection.Execute(query, parameters);
                    connection.Close();

                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Indo para o login.");
                    Console.Clear();
                    LoginUserView.LoginUser();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("O email já está cadastrado. Tente novamente.");
                    Console.ReadKey();
                    Console.Clear();
                    RegisterUserView.RegisterUser();
                }
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
                try
                {
                    connection.Open();

                    var userParameterLoginEmail = userLogin.userEmail;
                    var userParameterLoginPassword = userLogin.userPassword;

                    var queryEmailUser = @"SELECT Email FROM Usuario WHERE Email = @Email";
                    var parameterEmailUser = new { Email = userParameterLoginEmail };
                    var resultQueryEmail = connection.QuerySingle(queryEmailUser, parameterEmailUser);

                    var queryPasswordUser = @"SELECT Senha FROM Usuario WHERE Senha = @Password";
                    var parameterPasswordUser = new { Password = userParameterLoginPassword };
                    var resultQueryPassword = connection.QuerySingle(queryPasswordUser, parameterPasswordUser);

                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Conta verificada. Entrando na Livro Teca.");
                    
                    connection.Close();
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("O usuário não existe. Tente novamente.");
                    Console.ReadKey();
                    Console.Clear();
                    LoginUserView.LoginUser();
                }

            }
        }
        return userLogin;
    }

    public static short HandlerOption(short option)
    {
        switch (option)
        {
            case 1:
                Console.Clear();
                LoginUserView.LoginUser();
                break;

            case 2:
                Console.Clear();
                RegisterUserView.RegisterUser();
                break;

            default:
                Console.WriteLine("Valor incorreto. Voltando a tela inicial.");
                Console.ReadKey();
                Console.Clear();
                UserTypeView.DrawEntryScreen();
                break;
        }

        return 0;
    }
}