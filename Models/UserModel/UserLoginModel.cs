namespace Models;

public class UserLoginModel
{
    public string userName { get; set; }
    public string userEmail { get; set; }
    public int userPassword { get; set; }

    public UserLoginModel(string userNameEntry, string userEmailEntry, int userPasswordEntry)
    {
        userName = userNameEntry;
        userEmail = userEmailEntry;
        userPassword = userPasswordEntry;
    }
}