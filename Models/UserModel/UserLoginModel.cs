namespace Models;

public class UserLoginModel
{
    public string userEmail { get; set; }
    public string userPassword { get; set; }

    public UserLoginModel()
    {
    }

    public UserLoginModel(string userEmailEntry, string userPasswordEntry)
    {
        userEmail = userEmailEntry;
        userPassword = userPasswordEntry;
    }
}