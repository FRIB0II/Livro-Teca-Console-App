namespace Models;

public class UserLoginModel
{
    public string userName { get; set; }
    public string userEmail { get; set; }
    public string userPassword { get; set; }

    public UserLoginModel(string userNameEntry, string userEmailEntry, string userPasswordEntry)
    {
        userName = userNameEntry;
        userEmail = userEmailEntry;
        userPassword = userPasswordEntry;
    }
}