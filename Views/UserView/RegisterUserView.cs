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
        Console.WriteLine("Caso contrário aperte 2 para cadastrar.");
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
                break;
            
            case 2:
                RegisterUser();
                break;

            default:
                Console.WriteLine("Valor incorreto. Insira novamente.");
                Console.ReadKey();
                Console.Clear();
                LoginOrRegisterUser();
                break;
        }

        return 400;
    }

    public static void RegisterUser()
    {

    }
}
