using Models;
using Data;

namespace AppEntry;

public class LoginAdminView
{
    public static void RegisterOrLoginAdmin()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Login de administrador.");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Entre na Livro Teca como administrador.");
        Console.WriteLine("");
        Console.WriteLine("Caso não tenha uma conta aperte 1.");
        Console.WriteLine("");
        Console.WriteLine("Caso contrário aperte 2 para entrar em uma conta existente.");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");
        short adminChoise = short.Parse(Console.ReadLine());
        HandlerOption(adminChoise);
    }

    public static short HandlerOption(short option)
    {   
        switch (option)
        {
            case 1:
                Console.Clear();
                RegisterAdminView.LoginOrRegisterAdmin();
                break;
            
            case 2:
                Console.Clear();
                LoginAdmin();
                break;

            default:
                Console.WriteLine("Valor incorreto. Insira novamente.");
                Console.ReadKey();
                Console.Clear();
                RegisterOrLoginAdmin();
                break;
        }

        return 0;
    }

    public static void LoginAdmin()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Login de Administrador.");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Por favor informe os seguintes dados:");
        Console.WriteLine("Nome");
        Console.WriteLine("Email");
        Console.WriteLine("Senha");
        Console.WriteLine("Token");
        Console.WriteLine("------------------------------");
        
        Console.Write("Nome: ");
        string adminName = Console.ReadLine();

        Console.Write("Email: ");
        string adminEmail = Console.ReadLine();

        Console.Write("Senha: ");
        string adminPassword = Console.ReadLine();

        Console.Write("Token: ");
        string adminToken = Console.ReadLine();

        AdminLoginModel adminLogin = new AdminLoginModel(adminName, adminEmail, adminPassword, adminToken);

        AdminData.AdminLoginData(adminLogin);
    }
}