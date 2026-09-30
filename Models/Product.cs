//The basic idea behind product.cs is : 

//our API must manage products.

//SO product may have name,id,price,quantity we have.?

//Eventually we will have API endpoints like GET/Product/
// GET/Product/1 , POST, PUT , DELETE etc.



namespace CRUD_APP1.Models;
//namespace is way of organizing related C# codes.
//Basically, later when we do using CRUD_APP1.Models we will know where the product.cs is at.

public class Product
//here we create a class of Product.
//Class is basically a blueprint of object.

//lets assume football = object.
// id of football, name of football, price of football ..these are all necessary details a football may have.
//class includes all of these information.
{
    public int Id{ get;set;}
    //the access type is public
    //the data must be integer.
    //get;set means getter and setter which means its value can be read and changed.

    public string Name{get;set;}=string.Empty;
    //intially value must be "" .i.e empty
    public decimal Price{get;set;}

    public int Quantity{get;set;}
}