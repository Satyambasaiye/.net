using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EcommerseWebApp.Models;
using store.services;

namespace EcommerseWebApp.Controllers;

public class AuthController : Controller
{
    private readonly IauthServices _svc;
    public AuthController(IauthServices svc)
    {
        this._svc = svc;
    }
    public IActionResult SignIn()
    {
        return View();
    }
    [HttpPost]
    public IActionResult SignIn(string username,string password)

    {
        _svc.authenticateUser(username,password);
        return View();
    }
    
    public IActionResult Register()
    {
        Console.WriteLine("in register of auth");
    
        _svc.authenticateUser("name", "pass");

        return View();
    }
    [HttpPost]
    public IActionResult Register(string name, string email, string pass)
    {
        Console.WriteLine("insde register");
        Console.WriteLine(name + " " + email);
        _svc.addUserDetail(name, email, pass);
        return View("SignIn");
    }
    public IActionResult Authenticate()
    {
        _svc.authenticateUser("name", "pass");
        
        return View();
    }
}
