namespace Models;

public class AdminLoginModel
{
    public string adminName { get; set; }
    public string adminEmail { get; set; }
    public string adminPassword { get; set; }
    public string adminToken { get; set; }

    public AdminLoginModel(string adminNameEntry, string adminEmailEntry, string adminPasswordEntry, string adminTokenEntry)
    {
        adminName = adminNameEntry;
        adminEmail = adminEmailEntry;
        adminPassword = adminPasswordEntry;
        adminToken = adminTokenEntry;
    }
}