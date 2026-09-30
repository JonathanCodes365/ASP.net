using CRUD_APP1.Models;
//because inside it we have Product.cs ... we used namespace there.
using Microsoft.AspNetCore.Mvc;
//this gives us access to many ASP.net core API functionalities such as API controller, Routes, Httpget, HttpPost..



namespace CRUD_APP1.Controllers;
//our ProductController must fall under CRUD_APP1.Controllers file
//we can use this file later when we do using CRUD_APP1.Controller.s

[ApiController]
//this tells ASP.NET CORE ==> This class is an API controller 
[Route("[controller]")]
//this determines the base URL for our controller.
public class ProductController : ControllerBase
//this : means Inheritance.
//Our Class ProductController must inherit functionality from ASP.NEt Core ko ControllerBase.
{
    private static List<Product> products = new List<Product>();
    //here we are creating a list which can contain multiple product objects?
    //This is our temporaryy database.
    //static means the List itself belongs to the controller.
    [HttpGet]
    //for all.
    public List<Product> GetProducts()
    {
        return products;
        //so what is this products we are returning ?
        //remember above we created a list named products which has Product Objects.
        //so what this means is ... give value of products back to whoever called this method.
    }

    [HttpGet("{id}")]
    //we are making endpoints for id based Get.
    //for 1 individual id.
    
    //as usual if this endpoint is triggered.. we need to create a METHOD.
    public ActionResult<Product> GetProduct(int id)
    //notice here we have kept a value of endpoint in the method.
    //id will be obtained from the URL and parametrized.
    {
        //so we want to make sure that When A http request of GET/PRODUCT/x is received.
        // if Product/X is present-- > return it
        //if product/x is absent -- > 404 :)
        //this ability to return either of them is given by ActionResult

        var product = products.FirstOrDefault(p=>p.Id ==id);

        //var means: C# figure out the type of this variable product from the value i am assigning it .
        //so these terms on the right side of the = sign will result in a value.
        //when these will be assigned to product it will have a certain data type
        //what var does is it figures out the data type of product without having us to know about it. Quite handy :):):)

        // = products. products is our list of product objects.
        //FirstOrDefault(p=>p.Id ==id) means go through these products and give me the one which is the 1st matching for this condition
        // or find me the default which matches for this condition. 

        if (product == null)
        {
            return NotFound();
        }
        return product;
        
    }

    //now adding for POST.
    //till now, we gave data we have using GET.
    //now using POST--> WE WILL RECEIVE DATA <3 :)
    [HttpPost]
    //again after every endpoint: we create a method.
    public ActionResult<Product> CreateProduct(Product product)
    //So as you can see we did Product product... this is us telling Product is object and product is the data..
    {
        //although currently we have ActionResult we are not doing any condition because
        // this endpoint may need to actually work on various kinds of requests.
        products.Add(product);
        return product;
    }
}