namespace Models;

public class UserRegisterModel
{
    public string userName { get; set; }
    public string userEmail { get; set; }
    public int userPassword { get; set; }

    public UserRegisterModel(string userNameEntry, string userEmailEntry, int userPasswordEntry)
    {
        userName = userNameEntry;
        userEmail = userEmailEntry;
        userPassword = userPasswordEntry;
    }
}