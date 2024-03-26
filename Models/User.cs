namespace BusShuttle.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsManager { get; set; }
    public bool IsDriver { get; set; }
    public bool IsAuthorizedAsDriver { get; set; }

    public User(int id, string username, string password, bool isManager, bool isDriver, bool isAuthorizedAsDriver)
    {
        Id = id;
        Username = username;
        Password = password;
        IsManager = isManager;
        IsDriver = isDriver;
        IsAuthorizedAsDriver = isAuthorizedAsDriver;
    }
    
    public void UpdateUser(string username, string password, bool isManager, bool isDriver, bool isAuthorizedAsDriver)
    {
        Username = username;
        Password = password;
        IsManager = isManager;
        IsDriver = isDriver;
        IsAuthorizedAsDriver = isAuthorizedAsDriver;
    }
}