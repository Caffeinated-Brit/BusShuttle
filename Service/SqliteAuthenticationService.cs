using Microsoft.AspNetCore.Authentication;

namespace BusShuttle.Service;

public class SqliteAuthenticationService : IAuthenticationService
{
    private readonly AppDbContext _dbContext;

    public SqliteAuthenticationService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // this is the actualy authintication logic
    public bool Authenticate(string username, string password)
    {
        PrintAllUsers();
        Console.WriteLine("authenticate hit at sqlite auth");
        // Query the database to check if the username and password match
        var user = _dbContext.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        Console.WriteLine("User " + user);
        return user != null;
    }
    
    // for testing purposes 
    public void PrintAllUsers()
    {
        var users = _dbContext.Users.ToList();

        // Print details of all users
        foreach (var user in users)
        {
            Console.WriteLine($"User ID: {user.Id}, Username: {user.Username}, Password: {user.Password}, IsManager: {user.IsManager}, IsDriver: {user.IsDriver}, IsAuthorizedAsDriver: {user.IsAuthorizedAsDriver}");
        }
    }
    
}