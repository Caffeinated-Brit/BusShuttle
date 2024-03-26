namespace BusShuttle.Service;

public  interface IAuthenticationService
{
    bool Authenticate(string username, string password);
}