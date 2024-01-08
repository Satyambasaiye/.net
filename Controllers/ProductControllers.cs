using Microsoft.AspNetCore.Mvc;
using store.services;

namespace store.Controllers;
public class ProductControllers : Controller
{

    private readonly IProductServices _psvc;


    public ProductControllers(IProductServices svc)
    {
        this._psvc = svc;
    }
    [HttpGet]
    public IActionResult Products()
    {
        Console.WriteLine("in products");


        return View();
    }

}