using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BusShuttle.Models;
using BusShuttle.Service;
using Microsoft.AspNetCore.Identity;
using User = BusShuttle.Models.User;
using Microsoft.AspNetCore.Identity;

namespace BusShuttle.Controllers;

public class HomeController : Controller
{
    
    private readonly IAuthenticationService _authenticationService;
    

    
    public HomeController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }
    
    private readonly ILogger<HomeController> _logger;

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
    //}

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    // Sample list of users (replace with your actual user data retrieval mechanism)
    private static List<User> _users = new List<User>
    {
        new User(1, "admin", "password", true, false, false),
        new User(2, "driver1", "password", false, true, true),
        // Add more users as needed
    };

    public IActionResult Login()
    {
        return View();
    }
    
    
    
    
    //may need to return the model with the view
    [HttpPost]
    public IActionResult Login(String username, String password)
    {
        if (ModelState.IsValid)
            Console.WriteLine("Result of auth " + _authenticationService.Authenticate(username, password));
        {
            if (_authenticationService.Authenticate(username, password))
            {
                // Authentication successful
                // Redirect to dashboard or home page
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
                return RedirectToAction("Privacy", "Home");
            }
        }
        // If model state is invalid or authentication fails, return to login view with error
        return View();
    }
    
    

    private bool IsValidUser(string username, string password)
    {
        // test auth
        //TODO: add actual authentication in another file
        
        return (username == "admin" && password == "password");
    }

    
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}