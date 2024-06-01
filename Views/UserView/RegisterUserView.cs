using Models;
using Data;

namespace AppEntry;

public class RegisterUserView
{
    public static void LoginOrRegisterUser()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Cadastro de usuário.");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Cadastre-se na Livro Teca.");
        Console.WriteLine("Caso já tenha uma conta aperte 1.");
        Console.WriteLine("Caso contrário aperte 2 para se cadastrar.");
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
                LoginUserView.RegisterOrLoginUser();
                break;
            
            case 2:
                Console.Clear();
                RegisterUser();
                break;

            default:
                Console.WriteLine("Valor incorreto. Insira novamente.");
                Console.ReadKey();
                Console.Clear();
                LoginOrRegisterUser();
                break;
        }

        return 0;
    }

    public static void RegisterUser()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Cadastro de usuário.");
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
        string userPassword = Console.ReadLine();

        UserRegisterModel userRegister = new UserRegisterModel(userName, userEmail, userPassword);

        UserData.UserRegisterData(userRegister);
    }
}
