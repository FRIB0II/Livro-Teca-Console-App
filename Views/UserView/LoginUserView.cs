using Data;
using Models;

namespace AppEntry;

public class LoginUserView
{
    public static void RegisterOrLoginUser()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Login de usuário.");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Entre na Livro Teca.");
        Console.WriteLine("Caso não tenha uma conta aperte 1.");
        Console.WriteLine("Caso contrário aperte 2 para entrar em uma conta existente.");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");
        short userChoise = short.Parse(Console.ReadLine());
        HandlerOption(userChoise);
    }

    public static short HandlerOption(short option)
    {   
        switch (option)
        {
            case 1:
                Console.Clear();
                RegisterUserView.LoginOrRegisterUser();
                break;
            
            case 2:
                Console.Clear();
                LoginUser();
                break;

            default:
                Console.WriteLine("Valor incorreto. Insira novamente.");
                Console.ReadKey();
                Console.Clear();
                RegisterOrLoginUser();
                break;
        }

        return 0;
    }

    public static void LoginUser()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Login de usuário.");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Por favor informe os seguintes dados:");
        Console.WriteLine("Nome");
        Console.WriteLine("Email");
        Console.WriteLine("Senha");
        Console.WriteLine("------------------------------");
        
        Console.Write("Nome: ");
        string userName = Console.ReadLine();

        Console.Write("Email: ");
        string userEmail = Console.ReadLine();

        Console.Write("Senha: ");
        int userPassword = int.Parse(Console.ReadLine());

        UserLoginModel userLogin = new UserLoginModel(userName, userEmail, userPassword);

        UserData.UserLoginData(userLogin);
    }
}