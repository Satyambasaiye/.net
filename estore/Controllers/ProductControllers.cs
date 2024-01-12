using Microsoft.AspNetCore.Mvc;
using BOL;
using SAL;
using System.Collections.Generic;

namespace estore.Controllers;
public class ProductController : Controller
{

    private readonly IProductServices _psvc;


    public ProductController(IProductServices svc)
    {
        this._psvc = svc;
    }
    [HttpGet]
    public IActionResult Products()
    {
        Console.WriteLine("in products");
        List<Product> products = _psvc.GetAll();
        
        return View(products);
    }
    public IActionResult Details(int id)
    {

       return View( _psvc.GetById(id));

    }
    //delete product

    [HttpGet]
    public IActionResult Delete(int id)
    {
        
        Console.WriteLine("deleted status: "+_psvc.DeleteById( id));
        return RedirectToAction("/product/products");
    }

}