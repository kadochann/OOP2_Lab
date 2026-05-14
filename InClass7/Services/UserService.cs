using System;
using System.IO;
using System.Linq;

public class UserService
{
    private string _filePath = "users.txt"; 

    public bool Register(string username, string password)
    {
        if (UserExists(username)) return false;

        string line = $"{username}; {password}";
        File.AppendAllLines(_filePath, new[] { line });
        return true;
    }

    public bool Login(string username, string password)
    {
        if (!File.Exists(_filePath)) return false; // Dosya yoksa giriş başarısız 

        var lines = File.ReadAllLines(_filePath);
        return lines.Any(l => l == $"{username}; {password}"); // Doğru eşleşme ara 
    }

    private bool UserExists(string username)
    {
        if (!File.Exists(_filePath)) return false;
        var lines = File.ReadAllLines(_filePath);
        return lines.Any(l => l.Split(';')[0].Trim() == username);
    }
}