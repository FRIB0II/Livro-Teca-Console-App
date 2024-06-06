using Models;
using Data;

namespace AppEntry;

public class RegisterAdminView
{
    public static void LoginOrRegisterAdmin()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Cadastro de administrador.");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Cadastre-se na Livro Teca como administrador.");
        Console.WriteLine("");
        Console.WriteLine("Caso já tenha uma conta aperte 1.");
        Console.WriteLine("");
        Console.WriteLine("Caso contrário aperte 2 para se cadastrar.");
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
                LoginAdminView.RegisterOrLoginAdmin();
                break;
            
            case 2:
                Console.Clear();
                RegisterAdmin();
                break;

            default:
                Console.WriteLine("Valor incorreto. Insira novamente.");
                Console.ReadKey();
                Console.Clear();
                LoginOrRegisterAdmin();
                break;
        }

        return 0;
    }

    public static void RegisterAdmin()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Cadastro de Administrador.");
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

        AdminRegisterModel adminRegister = new AdminRegisterModel(adminName, adminEmail, adminPassword, adminToken);

        AdminData.AdminRegisterData(adminRegister);
    }
}