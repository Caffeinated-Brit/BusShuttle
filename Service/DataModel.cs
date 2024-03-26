namespace BusShuttle.Service;

public class DataModel
{
    
}

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsManager { get; set; }
    public bool IsDriver { get; set; }
    public bool IsAuthorizedAsDriver { get; set; }
}