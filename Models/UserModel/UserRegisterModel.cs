namespace Models;

public class UserRegisterModel
{
    public string userName { get; set; }
    public string userEmail { get; set; }
    public string userPassword { get; set; }

    public UserRegisterModel(string userNameEntry, string userEmailEntry, string userPasswordEntry)
    {
        userName = userNameEntry;
        userEmail = userEmailEntry;
        userPassword = userPasswordEntry;
    }
}