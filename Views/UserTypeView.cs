using AppEntry;

namespace AppViews;

public class UserTypeView
{   

    public static void ShowEntryScreen()
    {
        Console.Clear();
        DrawEntryScreen();
    }

    public static  void DrawEntryScreen()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Seja bem vindo a Livro teca!");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Quem é você?");

        Console.WriteLine("");

        Console.WriteLine("User.");
        Console.WriteLine("Admin.");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");

        string userType = Console.ReadLine();
        
        HandlerOption(userType);    
    }

    public static string HandlerOption(string option)
    {   
        option.ToLower();
        
        if (option == "user")
        {   
            Console.Clear();
            RegisterUserView.LoginOrRegisterUser();
        }

        if (option == "admin")
        {
            Console.Clear();
            RegisterAdminView.LoginOrRegisterAdmin();
        }

        Console.WriteLine("Valor incorreto. Insira novamente.");
        Console.ReadKey();
        Console.Clear();
        ShowEntryScreen();

        return "400";
    }
}